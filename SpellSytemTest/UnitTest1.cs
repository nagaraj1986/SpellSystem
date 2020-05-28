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


        [TestMethod]
        public void TensTestwithSingleDigitRoundedValue()
        {
            Digits dgt = new Digits();


            string expectedResult = "Ten";
            int input = 10;

            string actualResult = dgt.Tens(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TensTestwithSingleDigitOddValue()
        {
            Digits dgt = new Digits();


            string expectedResult = "Ninety Nine";
            int input = 99;

            string actualResult = dgt.Tens(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
