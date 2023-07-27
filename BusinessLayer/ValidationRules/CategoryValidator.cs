using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator :AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz...");
            RuleFor(x => x.CatergoryDescritption).NotEmpty().WithMessage("Kategori açıklaması boş geçemezsiniz...");
            RuleFor(x => x.CatergoryDescritption).MaximumLength(50).WithMessage("Kategori adı 50 karakter olması gerekmektedir...");
            RuleFor(x => x.CatergoryDescritption).MinimumLength(2).WithMessage("Kategori adı 2 karakter olması gerekmektedir...");
        }
    }
}
