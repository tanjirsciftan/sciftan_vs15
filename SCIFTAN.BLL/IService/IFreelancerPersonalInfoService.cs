using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIFTAN.DAL.DB.EF;

namespace SCIFTAN.BLL.IService
{
    public interface IFreelancerPersonalInfoService
    {
        IList<FREELANCER_PERSONAL_INFO> GetAllFreelancerPersonalInfo();
        FREELANCER_PERSONAL_INFO GetFreelancerPersonalInfoById(string Id);
        bool InsertFreelancerPersonalInfo(FREELANCER_PERSONAL_INFO entity);
        bool DeleteFreelancerPersonalInfo(string freelaner_id);
        bool UpdateFreelancerPersonalInfo(FREELANCER_PERSONAL_INFO entity);
    }
}
