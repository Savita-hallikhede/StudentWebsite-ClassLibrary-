using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity1;
using ServiceContracts;
using ServiceContracts.DTO;
using ServiceContracts.Enum;


namespace Service
{
    public class StdService : IStdService
    {


        //Constructor injection
        private readonly StudentWebsiteDbContext _db;
        public StdService(StudentWebsiteDbContext studentDbContect)
        {
            _db = studentDbContect;
        }

        private StdResponse ConvertStdToStdResponse(Std std)
        {
            // This method is used to convert Std (Entity / DB model)
            // into StdResponse (DTO used to send data to UI or client)

            // Create a new response object
            StdResponse response = new StdResponse();

            // Copy data from database entity to response object
            // We do this because we should NOT return entity directly
            response.StdId = std.StdId;
            response.StdName = std.StdName;
            response.StdDprt = std.StdDprt;
            response.ClgId = std.ClgId;
            response.DOB = std.DOB;
            response.Address = std.Address;

            // Return the response object to service/controller
            return response;
        }
        public StdResponse AddStd(StdAddRequest stdAddRequest)
        {
            // 1. Null check
            if (stdAddRequest == null)
            {
                throw new ArgumentNullException(nameof(stdAddRequest));
            }

            // 2. Convert DTO → Entity
            Std std = stdAddRequest.ToStd();//this is inside the StdAddRequest

            // 3. Generate ID
            std.StdId = Guid.NewGuid();

            // 4. Save to DB
            _db.Stds.Add(std);
            _db.SaveChanges();

            // 5. Return response
            return ConvertStdToStdResponse(std);




            // 2. Property null check
            //if (stdAddRequest.StdName == null)
            //{
            //    throw new ArgumentException();

            //}
            //throw new NotImplementedException();

        }

        public List<StdResponse> GetAllStds()
        {
            List<Std> ALLDATA = _db.Stds.ToList();
            List<StdResponse> ConvertStdToStdResponse = new List<StdResponse>();


            foreach (Std std in ALLDATA)
            {
                StdResponse stdResponse = new StdResponse();
                stdResponse.StdId = std.StdId;
                stdResponse.StdName = std.StdName;
                stdResponse.StdDprt = std.StdDprt;
                stdResponse.ClgId = std.ClgId;
                stdResponse.DOB = std.DOB;
                stdResponse.Address = std.Address;



                ConvertStdToStdResponse.Add(stdResponse);
            }
            return ConvertStdToStdResponse;

        }
        //throw new NotImplementedException();



        public StdResponse UpdateStd(StdUpdateRequest stdUpdateRequest)
        {
            throw new NotImplementedException();
        }


        public bool DeleteStd(Guid stdId)
        {
            throw new NotImplementedException();
        }


        public StdResponse GetStdById(Guid stdId)
        {
            throw new NotImplementedException();
        }

        public List<StdResponse> GetFilteredStds(string Searchby, string searchstring)
        {
            throw new NotImplementedException();
        }

        public List<StdResponse> GetSortedStds(List<StdResponse> StdResponsestring, String sortby, SortOrderOption sortorderoption)
        {
            throw new NotImplementedException();
        }
    }
}
