using Microsoft.AspNetCore.Identity;

namespace AAAManagement.Models
{
    public class PersonIdentity : IdentityUser
    {
        public string MobileNumber { get; set; }
        public string NationalCode { get; set; }
    }
}
