using NUnit.Framework;
using MyComplex;

namespace MyCurrencyTest
{
    public class MyCurrencyTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Currency c1 = new Currency { Dollars = 5, Cents = 20 };
            Currency c2 = new Currency { Dollars = 2, Cents = 32 };
            
            Currency cres = c1 + c2;
            Assert.AreEqual(7, cres.Dollars, "+ Dollar result is wrong");
            Assert.AreEqual(52, cres.Cents, "+ Cents result is wrong");

            cres = c1 - c2;
            Assert.AreEqual(2, cres.Dollars, "- Dollar result is wrong");
            Assert.AreEqual(88, cres.Cents, "- Cents result is wrong");

            bool b = c1 < c2;
            Assert.AreEqual(false, b, "< Cents result is wrong");

            b = c1 > c2;
            Assert.AreEqual(true, b, "> Cents result is wrong");

            b = c1 == c2;
            Assert.AreEqual(false, b, "== result is wrong");

            b = c1 != c2;
            Assert.AreEqual(true, b, "!= result is wrong");

            cres = c1++;
            Assert.AreEqual(6, cres.Dollars, "++ Dollar result is wrong");
            Assert.AreEqual(20, cres.Cents, "++ Cents result is wrong");

            cres = c1--;
            Assert.AreEqual(4, cres.Dollars, "-- Dollar result is wrong");
            Assert.AreEqual(20, cres.Cents, "-- Cents result is wrong");
        }
    }
}