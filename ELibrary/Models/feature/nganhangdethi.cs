using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class nganhangdethi
    {
        [Key]
        public int id_nhdt { get; set; }
        public string name_nhdt { get; set; } = string.Empty;
        public string description_nhdt { get; set; } = string.Empty;

    }
}
