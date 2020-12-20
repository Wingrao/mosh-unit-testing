using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTest.Mocking
{
    [TestFixture]
    class VideoServiceTests
    {
        [Test]
        public void ReadVideoFile_EmptyFile_ReturnError()
        {
            var service = new VideoService();

            var result = service.ReadVideoTitle(new FakeFileReader());

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
