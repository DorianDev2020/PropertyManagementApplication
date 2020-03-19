using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Management.Models
{
    public class Contractor
    {
        [Key]
        public int ContractorID { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
