using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIFTAN.DAL.DB.EF;

namespace SCIFTAN.DAL.IRepository
{
    public interface IFreelancerPersonalInfoRepository
    {
        IList<FREELANCER_PERSONAL_INFO> GetAll();
        FREELANCER_PERSONAL_INFO GetById(string Id);
        bool Insert(FREELANCER_PERSONAL_INFO entity);
        bool Delete(string freelaner_id);
        bool Update(FREELANCER_PERSONAL_INFO entity);

    }
}
