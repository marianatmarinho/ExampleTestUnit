using ExempleTest;
//using ExempleTest.Test;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
       
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.Fail();
        }

        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            Assert.AreEqual(0, StringCalculator.Add(string.Empty));
        }

        [Test]
        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {
            Assert.AreEqual(5, StringCalculator.Add("5"));
        }

        [Test]
        public void VerifyValueList()
        {
            shelf.Put("Orange");
            Assert.AreEqual(true, shelf.Take("Orange"));
        }
        
        [Test]
        public void VerifyEmptyValue()
        {
            shelf.Put("");
            Assert.AreEqual(false, shelf.Take(""));
        }


        [Test]
        public void VerifyRemoveOnlyItem()
        {
            shelf.Put("Mariana");
            shelf.Take("Mariana");
            Assert.AreEqual(false, shelf.Take("Mariana"));
        }
    }
}