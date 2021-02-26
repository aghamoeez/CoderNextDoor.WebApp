using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoderNextDoor.Data
{
    public class User : IdentityUser<int>
    {
        public User()
        {
            CreatedOn = DateTimeOffset.UtcNow;
        }

        public DateTimeOffset CreatedOn { get; set; }

        [StringLength(maximumLength: 256)]
        public string DisplayName { get; set; }

        public string AvatarUrl { get; set; }
    }
}