using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest
{
    [TestClass]
    public class JenkinsTests
    {
        [TestMethod]
        public void JenkinsTestPassed()
        {
            Assert.IsTrue(1 == 1);
        }
        [TestMethod]
        public void JenkinsTestFailed()
        {
            Assert.IsTrue(1 == 2);
        }
    }
}
