namespace TestNinja.NunitTests;
using TestNinja.Mocking;

public class FakeFilereader : IFileReader
{
    public string Read(string path) 
    {
        return "";
    }
}
