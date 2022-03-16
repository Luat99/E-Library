using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.feature
{
    public class thongbao
    {
        [Key]
        public int id_tb { get; set; }
        public string name_tb { get; set; } = string.Empty;
        public string description_tb { get; set; } = string.Empty;
    }
}
