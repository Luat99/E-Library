using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class DeThiKiemTra
    {
        [Key]
        public int ID_DeThiKiemTra { get; set; }
        public string NAME_DeThiKiemTra { get; set; } = string.Empty;
        public string DESCRIPTION_DeThiKiemTra { get; set; } = string.Empty;
    }
}
