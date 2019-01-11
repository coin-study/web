using System;
using Microsoft.AspNetCore.Identity;

namespace CoinStudyWeb.EntityModels
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime MemberSince { get; set; }
    }
}