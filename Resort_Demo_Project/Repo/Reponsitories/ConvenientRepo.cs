using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class ConvenientRepo : IConvenientRepo
	{
		private readonly IConvenientRepo _convenientRepo;
		public ConvenientRepo(IConvenientRepo convenientRepo)
		{
			_convenientRepo = convenientRepo;
		}
	}
}
