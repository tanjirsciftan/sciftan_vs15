using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SCIFTAN.BLL.IService;
using SCIFTAN.BLL.Service;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.DAL.IRepository;
using SCIFTAN.DAL.Repository;
using System.Data.Entity;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SCIFTAN
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            //Repository and Service Registration in Unity for Dependency Injection

            container.RegisterType<DbContext, SciftanDbContext>();
            container.RegisterType<IUserStore<Models.ApplicationUser>, UserStore<Models.ApplicationUser>>();
            container.RegisterType<IFreelancerPersonalInfoRepository, FrelancerPersonalInfoRepository>();
            container.RegisterType<IFreelancerPersonalInfoService, FreelancerPersonalInfoService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}