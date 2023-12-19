using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class ResortRepo : IResortRepo
	{
		private readonly IResortRepo _resortRepo;
		public ResortRepo(IResortRepo resortRepo)
		{
			_resortRepo = resortRepo;
		}
	}
}
