using NUnit.Framework;
using SRA_TestGrundlagen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGrundlagenTest
{
    public class DatenbankTest
    {
        [Test]
        //has to be public void
        public void ÖffneVerbindungTest()
        {
            Datenbank db = new Datenbank();
            var ergebnis = db.ÖffneVerbindung("123456");
            Assert.AreEqual(true, ergebnis, "Überraschenderweise nicht gleich!");
        }

        [TestCase("123456", true )]
        [TestCase("12345" , false)]
        [TestCase("x"     , true )]
        public void ÖffneVerbindungTest1(string zeichenfolge, bool erwartung)
        {
            Console.WriteLine("Start des Tests");
            Datenbank db = new Datenbank();
            var ergebnis = db.ÖffneVerbindung(zeichenfolge);
            Assert.AreEqual  (erwartung, ergebnis, "Überraschenderweise nicht gleich!");
            Console.WriteLine("Die Verbindung wurde erwartungsgemäß{0}hergestellt.", erwartung?" ":" nicht ");
        }

        [Test, TestCaseSource(typeof(TestFallKlasse), "TestFälle")]
        public void DasMitExternenDaten(string text, bool erwartung)
        {
            Console.WriteLine(text + " - " + erwartung.ToString());
            Datenbank db = new Datenbank();
            var ergebnis = db.ÖffneVerbindung(text);
            Assert.AreEqual(erwartung, ergebnis, "Überraschenderweise nicht gleich!");
        }
    }

    public class TestFallKlasse
    {
        public static IEnumerable TestFälle
        {
            get
            {
                StreamReader leser = new StreamReader(@"c:\kurs\testfälle.txt");
                while (!leser.EndOfStream)
                {
//                  yield return leser.ReadLine(); in jedem Schleifendurchlauf wird ein neues element in IEnumerable eingefügt
                    var werte = leser.ReadLine().Split(';');
                    yield return new TestCaseData(werte[0], Convert.ToBoolean(werte[1]));
                }
            }
        }
    }

}
