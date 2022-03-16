namespace ELibrary.Models.feature
{
    public class record_file
    {
        public int id { get; set; }
        public string fileName { get; set; } = string.Empty;
        public string fileFormat { get; set; } = string.Empty;
        public string filePath { get; set; } = string.Empty;
        public string contentType { get; set; } = string.Empty;
        public string altText { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
    }
}
