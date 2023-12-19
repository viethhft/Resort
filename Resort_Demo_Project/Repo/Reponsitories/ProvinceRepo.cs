using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class ProvinceRepo : IProvinceRepo
	{
		private readonly IProvinceRepo _provinceRepo;
		public ProvinceRepo(IProvinceRepo provinceRepo)
		{
			_provinceRepo = provinceRepo;
		}
	}
}
