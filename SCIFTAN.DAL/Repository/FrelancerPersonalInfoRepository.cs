using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;

namespace SCIFTAN.DAL.Repository
{
    public class FrelancerPersonalInfoRepository : IFreelancerPersonalInfoRepository
    {
        private SciftanDbContext db = new SciftanDbContext();
        public IList<FREELANCER_PERSONAL_INFO> GetAll()
        {
            return db.FREELANCER_PERSONAL_INFO.ToList();
        }

        public FREELANCER_PERSONAL_INFO GetById(string Id)
        {
            return db.FREELANCER_PERSONAL_INFO.Where(x => x.Freelancer_Id == Id).SingleOrDefault();
        }

        public bool Insert(FREELANCER_PERSONAL_INFO entity)
        {
            try
            {
                db.FREELANCER_PERSONAL_INFO.Add(entity);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        public bool Delete(string freelaner_id)
        {
            FREELANCER_PERSONAL_INFO entity = GetById(freelaner_id);
            if (entity != null)
            {
                db.FREELANCER_PERSONAL_INFO.Remove(entity);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Update(FREELANCER_PERSONAL_INFO entity)
        {

            db.Entry(entity).State = EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }
    }
}
