using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIFTAN.BLL.IService;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;
using AutoMapper;
using SCIFTAN.BLL.Models;

namespace SCIFTAN.BLL.Service
{
    public class FreelancerPersonalInfoService : IFreelancerPersonalInfoService
    {
        private readonly IFreelancerPersonalInfoRepository _iFreelancerPersonalInfoRepository;

        public FreelancerPersonalInfoService(IFreelancerPersonalInfoRepository iFreelancerPersonalInfoRepository)
        {
            _iFreelancerPersonalInfoRepository = iFreelancerPersonalInfoRepository;
        }

        public List<FREELANCER_PERSONAL_INFO_Model> GetAllFreelancerPersonalInfo()
        {
            return Mapper.Map<List<FREELANCER_PERSONAL_INFO>, List<FREELANCER_PERSONAL_INFO_Model>>(_iFreelancerPersonalInfoRepository.GetAll()); 
        }

        public FREELANCER_PERSONAL_INFO_Model GetFreelancerPersonalInfoById(string Id)
        {
            return Mapper.Map <FREELANCER_PERSONAL_INFO,  FREELANCER_PERSONAL_INFO_Model>(_iFreelancerPersonalInfoRepository.GetById(Id));
        }

        public bool InsertFreelancerPersonalInfo(FREELANCER_PERSONAL_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_PERSONAL_INFO_Model, FREELANCER_PERSONAL_INFO>(entity);
                return _iFreelancerPersonalInfoRepository.Insert(data);
            }
            return false;
        }

        public bool DeleteFreelancerPersonalInfo(string freelaner_id)
        {
            return _iFreelancerPersonalInfoRepository.Delete(freelaner_id);
        }

        public bool UpdateFreelancerPersonalInfo(FREELANCER_PERSONAL_INFO_Model entity)
        {
            if (entity != null)
            {
                var data = Mapper.Map<FREELANCER_PERSONAL_INFO_Model, FREELANCER_PERSONAL_INFO>(entity);
                return _iFreelancerPersonalInfoRepository.Update(data); 
                
            }
            return false;
        }
    }
}
