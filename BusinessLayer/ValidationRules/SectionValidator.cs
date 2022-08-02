using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SectionValidator : AbstractValidator<Section>
    {   public SectionValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş geçilemez");
            RuleFor(x => x.Number).NotEmpty().WithMessage("numara alanı boş geçilemez");
            RuleFor(x => x.NumberOfTable).NotEmpty().WithMessage("masa sayısı alanı boş geçilemez");
            RuleFor(x => x.BranchId).NotEmpty().WithMessage("branch id alanı boş geçilemez");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("user id alanı boş geçilemez");
        }
    }
}
