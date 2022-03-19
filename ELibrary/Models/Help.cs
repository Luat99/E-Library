using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class Help
    {
        [Key]
        public int ID_Help { get; set; }
        public string NAME_Help { get; set; } = string.Empty;
        public string DESCRIPTION_Help { get; set; } = string.Empty;
    }
}
