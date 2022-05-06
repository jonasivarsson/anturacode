public class Functions
{

public static string GetTextToFind(string fileName)
{
    if (!fileName.Contains('.')) {throw new ArgumentException("fileName");}
    return fileName.Split('.')[0];
}

public static int CountOccurencesInFile(string textToFind, string fileName)
{
    using (var file = File.OpenText(fileName))
    {
        int counter = 0;
        string? line;
        while ((line = file.ReadLine()) != null)
        {
            counter += CountOccurencesInText(textToFind, line);
        }
        return counter;
    }
}

public static int CountOccurencesInText(string textToFind, string content)
{
    int pos = 0;
    int counter = 0;
    while ((pos = content.IndexOf(textToFind, pos)) != -1)
    {
        counter++;
        pos++;
    }
    return counter;
}
}
