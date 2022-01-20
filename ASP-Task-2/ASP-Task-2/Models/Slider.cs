using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Task_2.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string KeyWord { get; set; }
        public string Desc { get; set; }
        public string RedirectUrl { get; set; }
        public int Order { get; set; }
    }
}
