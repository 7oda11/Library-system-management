using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Models
{
    public class Log
    {
        [Key]
        public int LogId { get; set; }
        [Required]
        public string Action { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; } 
        public DateTime PerformedAt { get; set; } = DateTime.Now;
    }
}
