using System.ComponentModel.DataAnnotations;

namespace ELibrary.Models.teacher
{
    public class teacher
    {
        [Key]
        public int id_teacher { get; set; }
        public string name_teacher { get; set; }=string.Empty;

    }
}
