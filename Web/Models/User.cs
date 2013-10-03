using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class User
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(32), Required]
        public string Password { get; set; }

        [StringLength(30), Required]
        public string RealName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [StringLength(20), Required]
        public string Tel { get; set; }

        [StringLength(70), Required]
        public string Email { get; set; }

        [Required]
        [ForeignKey("Role")]
        public int RoleId { get; set; } 

        public virtual Role Role { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}