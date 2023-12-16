using Microsoft.EntityFrameworkCore;
using Resort_Demo_Project.Models;

namespace Resort_Demo_Project.Context
{
	public class MyContext:DbContext
	{
		public MyContext(DbContextOptions options):base(options)
		{

		}
		public DbSet<User> Users { get; set; }
		public DbSet<UserDetail> UserDetails { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Resort> Resorts { get; set; }
		public DbSet<ResortDetail> ResortDetails { get; set; }
		public DbSet<ResortDetailServices> ResortDetailServices { get; set; }
		public DbSet<Rate> Rates { get; set; }
		public DbSet<Province> Provinces { get; set; }
		public DbSet<District> Districts { get; set; }
		public DbSet<Commune> Communes { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Convenient> Convenients { get; set; }
		public DbSet<ConvenientResort> ConvenientResorts { get; set; }
		public DbSet<TypeRoom> TypeRooms { get; set; }
		public DbSet<TypeRoomResortDetail> TypeRoomResortDetails { get; set; }
	}
}
