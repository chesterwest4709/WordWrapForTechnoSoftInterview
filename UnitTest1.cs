using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnoSoftCW;

namespace TestWordWrap
{
    [TestClass]
    public class UnitTest1
    {
        #region no target, length>0
        [TestMethod]
        public void TestNoTargetGT0Test1()
        {
            string Target = "";
            int MaxLength = 15;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength);
            Assert.IsTrue(sResult == "");
        }

        [TestMethod]
        public void TestNoTargetGT0Test2()
        {
            string Target = "";
            int MaxLength = 15;
            string sResult=TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength, false);
            Assert.IsTrue(sResult == "");
        }
        #endregion

        #region no target, length<=0
        [TestMethod]
        public void TestNoTargetLE0Test3()
        {
            string Target = "The quick brown fox jumped over the lazy dog.";
            int MaxLength = 0;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength);
            Assert.IsTrue(sResult==Target);
        }

        [TestMethod]
        public void TestNoTargetLE0Test4()
        {
            string Target = "The quick brown fox jumped over the lazy dog.";
            int MaxLength = -1;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength, false);
            Assert.IsTrue(sResult == Target);
        }
        #endregion

        #region test with maximum length
        [TestMethod]
        public void TestMaxLength()
        {
            string Target = "The quick brown fox jumped over the lazy dog.";
            int MaxLength = int.MaxValue;
            string sResult=TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength);
            Assert.IsTrue(sResult == Target);
        }
        [TestMethod]
        public void TestMaxLength2()
        {
            string Target = "The quick brown fox jumped over the lazy dog.";
            int MaxLength = int.MaxValue;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength,false);
            Assert.IsTrue(sResult == Target);
        }
        #endregion

        [TestMethod]
        public void TestBreakupAllowed()
        {
            string Target = "The quick brown fox jumped over the lazy dog.";
            int MaxLength = 15;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength);
            string sTestTarget = "The quick brown\r\nfox jumped over\r\nthe lazy dog.";
            Assert.IsTrue(sResult == sTestTarget);
        }

        [TestMethod]
        public void TestNoBreakupAllowed()
        {
            string Target = "The quick brown fox jumped over the lazy dog.";
            int MaxLength = 15;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength,false);
            string sTestTarget = "The quick brown\r\nfox jumped over\r\nthe lazy dog.";
            Assert.IsTrue(sResult == sTestTarget);
        }

        [TestMethod]
        public void TestBreakupAllowed9Char()
        {
            string Target = "The quick brown fox jumped over the lazy dog.";
            int MaxLength = 9;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength);
            string sTestTarget = "The quick\r\nbrown fox\r\njumped ov\r\ner the la\r\nzy dog.";
            Assert.IsTrue(sResult == sTestTarget);
        }

        [TestMethod]
        public void TestNoBreakupAllowed9char()
        {
            string Target = "The quick brown fox jumped over the lazy dog.";
            int MaxLength = 9;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength, false);
            string sTestTarget = "The quick\r\nbrown fox\r\njumped\r\nover the\r\nlazy dog.";
            Assert.IsTrue(sResult == sTestTarget);
        }

        [TestMethod]
        public void TestBreakupAllowedAllBlanks()
        {
            string Target = "                                             ";
            int MaxLength = 9;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength);
            string sTestTarget = Target;
            Assert.IsTrue(sResult == sTestTarget);
        }

        [TestMethod]
        public void TestNoBreakupAllowedAllBlanks()
        {
            string Target = "                                             ";
            int MaxLength = 9;
            string sResult = TechnoSoftCW.WrapString.WrapToLength(Target, MaxLength, false);
            //string sTestTarget = "";
            string sTestTarget = Target;
            Assert.IsTrue(sResult == sTestTarget);
        }

    }
}
