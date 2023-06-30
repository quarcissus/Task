using LuxoftTaskGerardoAcostaOlvera;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LuxoftTaskTest
{
    /// <summary>
    /// Test class that validates the output of the task function
    /// If new tests are required, set bills and coins as double
    /// If new tests are required, the expected output must have the following format: 
    ///     "{quantity of denomination} of {greater denomination}, {quantity of denomination2} of {next denomination}, ... ,{quantity of denomination} of {lower denomination}"
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(76.41, new double[] { 100, 50 }, "1 of 50.00US, 1 of 20.00US, 1 of 2.00US, 1 of 1.00US, 1 of 0.50US, 1 of 0.05US, 4 of 0.01US")]
        public void ReturnOptimunExchangeTest(double itemPrice, double[] customerPayment, string outputExpected)
        {
            
            decimal[] customerPaymentDecimal = customerPayment.Select(money => Convert.ToDecimal(money)).ToArray();
            var temp = Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal);
            Assert.IsTrue(Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal).Equals(outputExpected));
        }

        [TestMethod]
        [DataRow(0, new double[] { 100, 50 }, "150US")]
        public void ItemPriceEqualZeroTest(double itemPrice, double[] customerPayment, string outputExpected)
        {

            decimal[] customerPaymentDecimal = customerPayment.Select(money => Convert.ToDecimal(money)).ToArray();
            var temp = Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal);
            Assert.IsTrue(Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal).Equals(outputExpected));
        }

        [TestMethod]
        [DataRow(-1, new double[] { 100, 50 }, "Item Price must be greater than 0")]
        public void ItemPriceLessThanZeroTest(double itemPrice, double[] customerPayment, string outputExpected)
        {

            decimal[] customerPaymentDecimal = customerPayment.Select(money => Convert.ToDecimal(money)).ToArray();
            var temp = Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal);
            Assert.IsTrue(Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal).Equals(outputExpected));
        }

        [TestMethod]
        [DataRow(50, new double[] {  20 }, "Customer payment insufficient")]
        public void PaymentInsufficientTest(double itemPrice, double[] customerPayment, string outputExpected)
        {

            decimal[] customerPaymentDecimal = customerPayment.Select(money => Convert.ToDecimal(money)).ToArray();
            var temp = Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal);
            Assert.IsTrue(Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal).Equals(outputExpected));
        }

        [TestMethod]
        [DataRow(50, new double[] { 50 }, "0USD")]
        public void NoChangeTest(double itemPrice, double[] customerPayment, string outputExpected)
        {

            decimal[] customerPaymentDecimal = customerPayment.Select(money => Convert.ToDecimal(money)).ToArray();
            var temp = Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal);
            Assert.IsTrue(Program.ReturnChange(Convert.ToDecimal(itemPrice), customerPaymentDecimal).Equals(outputExpected));
        }
    }
}
