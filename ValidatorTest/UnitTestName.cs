using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    [TestClass]
    public class UnitTestName
    {


        [TestMethod]
        [DataRow("p")]
        [DataRow("pe")]
        [DataRow("peter")]
        public void TestNameAccept(string name)
        {
            //assert
            Assert.IsTrue(Validator.CheckName(name));
        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(" peter")] // starting with a space
        [DataRow("peter8")] 
        [DataRow("peter()")] 
        public void TestNameNotAccept(string name)
        {
            //assert
            Assert.IsFalse(Validator.CheckName(name));
        }

    }
}
