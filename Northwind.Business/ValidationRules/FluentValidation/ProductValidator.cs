using FluentValidation;
using Northwind.Enitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("ProductName Cant Be Empty");
           
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("CategoryId Cant Be Empty");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("UnitPrice Cant Be Empty");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("UnitsInStock Cant Be Empty");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("QuantityPerUnit Cant Be Empty");

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);

            RuleFor(p => p.ProductName).Must(StartsWithA);

        }

        private bool StartsWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
