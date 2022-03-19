namespace ELibrary.Models
{
    public class TeacherRegister
    {
        public string USER_Teacher { get; set; } = string.Empty;
        public byte[] PassHash_Teacher { get; set; } = null!;
        public byte[] PassSalt_Teacher { get; set; } = null!;
    }
}
