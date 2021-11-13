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
  public  class Category
    {

        [Key]
        [DisplayName("Category Id")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [StringLength(7995, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in lenght")]
        [Column(TypeName = "nvarchar(max)")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
