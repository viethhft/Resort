using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class UserDetailRepo : IUserDetailRepo
	{
		private readonly IUserDetailRepo _userDetailRepo;
		public UserDetailRepo(IUserDetailRepo userDetailRepo)
		{
			_userDetailRepo = userDetailRepo;
		}
	}
}
