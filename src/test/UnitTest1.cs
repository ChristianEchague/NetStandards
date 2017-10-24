using Microsoft.VisualStudio.TestTools.UnitTesting;
using LyricsOnNetStandards;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new LyricsNetStandardsClient();
            var result = client.GetLyric("therollingstones", "satisfaction").Result;
            Assert.IsTrue(result.lyrics.Contains("satisfaction"));
        }
    }
}
