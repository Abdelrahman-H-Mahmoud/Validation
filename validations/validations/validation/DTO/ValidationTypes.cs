using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace validations.validation.DTO
{
    public class ValidationTypes
    {
        public string Type { get; set; }
        public string ErrorMessage { get; set; }
        public int MaxLength { get; set; }
        public int MinLength { get; set; }
    }
}
