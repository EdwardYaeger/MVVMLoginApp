namespace MVVMLoginApp.Models
{
    // In a real app, this would query a database.
    // For this tutorial, we use a simple hardcoded check.
    public class AuthService
    {
        private readonly List<User> _users = new()
        {
            new User
            {
                Username = "admin",
                Password = "password123",
                DisplayName = "Admin User"
            },
            new User
            {
                Username = "student",
                Password = "learn2024",
                DisplayName = "Student User"
            }
        };

        public User? Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(u =>
                u.Username == username &&
                u.Password == password);
        }
    }
}