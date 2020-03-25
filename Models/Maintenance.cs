using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Management.Models
{
    public class Maintenance
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Tenant")]
        public int TenantId { get; set; }
        [Display(Name = "Work Order Request")]
        public string WorkOrder { get; set; }
    }
}
