using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class DistrictRepo : IDistrictRepo
	{
		private readonly IDistrictRepo _districtRepo;
		public DistrictRepo(IDistrictRepo districtRepo)
		{
			_districtRepo = districtRepo;
		}
	}
}
