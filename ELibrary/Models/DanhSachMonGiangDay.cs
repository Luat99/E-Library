using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class DanhSachMonGiangDay
    {
        [Key]
        public int ID_DSMGiangDay { get; set; }
        public string NAME_DSMGiangDay { get; set; } = string.Empty;
        public string DESCRIPTION_DSMGiangDay { get; set; } = string.Empty;
    }
}
