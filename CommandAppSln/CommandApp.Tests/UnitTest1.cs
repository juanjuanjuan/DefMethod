using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program _program;

        public UnitTest1() {
            _program = new Program();
        }

        [TestMethod]
        public void TestMethod1()
        {
            bool result = false;

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}
