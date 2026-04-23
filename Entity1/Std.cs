using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity1
{
    public class Std
    {
        public Guid StdId { get; set; }
        public string StdName { get; set; }
        public string StdDprt { get; set; }

        public Guid ClgId { get; set; }
        public DateTime DOB { get; set; }
        public string? Address { get; set; }
    }
}

