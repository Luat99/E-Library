namespace ELibrary.Models.teacher
{
    public class teacherRegister
    {
        public string user_teacher { get; set; } = string.Empty;
        public byte passHash { get; set; }
        public byte passSalt { get; set; }
    }
}
