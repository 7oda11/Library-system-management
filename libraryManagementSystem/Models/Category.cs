using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryManagementSystem.Models
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)] 
        public string Name { get; set; }= string.Empty;
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
