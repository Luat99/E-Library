using System.ComponentModel.DataAnnotations;
namespace ELibrary.Models
{
    public class BaiGiang
    {
        [Key]
        public int ID_BaiGiang { get; set; }
        public string NAME_BaiGiang { get; set; } = string.Empty;
        public string DESCRIPTION_BaiGiang { get; set; } = string.Empty;
    }
}
