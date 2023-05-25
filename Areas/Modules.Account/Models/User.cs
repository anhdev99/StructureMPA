using Modules.Shared.Models;
namespace Modules.Account.Models
{
    public class User : Audit, TEntity<string>
    {
        public string UserName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsBlock { get; set; }
        public bool IsActived { get; set; }
        
        public string PIN { get; set; }
    }
}