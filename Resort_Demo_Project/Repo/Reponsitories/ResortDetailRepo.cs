using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class ResortDetailRepo : IResortDetailRepo
	{
		private readonly IResortDetailRepo _resortDetailRepo;
		public ResortDetailRepo(IResortDetailRepo resortDetailRepo)
		{
			_resortDetailRepo = resortDetailRepo;
		}
	}
}
