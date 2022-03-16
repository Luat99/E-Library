using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class dethikiemtra
    {
        [Key]
        public int id_dtkt { get; set; }
        public string name_dtkt { get; set; } = string.Empty;     
        public string description_dtks { get; set; } = string.Empty;
    }
}
