using System.IO;

class FileIO
{
    string folderPath = @"D:\AppSoft\Training\NETSDKandCSharpLangauge\LanguageBasics\NETStarter\Basics\FileFolderHandling";
    
    //Create a text file
    public void CreateFile()
    {        
        string fileName = "student.txt";
        string filePath = Path.Combine(folderPath, fileName);
        
        File.WriteAllText(filePath, "this is first line");
    }

    public void CreateFileWithInFolder()
    {
        string newFolderName = "Student";
        string newFodlerPath = Path.Combine(folderPath, newFolderName);
        Directory.CreateDirectory(newFodlerPath);

        string fileName = "Student1.txt";
        string filePath = Path.Combine(newFodlerPath, fileName);
        
        File.WriteAllText(filePath, "this is first line");
    }
}