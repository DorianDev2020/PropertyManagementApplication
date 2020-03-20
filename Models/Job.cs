using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Management.Models
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }
        [ForeignKey("Tennant")]
        public int TennantID { get; set; }
        public Tennant Tennant { get; set; }
        [ForeignKey("Contractor")]
        public int? ContractorID { get; set; }
        public Contractor Contractor { get; set; }
        public string JobDescription { get; set; }
        public string JobStatus { get; set; }
        public string PhotoPath { get; set; }
    }
}
