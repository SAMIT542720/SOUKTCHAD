using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SOUKTCHAD.Models
{
    public class AppUser: IdentityUser
    {
        [Display(Name = "الاسم الكامل")]
        public string? FullNmae { get; set; }
    }
}
