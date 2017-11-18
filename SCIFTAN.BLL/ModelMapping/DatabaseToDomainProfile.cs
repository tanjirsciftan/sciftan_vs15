using AutoMapper;
using SCIFTAN.BLL.Models;
using SCIFTAN.DAL.DB.EF;

namespace SCIFTAN.BLL.ModelMapping
{
    public partial class DatabaseToDomainProfile : Profile
    {
        protected override void Configure()
        {            
            CreateMap<FREELANCER_PERSONAL_INFO, FREELANCER_PERSONAL_INFO_Model>();
        }
    }
}

