using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestWSUniversalLib
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void GetQuantityForProduct_Counting_Returns114148()
        {
            int answer = 114148;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistsProductType_ReturnsFalse()
        {
            int answer = -1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(4, 1, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistsMaterialType_ReturnsFalse()
        {
            int answer = -1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 0, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistsSquareWithWidth_ReturnsFalse()
        {
            int answer = -1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 0, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistsSquareWithHeigth_ReturnsFalse()
        {
            int answer = -1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 20, -3));
        }

        [TestMethod]
        public void GetQuantityForProduct_ProductTypeMinus_ReturnsFalse()
        {
            int answer = -1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(-2, 1, 15, 0, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialTypeMinus_ReturnsFalse()
        {
            int answer = -1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(2, -1, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_CountMinus_ReturnsFalse()
        {
            int answer = -1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, -15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_DoubleLength_Returns114188()
        {
            int answer = 114188;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 20.007f, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_DoubleLengthAndHeight_Returns102323()
        {
            int answer = 102323;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 20.007f, 40.324f));
        }


        [TestMethod]
        public void GetQuantityForProduct_BigHeight_ReturnsBigCount()
        {
            int answer = 1141474430;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 200000, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_BigWidth_ReturnsBigCount()
        {
            int answer = 1141474430;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 45, 200000));
        }

        [TestMethod]
        public void GetQuantityForProduct_BigData_ReturnsFalse()
        {
            int answer = -1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 32323423443242, 4543453456456));
        }

        [TestMethod]
        public void GetQuantityForProduct_LittleHeight_Returns1()
        {
            int answer = 1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 0.000002f, 45));
        }
        [TestMethod]
        public void GetQuantityForProduct_LittleWidth_Returns1()
        {
            int answer = 1;
            Calculation c = new Calculation();
            Assert.AreEqual(answer, c.GetQuantityForProduct(3, 1, 15, 0.000002f, 45));
        }

    }
}
