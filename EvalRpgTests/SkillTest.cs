using System;
using System.Collections.Generic;
using EvalRpgLib.Beings;
using EvalRpgLib.Exemples;
using EvalRpgLib.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvalRpgTests
{
    [TestClass]
    public class SkillTest
    {
        [TestMethod]
        public void TestSkillInitOK()
        {
            Unit u = new Unit("Unite");
            Skill s = new Skill(u);

            Assert.IsTrue(u.Name == s.Caster.Name);
        }

        [TestMethod]
        public void TestCastSkillOK()
        {
            // Bug corrigé dans la fonction UpdateStats: transformé CurrentStatistics.Clear() en CurrentStatistics = BaseStatistics
            Unit u1 = new Unit("Unite1",null, null , new BasicSword());
            Unit u2 = new Unit("Unite2", null, null, new BasicSword());
            u1.StatManager = new StatManager(u1, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            u2.StatManager = new StatManager(u2, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            u1.StatManager.Update();
            u2.StatManager.Update();
            u1.Skills.Add(new HeavyStrike(u1));
            Assert.IsTrue(u1.Skills[0].Cast(u2));
        }

        [TestMethod]
        public void TestComputePower() {
            Unit u = new Unit("unite", null, null, new BasicSword());
            u.StatManager = new StatManager(u, StatHelper.GetDefaultAttributes(), StatHelper.GetDefaultComputer());
            u.StatManager.Update();
            u.Skills.Add(new HeavyStrike(u));
            Assert.AreEqual(10010, u.Skills[0].ComputePower());
        }

    }
}
