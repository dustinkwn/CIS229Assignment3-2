namespace IdentityApi.Models
{
    public class Identity
    {
        public bool Active { get; set; }
        public string Term { get; set; }
        public string Group { get; set; }
        public string Role { get; set; }

        public ProfileInfo Profile { get; set; }
        public List<string> Permissions { get; set; }
    }

    public class ProfileInfo
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string StudentId { get; set; }
    }
}
