using System;
using EvalRpgLib.Beings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvalRpgTests
{
    [TestClass]
    public class ArmorTest
    {
        [TestMethod]
        public void TestArmorOK() {
            Armor armor = new Armor("Une armure banale", ArmorType.Chest, 1);
            Assert.AreEqual("Une armure banale", armor.Name);
            Assert.AreEqual(ArmorType.Chest, armor.Type);
            Assert.AreEqual(1, armor.Amount);
        }
    }
}
