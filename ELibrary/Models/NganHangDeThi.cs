using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class NganHangDeThi
    {
        [Key]
        public int ID_NganHangDeThi { get; set; }
        public string NAME_NganHangDeThi { get; set; } = string.Empty;
        public string DESCRIPTION_NganHangDeThi { get; set; } = string.Empty;
    }
}
