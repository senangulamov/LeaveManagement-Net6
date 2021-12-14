using AutoMapper;
using LeaveManagementV2.Web.Data;
using LeaveManagementV2.Web.Models;

namespace LeaveManagementV2.Web.configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            //CreateMap<LeaveType, LeaveTypeVM>();
            //CreateMap<LeaveTypeVM, LeaveType>();
            
            CreateMap<LeaveTypeVM, LeaveType>().ReverseMap();
        }
    }
}
