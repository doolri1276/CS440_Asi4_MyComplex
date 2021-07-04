using NUnit.Framework;
using MyComplex;

namespace MyComplexTest
{
    public class MyComplexTest1
    {
        [SetUp]

        [Test]
        public void ZeroResultTest()
        {
            Complex c1 = new Complex { Real = 0, Imag = -2 };
            Complex c2 = new Complex { Real = 0, Imag = 2 };
            Complex cres = c1 + c2;
            Assert.AreEqual(0, cres.Real, "+ real result is wrong");
            Assert.AreEqual(0, cres.Imag, "+ Imag result is wrong");

            c1 = new Complex { Real = 5, Imag = 2 };
            c2 = new Complex { Real = 3, Imag = 1 };
            cres = c1 - c2;
            Assert.AreEqual(2, cres.Real, "- real result is wrong");
            Assert.AreEqual(1, cres.Imag, "- Imag result is wrong");

            c1 = new Complex { Real = 10, Imag = 10 };
            c2 = new Complex { Real = 3, Imag = 1 };
            cres = c1 / c2;
            Assert.AreEqual(4, cres.Real, "/ real result is wrong");
            Assert.AreEqual(2, cres.Imag, "/ Imag result is wrong");

            c1 = new Complex { Real = 2, Imag = 3 };
            c2 = new Complex { Real = 2, Imag = -2 };
            cres = c1 * c2;
            Assert.AreEqual(10, cres.Real, "* real result is wrong");
            Assert.AreEqual(2, cres.Imag, "* Imag result is wrong");

            c1 = new Complex { Real = 5, Imag = 0 };
            c2 = new Complex { Real = 3, Imag = 0 };
            bool b = c1 < c2;
            Assert.AreEqual(false, b, "< real result is wrong");

            b = c1 > c2;
            Assert.AreEqual(true, b, "> real result is wrong");

            c1 = new Complex { Real = 5, Imag = 2 };
            c2 = new Complex { Real = 5, Imag = 2 };
            b = c1 == c2;
            Assert.AreEqual(true, b, "== result is wrong");

            c1 = new Complex { Real = 5, Imag = 2 };
            c2 = new Complex { Real = 3, Imag = 1 };
            b = c1 != c2;
            Assert.AreEqual(true, b, "!= result is wrong");

            cres = c1++;
            Assert.AreEqual(6, cres.Real, "++ real result is wrong");
            Assert.AreEqual(2, cres.Imag, "++ Imag result is wrong");

            cres = c2--;
            Assert.AreEqual(2, cres.Real, "-- real result is wrong");
            Assert.AreEqual(1, cres.Imag, "-- Imag result is wrong");
        }

    }
}