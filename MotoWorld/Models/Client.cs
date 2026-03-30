using Microsoft.AspNetCore.Identity;

namespace MotoWorld.Models
{
    public class Client : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisteredOn { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
