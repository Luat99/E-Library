namespace ELibrary.Models
{
    public class AdminRegister
    {
        public string USER_Admin { get; set; } = string.Empty;
        public byte[] PassHash_Admin { get; set; } = null!;
        public byte[] PassSalt_Admin { get; set; } = null!;
    }
}
