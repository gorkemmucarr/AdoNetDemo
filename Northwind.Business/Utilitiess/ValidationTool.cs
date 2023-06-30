using FluentValidation;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Enitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilitiess
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {  
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
