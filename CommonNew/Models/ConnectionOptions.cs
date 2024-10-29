namespace CommonNew.Models
{
    public class ConnectionOptions
    {
        public string Server { get; set; } = string.Empty;
        public string? Database { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool UseWindowsAuthentication { get; set; }
    }
}
