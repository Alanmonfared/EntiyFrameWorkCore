using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sh.library.Models
{
  public  class CreateProduct
    {

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Img { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ShortDescription { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string LongDescription { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public int Price { get; set; }

       
        

    }
}
