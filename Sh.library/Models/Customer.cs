using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sh.library.Models
{
   public class Customer
    {



        [Key]
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Customer FirstName")]
        [StringLength(7995, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in lenght")]
        [Column(TypeName = "nvarchar(max)")]
        public string FirstName { get; set; }


        [Required]
        [DisplayName("Customer LastName")]
        [StringLength(7995, MinimumLength = 5, ErrorMessage = "Must be between {1} and {2} character in lenght")]
        [Column(TypeName = "nvarchar(max)")]
        public string LastName { get; set; }



        [Required]
        [DisplayName("Customer Email")]
        [StringLength(7995, MinimumLength = 5, ErrorMessage = "Must be ")]
        [Column(TypeName = "nvarchar(max)")]
        public string Email { get; set; }

        
        
    }
}
