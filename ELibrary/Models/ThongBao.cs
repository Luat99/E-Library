using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class ThongBao
    {
        [Key]
        public int ID_ThongBao { get; set; }
        public string NAME_ThongBao { get; set; } = string.Empty;
        public string DESCRIPTION_ThongBao { get; set; } = string.Empty;
    }
}
