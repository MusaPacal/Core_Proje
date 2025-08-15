using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.PortfolioName).NotEmpty().WithMessage("Proje Adı boş Olamaz");
            RuleFor(x => x.PortfolioProjectLanguage).NotEmpty().WithMessage("Proje Dili boş Olamaz");
            RuleFor(x => x.PortfolioImgUrl).NotEmpty().WithMessage("Proje Fototğrafları Boş Olamaz");
            RuleFor(x => x.PortfolioBigImgUrl).NotEmpty().WithMessage("Proje Fototğrafları Boş Olamaz");
            RuleFor(x => x.PortfolioLink).NotEmpty().WithMessage("Proje Linki Boş Olamaz");
            RuleFor(x => x.PortfolioIcon).NotEmpty().WithMessage("Proje Dil İkonu Boş Olamaz");
            RuleFor(x => x.PortfolioDate).NotEmpty().WithMessage("Proje Dil İkonu Boş Olamaz");
            RuleFor(x => x.PortfolioValue).NotEmpty().WithMessage("Proje Dil İkonu Boş Olamaz");
            
        }
    }
}
