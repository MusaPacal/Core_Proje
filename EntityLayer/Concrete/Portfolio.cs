using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioImgUrl { get; set; }
        public string PortfolioBigImgUrl { get; set; }
        public string PortfolioLink { get; set; }
        public string PortfolioIcon { get; set; }
        public string PortfolioProjectLanguage{ get; set; }
        public string PortfolioDate { get; set; }
        public string PortfolioValue { get; set; }
    }
}
