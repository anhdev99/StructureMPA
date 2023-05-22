namespace Modules.Account
{
    public class Account
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public Account() { }

        public Account(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public void ShowUser()
        {
            Console.WriteLine($"UserName: {UserName} - Password: {Password}");
        }
        public void ShowUserTemp()
        {
            Console.WriteLine($"UserName Temp: {UserName} - Password Temp: {Password}");
        }
    }
}