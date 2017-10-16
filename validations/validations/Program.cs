using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validations.Model;
using validations.validation;

namespace validations
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidationService<Student> _validationSerivce = new ValidationService<Student>();
            var lst=_validationSerivce.getValidations();
        }
    }
}
