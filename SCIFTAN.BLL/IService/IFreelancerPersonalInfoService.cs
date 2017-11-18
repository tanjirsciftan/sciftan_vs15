using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.BLL.Models;

namespace SCIFTAN.BLL.IService
{
    public interface IFreelancerPersonalInfoService
    {
        List<FREELANCER_PERSONAL_INFO_Model> GetAllFreelancerPersonalInfo();
        FREELANCER_PERSONAL_INFO_Model GetFreelancerPersonalInfoById(string Id);
        bool InsertFreelancerPersonalInfo(FREELANCER_PERSONAL_INFO_Model entity);
        bool DeleteFreelancerPersonalInfo(string freelaner_id);
        bool UpdateFreelancerPersonalInfo(FREELANCER_PERSONAL_INFO_Model entity);
    }
}
