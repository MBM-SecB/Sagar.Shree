using System;
using System.IO;

public class FileIoHw
{



    public void FileIoAssignment()
    {
        string rootFolderPath = "Nepal";
        string[] subFolderNames = { "Dang", "Salyan", "Rolpa", "Rukum", "Pyuthan", "Kathmandu", "Kaski", "Lalitpur", "Bhaktapur", "Dhading" };
        Directory.CreateDirectory(rootFolderPath);

        foreach (string subfolderName in subFolderNames)
        {
            Directory.CreateDirectory($"{rootFolderPath}/{subfolderName}");
            string filePath = $"{rootFolderPath}/{subfolderName}/Text.txt";
            string fileContent = subfolderName;
            File.WriteAllText(filePath, fileContent);

        }
    }
}