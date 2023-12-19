using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class RateRepo : IRateRepo
	{
		private readonly IRateRepo _rateRepo;
		public RateRepo(IRateRepo rateRepo)
		{
			_rateRepo = rateRepo;
		}
	}
}
