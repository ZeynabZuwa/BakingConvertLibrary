using BakingConvertLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BakingConvertTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {//Arrange

            Cup = 2.0;

            //Act
            Deciliter expected = 0.83;

            Deciliter actual = (cup);

            //Assert

            Assert.AreEqual(expected.Dl, actual.Dl, 0.01);
        }
    }
}