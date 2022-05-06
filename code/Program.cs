try
{
    var fileName = args[0];
    var textToFind = Functions.GetTextToFind(fileName);
    int counter = Functions.CountOccurencesInFile(textToFind, fileName);
    Console.WriteLine($"Found {counter} occurences of string '{textToFind}' in file '{fileName}'");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}