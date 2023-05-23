using Microsoft.AspNetCore.Identity;

namespace IdentityApi
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public Usuario() : base() { }
    }
}
