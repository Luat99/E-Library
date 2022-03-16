using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class tailieumonhoc
    {
        [Key]
        public int id_tlmh { get; set; }
        public string name_tlmh { get; set; } = string.Empty;
    }
}
