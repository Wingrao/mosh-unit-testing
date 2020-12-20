using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTest.Mocking
{
    [TestFixture]
    internal class VideoServiceTests
    {
        private VideoService _service;
        private Mock<IFileReader> _fileReader;

        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _service = new VideoService();
        }


        [Test]
        public void ReadVideoFile_EmptyFile_ReturnError()
        {
            
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");


            var result = _service.ReadVideoTitle(_fileReader.Object);



            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}