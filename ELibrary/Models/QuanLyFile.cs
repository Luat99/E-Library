namespace ELibrary.Models
{
    public class QuanLyFile
    {
        public QuanLyFile(IFormFile myFile)
        {
            MyFile = myFile;
        }
        public IFormFile MyFile { get; set; }
        public string AltText { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
