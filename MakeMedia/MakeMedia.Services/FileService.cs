using System.IO;

/// <summary>
/// 
/// </summary>
namespace MakeMedia.Services
{
    public class FileService : IFileService
    {
        // can be moved into configuration
        private string filePath = @"C:\Madhu\";
        public bool SaveFile(string fileName, string content)
        {
            using (StreamWriter file =
            new System.IO.StreamWriter(Path.Combine(filePath, fileName), true))
            {
                file.Write(content);
            }
            return true;
        }

        public string ReadFile(string fileName)
        {
            string fileContent = string.Empty;
            using (StreamReader file =
                new StreamReader(Path.Combine(filePath, fileName)))
            {
                fileContent = file.ReadToEnd();
            }
            return fileContent;
        }
    }
}
