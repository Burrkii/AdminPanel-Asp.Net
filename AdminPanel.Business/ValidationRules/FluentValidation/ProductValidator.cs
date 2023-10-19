using AdminPanel.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("ProductName Cannot be empty");
            RuleFor(p => p.ProductName).Length(2, max: 30);
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("CategoryId Cannot be empty");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("UnitPrice Cannot be empty");
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("RoleId Cannot be empty");
            
        }
    }
}
