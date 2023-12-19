using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class RoleRepo : IRoleRepo
	{
		private readonly IRoleRepo _roleRepo;
		public RoleRepo(IRoleRepo roleRepo)
		{
			_roleRepo = roleRepo;
		}
	}
}
