using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class dsmongiangday
    {
        [Key]
        public int id_dsmgd { get; set; }
        public string name_dsmgd { get; set; } = string.Empty;
        public string description_dsmh { get; set; } = string.Empty;

    }
}
