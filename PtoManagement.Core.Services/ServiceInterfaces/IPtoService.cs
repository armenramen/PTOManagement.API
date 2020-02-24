using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PtoManagement.Core.Services
{
    public interface IPtoService
    {
        Task<List<GetPtoModel>> GetPtoRequestsAsync();
        Task<List<GetPtoModel>> GetApprovedPtosAsync();
        Task RequestPto(CreatePtoRequest request);

    }
}
