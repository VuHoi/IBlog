using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.models
{
    public class User: IdentityUser
    {
       
        [StringLength(100)]
        public string District { get; set; }
        [StringLength(100)]
        public string Ward { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        
        
    }
}
