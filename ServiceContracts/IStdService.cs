using ServiceContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceContracts.Enum;

namespace ServiceContracts
{
    public interface IStdService
    {
        StdResponse AddStd(StdAddRequest stdAddRequest);
        List<StdResponse> GetAllStds();
        StdResponse UpdateStd(StdUpdateRequest stdUpdateRequest);
        bool DeleteStd(Guid stdId);

        StdResponse GetStdById(Guid stdId);
        List<StdResponse> GetFilteredStds(string Searchby, string searchstring);
        List<StdResponse> GetSortedStds(List<StdResponse> StdResponsestring, String sortby, SortOrderOption sortorderoption);
    }
}
