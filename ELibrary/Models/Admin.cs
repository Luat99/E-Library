using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class Admin
    {
        [Key]
        public int ID_Admin { get; set; } 
        public string NAME_Admin { get; set; } = string.Empty;
    }
}
