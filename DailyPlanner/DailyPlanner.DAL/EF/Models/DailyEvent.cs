using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyPlanner.DAL.EF.Models
{
    public class DailyEvent 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        [StringLength(200)]
        public string? Description { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User? User { get; set; }
    }
}
