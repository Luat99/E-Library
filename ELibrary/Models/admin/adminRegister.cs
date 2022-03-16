namespace ELibrary.Models.admin
{
    public class adminRegister
    {
        public string user_admin { get; set; } = string.Empty;
        public byte PassHash_admin { get; set; }
        public byte passSalt_admin { get; set; }
    }
}
