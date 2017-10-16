using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validations.validation.DTO
{
    public class Validation
    {
        public string Name { get; set; }
        public List<ValidationTypes> ValidationTypes { get; set; }
    }
}
