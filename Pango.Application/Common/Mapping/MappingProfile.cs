using AutoMapper;
using Pango.Domain.Entities;
using Pango.Domain.Models;

namespace Pango.Application.Common.Mapping;

public partial class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CustomerModel, Customer>();
        CreateMap<ParkingRecordModel, ParkingRecord>();
    }
}
