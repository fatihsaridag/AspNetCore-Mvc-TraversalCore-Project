using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.DTOs.AnnouncementDTOs;

namespace TraversalCore.Services.ValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(X => X.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(X => X.Title).MinimumLength(5).WithMessage("Başlık alanı 5 karakterden küçük olamaz.");
            RuleFor(X => X.Title).MaximumLength(50).WithMessage("Başlık alanı 50 karakterden küçük olamaz.");

            RuleFor(X => X.Content).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(X => X.Content).MinimumLength(5).WithMessage("İçerik alanı 5 karakterden küçük olamaz.");
            RuleFor(X => X.Content).MaximumLength(50).WithMessage("İçerik alanı 50 karakterden küçük olamaz.");
        }
    }
}
