namespace ELibrary.Models
{
    public class LuuFile
    {
        public int ID { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FileFormat { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public string AltText { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
