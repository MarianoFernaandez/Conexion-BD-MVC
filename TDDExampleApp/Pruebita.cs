using Xunit.Sdk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDExampleApp
{
    [TestClass]
    public class Pruebita
    {
        [TestMethod]

        public void TestMethod1()
        {
            // Create an instance to test:
            Rooter rooter = new Rooter();
            // Define a test input and output vlue:
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            //Run the method under test:
            double actualResult = rooter.SquareRoot(input);
            // Verify the result
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }
    }

    public class Rooter
    {
        internal double SquareRoot(double input)
        {
            throw new NotImplementedException();
        }
    }
}
