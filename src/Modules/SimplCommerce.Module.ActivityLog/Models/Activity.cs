using System;
using System.ComponentModel.DataAnnotations;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.ActivityLog.Models
{
    public class Activity : EntityBase
    {
    
        public long ActivityTypeId { get; set; }

        public ActivityType ActivityType { get; set; }

        public long UserId { get; set; }
        
       [Display(Name = "Created On")]
        public DateTimeOffset CreatedOn { get; set; } //The DateTimeOffset structure includes a DateTime value, together with an Offset property that defines the difference between the current DateTimeOffset instance's date and time and Coordinated Universal Time (UTC). 
        //Because it exactly defines a date and time relative to UTC, the DateTimeOffset structure does not include a Kind member, as the DateTime structure does.

        public long EntityId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string EntityTypeId { get; set; }
    }
}
