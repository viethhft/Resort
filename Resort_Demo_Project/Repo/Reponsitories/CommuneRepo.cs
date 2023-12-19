using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class CommuneRepo : ICommuneRepo
	{
		private readonly ICommuneRepo _communeRepo;
		public CommuneRepo(ICommuneRepo communeRepo)
		{
			_communeRepo = communeRepo;
		}
	}
}
