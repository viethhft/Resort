using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class ConvenientResortRepo : IConvenientResortRepo
	{
		private readonly IConvenientResortRepo _convenientResortRepo;
		public ConvenientResortRepo(IConvenientResortRepo convenientResortRepo)
		{
			_convenientResortRepo = convenientResortRepo;
		}
	}
}
