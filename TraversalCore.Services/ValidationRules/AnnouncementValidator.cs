using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.DTOs.AnnouncementDTOs;

namespace TraversalCore.Services.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik adlı kısım boş geçilmez. ");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("İçerik adlı kısım  5 karakterden küçük olamaz");
            RuleFor(x => x.Content).MaximumLength(50).WithMessage("İçerik adlı kısım 50 karakterden büyük olamaz");


            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık adlı kısım boş geçilmez. ");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık adlı kısım  5 karakterden küçük olamaz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık adlı kısım 50 karakterden büyük olamaz");
        }

    }
}
