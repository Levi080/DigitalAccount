
namespace Domain.Entities
{
    public class Customer
    {
        public Customer(string name, string email, string document)
        {
            Name = name;
            Email = email;
            Document = document;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Document { get; set; }
    }
}
