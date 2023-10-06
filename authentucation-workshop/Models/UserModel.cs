using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace authentucation_workshop.Models
{
    public class UserModel : IdentityUser
    {
        public string Nickname { get; set; }
    }
}
