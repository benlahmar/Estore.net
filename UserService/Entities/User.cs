using System.Text.Json.Serialization;

namespace UserService.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

       public ICollection<Role> Roles { get; set; }
    }
}
