using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ControlWork.Data;

namespace ControlWork.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext()
            : base("name=Model4")
        {
        }

        public DbSet<DataReg> DataWorks { get; set; }
    }
}
