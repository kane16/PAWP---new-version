using NUnit.Framework;
using PAWPController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWPTests
{
    [TestFixture]
    class LongwallTests
    {

        CLongwall wall;

        public LongwallTests()
        {
            CLongwall.SWDB = 2000;
            CLongwall.LDr = 252;
            CLongwall.DPSN = true;
            CLongwall.SCzP = false;
            CLongwall.LDWP = 47;
            CLongwall.LSAO = 7;
            wall = new CLongwall(1, "KWK J", "ściana 9", 85, false, 34.4, 56.8, 466.612730707973, 18, 5.3,
            3.9, 0.5, 0, 0, 1, 4, 30.9, 32.5, 22.03, 3570);
        }

        [Test]
        public void CheckEefCalculation()
        {
            Assert.AreEqual(280, wall.CalculateEef(), 1);
        }

        [Test]
        public void CheckLZPDRmaxCalculation()
        {
            Assert.AreEqual(4.56, wall.CalculateLZPDRmax(), 0.1);
        }

        [Test]
        public void CheckLZKDRmaxCalculation()
        {
            Assert.AreEqual(0.58, wall.CalculateLZKDRmax(), 0.1);
        }

        [Test]
        public void CheckTPKdmaxCalculation()
        {
            Assert.AreEqual(536.56, wall.CalculateTPKdmax(), 1);
        }

        [Test]
        public void CheckTPKzmmaxCalculation()
        {
            Assert.AreEqual(137.58, wall.CalculateTPKzmmax(), 1);
        }

        [Test]
        public void CheckWDBmaxCalculation()
        {
            Assert.AreEqual(5675.41, wall.CalculateWDBmax(), 1);
        }

        [Test]
        public void CheckRWmaxCalculation()
        {
            Assert.AreEqual(2105.41, wall.RWmax, 1);
        }

        [Test]
        public void CheckWDBminCalculator()
        {
            Assert.AreEqual(1069.93, wall.CalculateWDBmin(), 1);
        }

    }
}
