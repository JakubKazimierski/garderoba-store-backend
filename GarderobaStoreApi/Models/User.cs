using System.ComponentModel.DataAnnotations;

namespace GarderobaStoreApi.Models
{
    public enum UserType { MANAGER, CONSUMER }
    public class User
    {
        
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType Rights { get; set; }
    }
}