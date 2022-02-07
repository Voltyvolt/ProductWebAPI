using System.ComponentModel.DataAnnotations;

namespace Webapp
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
