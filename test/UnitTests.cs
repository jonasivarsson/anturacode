using NUnit.Framework;
using System.IO;

namespace test;

public class Tests
{
    [Test]
    public void TestGetTextToFindFromFileName()
    {
        string textToFind = Functions.GetTextToFind("textfile.txt");
        Assert.AreEqual("textfile", textToFind);
    }

    [Test]
    public void TestOccurencesInString()
    {
        int count = Functions.CountOccurencesInText("the", "their green apple is on the blue table");
        Assert.AreEqual(2, count);
    }

    [Test]
    public void TestOccurencesInFile()
    {
        int count = Functions.CountOccurencesInFile("myfile", "../../../../myfile.txt");
        Assert.AreEqual(33, count);
    }
    
    [Test]
    public void TestOverlappingString()
    {
        int count = Functions.CountOccurencesInText("aa", "aaa");
        Assert.AreEqual(2, count);
    }

    [Test]
    public void TestIllegalFileNameWithoutDot()
    {
        Assert.Throws<System.ArgumentException>(() =>
            {string textToFind = Functions.GetTextToFind("illegalfilename");}
        );
    }

    [Test]
    public void TestNonExistingFileName()
    {
        Assert.Throws<FileNotFoundException>(() =>
            {int count = Functions.CountOccurencesInFile("myfile", "nonexistingfile.txt");}
        );
    }

}