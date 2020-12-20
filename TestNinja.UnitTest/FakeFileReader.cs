using TestNinja.Mocking;

namespace TestNinja.UnitTest
{
    class FakeFileReader: IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
