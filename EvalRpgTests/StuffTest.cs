using System;
using EvalRpgLib.Beings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvalRpgTests
{
    [TestClass]
    public class StuffTest
    {
        [TestMethod]
        public void TestConstructorOK(){
            Stuff stuff = new Stuff("Stuff banal");
            Assert.AreEqual("Stuff banal", stuff.Name);
        }

        [TestMethod]
        public void TestAddAttributes() {
            Stuff stuff = new Stuff("Stuff banal");
            AttributEffect attributEffect = new AttributEffect();
            attributEffect.Attribute = AttributeEnum.Strength;
            attributEffect.Value = 1000;
            stuff.AddAttributEffects(attributEffect);
            Assert.AreEqual(attributEffect.Attribute, stuff.StatusEffects[0].Attribute);
            Assert.AreEqual(attributEffect.Value, stuff.StatusEffects[0].Value);
        }
    }
}
