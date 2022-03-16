using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class data_file
    {
        [Key]
        public int id_file { get; set; }
        public string name_file { get; set; } = string.Empty;
        public string Extension_file { get; set; } = string.Empty;
        public string MimeType { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
    }
}
