using Entity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public class StdAddRequest
    {

        public string StdName { get; set; }
        public string StdDprt { get; set; }

        public Guid ClgId { get; set; }
        public DateTime DOB { get; set; }
        public string? Address { get; set; }



        public Std ToStd()
        {
            return new Std
            {
                StdName = this.StdName,
                StdDprt = this.StdDprt,
                ClgId = this.ClgId,
                DOB = this.DOB,
                Address = this.Address
            };
        }
    }
}
