using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validations.validation.DTO;
namespace validations.validation
{
    public interface IValidationService<TEntity>
        where TEntity : class
    {
        IEnumerable<Validation> getValidations();
    }
}
