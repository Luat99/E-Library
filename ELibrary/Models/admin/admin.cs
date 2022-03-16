using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.admin
{
    public class admin
    {
        [Key]
        public int id_admin { get; set; }
        public string name_admin { get; set; } = string.Empty;
       
    }
}
