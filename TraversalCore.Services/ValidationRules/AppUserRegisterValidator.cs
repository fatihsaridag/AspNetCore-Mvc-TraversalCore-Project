using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.DTOs.AppUserDTOs;

namespace TraversalCore.Services.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {

        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Ad alanı 5 karakterden küçük olamaz");
            RuleFor(x => x.Name).MaximumLength(10).WithMessage("Ad alanı 10 karakterden büyük olamaz");


            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Surname).MinimumLength(5).WithMessage("Soyad alanı 5 karakterden küçük olamaz");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Soyad alanı 20 karakterden büyük olamaz");



            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı Adı alanı 5 karakterden küçük olamaz");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Kullanıcı Adı alanı 20 karakterden büyük olamaz");


            RuleFor(x => x.Mail).NotEmpty().WithMessage("E-Mail alanı boş geçilemez");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("E-Mail alanı 5 karakterden küçük olamaz");
            RuleFor(x => x.Mail).MaximumLength(20).WithMessage("E-Mail  alanı 20 karakterden büyük olamaz");


            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor.");

            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrarı alanı boş geçilemez");






        }
    }
}
