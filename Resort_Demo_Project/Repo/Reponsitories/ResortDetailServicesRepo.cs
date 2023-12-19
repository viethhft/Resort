using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class ResortDetailServicesRepo : IResortDetailServicesRepo
	{
		private readonly IResortDetailServicesRepo _resortDetailServicesRepo;
		public ResortDetailServicesRepo(IResortDetailServicesRepo resortDetailServicesRepo)
		{
			_resortDetailServicesRepo = resortDetailServicesRepo;
		}
	}
}
