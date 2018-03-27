using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvalRpgLib.Beings;
using EvalRpgLib.Exemples;
using EvalRpgLib.Helpers;

namespace EvalRpgTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestUnitAttaqueKO()
        {
            Unit u1 = new Unit("unite1");
            Unit u2 = new Unit("unite2");

            Assert.IsFalse(u1.Attack(u2));
        }

        [TestMethod]
        public void TestUnitAttaqueOK() {
            Unit u1 = new Unit("unite1", null, null, new BasicSword());
            Unit u2 = new Unit("unite2", null, null, new BasicSword());
            u1.StatManager = new StatManager(u1, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            u2.StatManager = new StatManager(u2, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            u1.StatManager.Update();
            u2.StatManager.Update();

            Assert.IsTrue(u1.Attack(u2));
        }

        [TestMethod]
        public void TestTakeDamage(){
            Unit u = new Unit("unite", null, null, new BasicSword());
            u.StatManager = new StatManager(u, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            u.StatManager.Update();
            Assert.AreEqual(666, u.TakeDamage(666, false, u));
        }

        [TestMethod]
        public void TestGetCurrentStat() {
            Unit u = new Unit("unite", null, null, new BasicSword());
            u.StatManager = new StatManager(u, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            u.StatManager.Update();
            Assert.AreEqual(1100, u.GetCurrentStat(StatisticsEnum.Health));
        }

        [TestMethod]
        public void TestGetCurrentAttribute() {
            Unit u = new Unit("unite", null, null, new BasicSword());
            u.StatManager = new StatManager(u, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            u.StatManager.Update();
            Assert.AreEqual(100, u.GetCurrentAttribute(AttributeEnum.Intelligence));
        }
    }
}
