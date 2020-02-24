using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PtoManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtoManagement.Core.Services
{
    public class PtoService : IPtoService
    {
        private IPtoManagementDbContext _context;
        private IMapper _mapper;

        public PtoService(IPtoManagementDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }


        public async Task<List<GetPtoModel>> GetPtoRequestsAsync()
        {
            var ptos = await _context.Ptos
                         .Include(p => p.Employee)
                         .Include(p => p.PtoStatus)
                         .Include(p => p.PtoType)
                         .Where(p => p.PtoStatusId == (int)PtoStatusEnum.ForApproval)
                         .ToListAsync();

            return _mapper.Map<List<GetPtoModel>>(ptos);

        }
        public async Task<List<GetPtoModel>> GetApprovedPtosAsync()
        {
            var approvedPtos = await _context.Ptos
                                    .Include(p => p.Employee)
                                    .Where(p => p.PtoStatusId == (int)PtoStatusEnum.Approved)
                                    .ToListAsync();

            //return _mapper.Map<List<GetPtoModel>>(approvedPtos);
            return null;

        }

        public async Task RequestPto(CreatePtoRequest request)
        {
            //var ptoRequest = _mapper.Map<Pto>(request);
            //ptoRequest.PtoStatusId = (int)PtoStatusEnum.ForApproval;
            //ptoRequest.DateFiled = DateTime.Today;

            //try
            //{
            //    await _context.Ptos.AddAsync(ptoRequest);
            //    _context.SaveChanges();
            //}
            //catch (Exception e)
            //{
            //    throw;
            //}


        }
    }
}
