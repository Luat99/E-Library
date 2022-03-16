using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class baigiang
    {  
        [Key]
        public int id_bg { get; set; }
        public string name_bg { get; set; } = string.Empty;
        public string description_bg { get; set; } = string.Empty;
    }
}
