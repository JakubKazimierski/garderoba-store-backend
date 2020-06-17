using System.ComponentModel.DataAnnotations;

namespace GarderobaStoreApi.Models
{
    public class User
    {
        public enum UserType { MANAGER, CONSUMER }
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType Rights { get; set; }
    }
}