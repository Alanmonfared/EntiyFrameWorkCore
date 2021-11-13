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
   public class Product
    {

        [Key]
        [DisplayName("Product Id")]

        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        [StringLength(7995, MinimumLength = 2, ErrorMessage = "Must be more then 2 characters")]
        [Column(TypeName = "nvarchar(max)")]
        public string Name { get; set; }


        [Required]
        [DisplayName("Product ShortDescription")]
        [StringLength(7995, MinimumLength = 5, ErrorMessage = "Must be more then 5 characters")]
        [Column(TypeName = "nvarchar(max)")]
        public string ShortDescription { get; set; }


        [DisplayName("ProductDetail LongDescription")]
        [StringLength(7995, MinimumLength = 10, ErrorMessage = "Must be more then 10 characters")]
        [Column(TypeName = "nvarchar(max)")]
        public string LongDescription { get; set; }

        
        [DisplayName("Product Img")]
        [StringLength(90020099, MinimumLength = 1, ErrorMessage = "Must be between {1} and {2} character in lenght")]
        [Column(TypeName = "varchar(max)")]
        public string Img { get; set; }

        [Required]
        [DisplayName("Product Price (SEK)")]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Product In Stock")]
        public bool InStock { get; set; } = true;
        
        [Required]
        public int CategoryId { get; set; }

        public virtual Category ProductCategory { get; set; }

    }
}
