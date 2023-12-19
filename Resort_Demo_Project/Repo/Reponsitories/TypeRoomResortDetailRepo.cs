using Resort_Demo_Project.Repo.IReponsitories;

namespace Resort_Demo_Project.Repo.Reponsitories
{
	public class TypeRoomResortDetailRepo : ITypeRoomResortDetailRepo
	{
		private readonly ITypeRoomResortDetailRepo _typeRoomResortDetailRepo;
		public TypeRoomResortDetailRepo(ITypeRoomResortDetailRepo typeRoomResortDetailRepo)
		{
			_typeRoomResortDetailRepo = typeRoomResortDetailRepo;
		}
	}
}
