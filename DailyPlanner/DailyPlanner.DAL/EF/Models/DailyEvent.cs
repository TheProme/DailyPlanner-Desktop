using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner.DAL.EF.Models
{
    public class DailyEvent 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public string Description { get; set; }
    }
}
