using AutoMapper;
using PtoManagement.Core.Models;
using PtoManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PtoManagementApi
{
    public class PtoProfile : Profile
    {
        public PtoProfile()
        {
            CreateMap<Pto, GetPtoModel>()
                .ForMember(p => p.FiledBy, opt => opt.MapFrom(p => p.Employee))
                .ForMember(p => p.PtoType, opt => opt.MapFrom(src => src.PtoType.PtoTypeName))
                .ForMember(p => p.PtoStatus, opt => opt.MapFrom(src => src.PtoStatus.PtoStatusName));
            CreateMap<CreatePtoRequest, Pto>();
            CreateMap<Employee, GetEmployeeModel>();
        }

    }
}
