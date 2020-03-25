 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Management.Models
{
    public class Listing
    {
        [Key]
        public int ListingID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public bool Available { get; set; }
        public int SquareFeet { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        [ForeignKey("LandLord")]
        public int LandLordId { get; set; }
        public LandLord LandLord { get; set; }
        public int AdminID { get; set; }
        [ForeignKey("Tennant")]
        public int TennantID { get; set; }
        public Tennant Tennant { get; set; }
    }
}
