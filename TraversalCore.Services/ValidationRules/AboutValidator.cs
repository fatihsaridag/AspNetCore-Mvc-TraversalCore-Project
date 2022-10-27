using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Services.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz...!");
            RuleFor(x => x.Description1).MinimumLength(50).WithMessage("Lütfen en az 50 karakterliik açıklama bilgisi giriniz ..");
            RuleFor(x => x.Description1).MaximumLength(1500).WithMessage("Lütfen açıklamayı kısaltın..");
        }
    }
}
