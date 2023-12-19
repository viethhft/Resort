using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class TypeRoomRepo : ITypeRoomRepo
	{
		private readonly ITypeRoomRepo _typeRoomRepo;
		public TypeRoomRepo(ITypeRoomRepo typeRoomRepo)
		{
			_typeRoomRepo = typeRoomRepo;
		}
	}
}
