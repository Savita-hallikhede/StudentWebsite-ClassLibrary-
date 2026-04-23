using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContracts;
using ServiceContracts.DTO;
using Entity1;

namespace Service
{
    public class ClgService : IClgService
    {
        // created a constructor to inject the dbcontext class object into the service class

        private readonly StudentWebsiteDbContext _db;
        public ClgService(StudentWebsiteDbContext studentDbContex)
        {
            _db = studentDbContex;

        }


        public ClgResponse AddClg(ClgAddRequest clgAddRequest)
        {
            throw new NotImplementedException();
        }


        public List<ClgResponse> GetAllClgs()
        {
            List<Clg> ALLDATA = _db.Clgs.ToList();
            List<ClgResponse> Storing_clg_listOfData = new List<ClgResponse>();
            foreach (Clg clg in ALLDATA)
            {
                ClgResponse clgResponse = new ClgResponse()
                {
                    ClgId = clg.ClgId,
                    ClgName = clg.ClgName
                };
                Storing_clg_listOfData.Add(clgResponse);
            }
            return Storing_clg_listOfData;

            //throw new NotImplementedException();
        }
        public ClgResponse GetClgById(Guid clgId)
        {
            throw new NotImplementedException();
        }

    }
}
