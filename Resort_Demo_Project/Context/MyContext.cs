using Microsoft.EntityFrameworkCore;
using Resort_Demo_Project.Models;

namespace Resort_Demo_Project.Context
{
	public class MyContext:DbContext
	{
		public MyContext(DbContextOptions options):base(options)
		{

		}
		DbSet<User> Users { get; set; }
		DbSet<UserDetail> UserDetails { get; set; }
		DbSet<Role> Roles { get; set; }
		DbSet<Resort> Resorts { get; set; }
		DbSet<ResortDetail> ResortDetails { get; set; }
		DbSet<ResortDetailServices> ResortDetailServices { get; set; }
		DbSet<Rate> Rates { get; set; }
		DbSet<Province> Provinces { get; set; }
		DbSet<District> Districts { get; set; }
		DbSet<Commune> Communes { get; set; }
		DbSet<Service> Services { get; set; }
		DbSet<Convenient> Convenients { get; set; }
		DbSet<ConvenientResort> ConvenientResorts { get; set; }
		DbSet<TypeRoom> TypeRooms { get; set; }
		DbSet<TypeRoomResortDetail> TypeRoomResortDetails { get; set; }
	}
}
