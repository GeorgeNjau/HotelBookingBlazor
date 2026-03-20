using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingBlazor.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(25), RegularExpression(@"^[a-zA-Z]+$")]
        public required string FirstName { get; set; }

        [MaxLength(25)]
        public string? LastName { get; set; }

        public string? RoleName { get; set; }
    }

}
