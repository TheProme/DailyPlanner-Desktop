using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyPlanner.DAL.EF.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Login { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
    }
}
