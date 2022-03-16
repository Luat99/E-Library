using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class help
    {
        [Key]
        public int id_help { get; set; }
        public string name_help { get; set; } = string.Empty;
        public string description_help { get; set; } = string.Empty;

    }
}
