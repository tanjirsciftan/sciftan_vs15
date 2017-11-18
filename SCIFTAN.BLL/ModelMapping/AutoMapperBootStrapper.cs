using AutoMapper;

namespace SCIFTAN.BLL.ModelMapping 
{
	public partial class AutoMapperBootStrapper
	{
		public static void Initialize()
        {
            Mapper.AddProfile(new DatabaseToDomainProfile());
            Mapper.AddProfile(new DomainToDatabaseProfile());
        }
	}
}

