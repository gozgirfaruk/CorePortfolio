using FluentValidation;
using Portfolio.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Business.ValitadionRules
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez").MinimumLength(4).WithMessage("Proje adı minimum 4 karakter olacak şekilde giriniz.").MaximumLength(20).WithMessage("Proje adı maksimum 20 karakter olacak şekilde giriniz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Proje resmi boş geçilemez. Lütfen bir url giriniz.");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje yolu boş geçilemez. Lütfen bir url giriniz.");
        }
    }
}
