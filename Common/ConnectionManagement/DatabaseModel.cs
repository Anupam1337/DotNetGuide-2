namespace Common.ConnectionManagement
{
    public class DatabaseModel : IDatabaseModel
    {
        public string GetConnectionString()
        {
            // Return default connection string
            return "Your-Connection-String";
        }
    }
}
