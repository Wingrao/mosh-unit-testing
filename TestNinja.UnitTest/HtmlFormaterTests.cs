using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    class HtmlFormaterTests
    {
        [Test]
        public void FormatAsBold_WhenCalledShouldEncloseStringWithBaldElement()
        {
            var formater = new HtmlFormatter();

            var result = formater.FormatAsBold("abc");

            Assert.That(result,Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

        }
    }
}
