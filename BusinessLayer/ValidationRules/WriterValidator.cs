using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail kısmı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola kısmı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En fazla 2 Karakter giriş yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 Karakter giriş yapın");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
			RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en azı bir büyük harfden ibaret olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en azı bir kücük harfden ibaret olmalıdır.");
			RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en azı bir rakamdan ibaret olmalıdır.");
		}
    }
}
