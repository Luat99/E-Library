using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class TaiLieuMonHoc
    {
        [Key]
        public int ID_TaiLieuMonHoc { get; set; }
        public string NAME_TaiLieuMonHoc { get; set; } = string.Empty;
        public string DESCRIPTION_TaiLieuMonHoc { get; set; } = string.Empty;

    }
}
