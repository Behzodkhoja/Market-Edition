using Market.Domain.Commons;

namespace Market.Domain.Entities
{
    public class User : Auditable
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
