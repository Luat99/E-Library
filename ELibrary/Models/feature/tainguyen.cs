using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class tainguyen
    {
        [Key]
        public int id_tn { get; set; }
        public string name_tn { get; set; } = string.Empty;
        public string description_tn { get; set; } = string.Empty;

    }
}
