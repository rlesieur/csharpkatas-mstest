using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    [TestClass]
    public class HikerTest
    {
        [TestMethod]
        public void Foobar()
        {
            UnicodeFileToHtmlTextConverter converter = new UnicodeFileToHtmlTextConverter("foobar.txt");
            Assert.AreEqual("fixme", converter.GetFilename());
        }
    }
}
