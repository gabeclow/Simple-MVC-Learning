using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gclowPortal.Models
{
    public class Portal
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string calMin { get; set; }
        public string calMax { get; set; }
        public bool calChecked { get; set; }

        public string FatMin { get; set; }
        public string FatMax { get; set; }
        public bool FatChecked { get; set; }

        public string FiberMin { get; set; }
        public string FiberMax { get; set; }
        public bool FiberChecked { get; set; }

        public string glutenCustomName { get; set; }
        public string glutenTagName { get; set; }
       
    }
}
