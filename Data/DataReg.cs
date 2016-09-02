using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork.Data
{
    public class DataReg
    {
        public int Id { get; set; }
        public string typeWork { get; set; }
        public string siteWork { get; set; }
        public string zipCode { get; set; }
        public string detailsWork { get; set; }
        public string dateWork { get; set; }
        public string timeStartWork { get; set; }
        public string timeFinishWork { get; set; }
        public string timeWorked { get; set; }
        public decimal earned { get; set; }
        public Boolean paid { get; set; }
    }
}
