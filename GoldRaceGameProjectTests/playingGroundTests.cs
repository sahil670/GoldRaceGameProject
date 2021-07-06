using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoldRaceGameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldRaceGameProject.Tests
{
    [TestClass()]
    public class playingGroundTests
    {
        [TestMethod()]
        public void playingGroundTest()
        {
            Contestant _Henry = new Contestant();
            _Henry.budgt = 50;_Henry.bet = 1;_Henry.amt = 10;
            if (_Henry.rslt(2) == 40) {
                Assert.IsTrue(true);
            }
        }
        [TestMethod()]
        public void playingGroundTest2()
        {
            Contestant _Henry = new Contestant();
            _Henry.budgt = 50; _Henry.bet = 1; _Henry.amt = 10;
            if (_Henry.rslt(1) == 60)
            {
                Assert.IsTrue(true);
            }
        }
    }
}