using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class DFile
    {
        [Key]
        public int ID_File { get; set; }
        public string NAME_File { get; set; } = string.Empty;
        public string Extension_File { get; set; } = string.Empty;
        public string MimeType { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
    }
}
