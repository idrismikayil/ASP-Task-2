using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Task_2.Models
{
    public class PortfolioImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
