using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validations.validation.DTO;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace validations.validation
{
    public class ValidationService<TEntity> : IValidationService<TEntity>
        where TEntity : class
    {
        public IEnumerable<Validation> getValidations()
        {
            var Validations = new List<Validation>();
            var Properties = typeof(TEntity).GetProperties();
            foreach (var prop in Properties)
            {
                var attributes = prop.GetCustomAttributes(typeof(ValidationAttribute), true) as IEnumerable<ValidationAttribute>;
                if (attributes != null)
                {
                    var v = new Validation() { Name = prop.Name, ValidationTypes = new List<ValidationTypes>() };
                    foreach (var attr in attributes)
                    {
                        if(attr is RequiredAttribute)
                        {
                            v.ValidationTypes.Add(new ValidationTypes()
                            {
                                Type = "Required",
                                ErrorMessage = $"{prop.Name} is Required"

                            });
                        }
                        else if(attr is StringLengthAttribute)
                        {
                            var SL = attr as StringLengthAttribute;
                            v.ValidationTypes.Add(new ValidationTypes()
                            {
                                Type = "StringLength",
                                ErrorMessage = SL.ErrorMessage,
                                MaxLength = SL.MaximumLength,
                                MinLength=SL.MinimumLength
                            });
                        }
                    }
                    Validations.Add(v);
                }
            }
            return Validations;
        }
    }
}
