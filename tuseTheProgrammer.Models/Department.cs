using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace tuseTheProgrammer.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Occupation is mandatory!")]
        [Column(TypeName ="nvarchar(20)")]
        public Dept? Dept { get; set; }
    }
}
