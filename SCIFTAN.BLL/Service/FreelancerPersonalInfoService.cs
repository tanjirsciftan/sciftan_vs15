using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIFTAN.BLL.IService;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;

namespace SCIFTAN.BLL.Service
{
    public class FreelancerPersonalInfoService : IFreelancerPersonalInfoService
    {
        private readonly IFreelancerPersonalInfoRepository _iFreelancerPersonalInfoRepository;

        public FreelancerPersonalInfoService(IFreelancerPersonalInfoRepository iFreelancerPersonalInfoRepository)
        {
            _iFreelancerPersonalInfoRepository = iFreelancerPersonalInfoRepository;
        }

        public IList<FREELANCER_PERSONAL_INFO> GetAllFreelancerPersonalInfo()
        {
            return _iFreelancerPersonalInfoRepository.GetAll();
        }

        public FREELANCER_PERSONAL_INFO GetFreelancerPersonalInfoById(string Id)
        {
            return _iFreelancerPersonalInfoRepository.GetById(Id);
        }

        public bool InsertFreelancerPersonalInfo(FREELANCER_PERSONAL_INFO entity)
        {
            return _iFreelancerPersonalInfoRepository.Insert(entity);
        }

        public bool DeleteFreelancerPersonalInfo(string freelaner_id)
        {
            return _iFreelancerPersonalInfoRepository.Delete(freelaner_id);
        }

        public bool UpdateFreelancerPersonalInfo(FREELANCER_PERSONAL_INFO entity)
        {
            if (entity != null)
            {
                return _iFreelancerPersonalInfoRepository.Update(entity); 
                
            }
            return false;
        }
    }
}
