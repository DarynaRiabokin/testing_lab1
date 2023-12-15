using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace AnalaizerClassLibrary.Tests
{
    [TestClass]
    public class AnalaizerClassTests
    {
        [TestMethod]
        [DataSource("System.Data.SqlClient", "Data Source=DARYNA-PC\\SQLEXPRESS01;Initial Catalog=Lab_test;Integrated Security=True", "CheckCurrencyTable", DataAccessMethod.Sequential)]
        public void CheckCurrency_ExpressionValidity()
        {
            // Arrange
            string expression = TestContext.DataRow["expression"].ToString();
            bool expectedResult = bool.Parse(TestContext.DataRow["result"].ToString());

            AnalaizerClass.expression = expression;

            // Act
            bool result = AnalaizerClass.CheckCurrency();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        public TestContext TestContext { get; set; }
    }
}
