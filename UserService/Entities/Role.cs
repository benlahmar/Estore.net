using System.Text.Json.Serialization;

namespace UserService.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        ICollection<User> Users { get; set; }
    }
}
