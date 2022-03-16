namespace ELibrary.Models.feature
{
    public class fileManagement
    {
        public fileManagement(IFormFile myFile)
        {
            MyFile = myFile;
        }

        public IFormFile MyFile { get; set; }
        public string AltText { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
