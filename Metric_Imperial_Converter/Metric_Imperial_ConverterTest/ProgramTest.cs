using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metric_Imperial_Converter;

namespace Metric_Imperial_ConverterTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ProgramTest
    {
        Program converter;

        public ProgramTest()
        {
            //
            // TODO: Add constructor logic here
            //
            converter = new Program();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /// <summary>
        /// The method should return a positive scalar value.
        /// </summary>
        [TestMethod]
        public void Convert_ReturnPositiveDouble_Test()
        {
            Assert.IsTrue(converter.Convert(200.00) >= 0.0);
        }

        /// <summary>
        /// Convert method should receive 200.00 and convert it from feet to meters. It should return a double.
        /// </summary>
        [TestMethod]
        public void Convert_200feet_to_meters()
        {
            Assert.AreEqual(60.96, converter.Convert(200.00));
        }

        /// <summary>
        /// Convert method should receive 63.5 and convert it from feet to meters. It should return a double.
        /// </summary>
        [TestMethod]
        public void Convert_63feet_to_meters()
        {
            Assert.AreEqual(19.35, converter.Convert(63.5));
        }

        /// <summary>
        /// If input is negative the method should return -1.
        /// </summary>
        [TestMethod]
        public void Convert_no_negative_numbers()
        {
            Assert.AreEqual(-1, converter.Convert(-4));
        }

        /// <summary>
        /// Convert method should receive 40 and convert it from feet to meters. It should return a double.
        /// </summary>
        [TestMethod]
        public void Convert_40feet_to_meters()
        {
            Assert.AreEqual(12.19, converter.Convert(40));
        }

    }
}
