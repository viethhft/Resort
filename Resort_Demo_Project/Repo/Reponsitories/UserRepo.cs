using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class UserRepo : IUserRepo
	{
		private readonly IUserRepo _userRepo;
		public UserRepo(IUserRepo userRepo)
		{
			_userRepo = userRepo;
		}
	}
}
