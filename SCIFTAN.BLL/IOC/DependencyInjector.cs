using SCIFTAN.DAL.IRepository;
using SCIFTAN.DAL.Repository;
using Microsoft.Practices.Unity;

namespace SCIFTAN.BLL.IOC
{
    public partial class DependencyInjector
    {
        public static void Inject(UnityContainer container)
        {
            container.RegisterType<IFreelancerPersonalInfoRepository, FrelancerPersonalInfoRepository>();
        }
    }
}
