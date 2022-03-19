using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class Teacher
    {
        [Key]
        public int ID_Teacher { get; set; }
        public string NAME_Teacher { get; set; } = string.Empty;
    }
}
