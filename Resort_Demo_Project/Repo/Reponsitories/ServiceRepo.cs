using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class ServiceRepo : IServiceRepo
	{
		private readonly IServiceRepo _serviceRepo;
		public ServiceRepo(IServiceRepo serviceRepo)
		{
			_serviceRepo = serviceRepo;
		}
	}
}
