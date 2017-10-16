using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validations.Model
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50,ErrorMessage ="Min Length is 2 and Max Length is 50",MinimumLength =2)]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
    }
}
