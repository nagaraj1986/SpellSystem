using Microsoft.VisualStudio.TestTools.UnitTesting;

using Business;

namespace SpellSytemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnesTestwithdigitZero()
        {
            Digits dgt = new Digits();

           
            string expectedResult = string.Empty;
            int input = 0;
            
            string actualResult = dgt.Ones(input);
          
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OnesTestwithMultiDigit()
        {
            Digits dgt = new Digits();

          
            string expectedResult = string.Empty;
            int input = 10;
          
            string actualResult = dgt.Ones(input);
           
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OnesTestwithSingleDigit()
        {
            Digits dgt = new Digits();


            string expectedResult = "One";
            int input = 1;

            string actualResult = dgt.Ones(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
