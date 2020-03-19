using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Management.Models
{
    public class Property_Listing
    {
        [Key]
        public int ListingID { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
