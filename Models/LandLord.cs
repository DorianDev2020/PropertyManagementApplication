﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Management.Models
{
    public class LandLord
    {
        [Key]
        public int AdminID { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public string EmailAddress { get; set; }

    }
}
