using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace tuseTheProgrammer.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender is mandatory!")]
        [Column(TypeName = "nvarchar(20)")]
        public Sex Sex { get; set; }
    }
}
