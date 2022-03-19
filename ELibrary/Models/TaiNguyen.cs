using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class TaiNguyen
    {
        [Key]
        public int ID_TaiNguyen { get; set; }
        public string NAME_TaiNguyen { get; set; } = string.Empty;
        public string DESCRIPTION_TaiNguyen { get; set; } = string.Empty;
    }
}
