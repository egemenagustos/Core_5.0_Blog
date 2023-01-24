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
            RuleFor(x => x.WriterNameSurname).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar mail adresi boş geçilemez!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifre alanı boş geçilemez!");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harfden ibaret olmalıdır!");
            RuleFor(x => x.WriterNameSurname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın!");
            RuleFor(x => x.WriterNameSurname).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın!");
        }
    }
}
