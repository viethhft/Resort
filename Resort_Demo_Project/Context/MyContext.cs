﻿using Microsoft.EntityFrameworkCore;
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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
				.HasKey(u => u.IdUser);

			modelBuilder.Entity<Role>()
				.HasKey(r => r.IdRole);

			modelBuilder.Entity<Resort>()
				.HasKey(rs => rs.IdResort);

			modelBuilder.Entity<UserDetail>()
				.HasKey(ud => ud.IdUserDetail);

			modelBuilder.Entity<ResortDetail>()
				.HasKey(rd =>rd.IdResortDetail);

			modelBuilder.Entity<ResortDetailServices>()
				.HasKey(rds => new {rds.IdService,rds.IdResortDetail});

			modelBuilder.Entity<Rate>()
				.HasKey(r => r.IdRate);

			modelBuilder.Entity<Province>()
				.HasKey(p => p.IdProvince);

			modelBuilder.Entity<District>()
				.HasKey(d => d.IdDistrict);

			modelBuilder.Entity<Commune>()
				.HasKey(c => c.IdCommune);

			modelBuilder.Entity<Service>()
				.HasKey(s => s.IdService);

			modelBuilder.Entity<Convenient>()
				.HasKey(cv => cv.IdConvenient);

			modelBuilder.Entity<ConvenientResort>()
				.HasKey(cr => new {cr.IdConvenient,cr.IdResort});

			modelBuilder.Entity<TypeRoom>()
				.HasKey(t => t.IdTypeRoom);

			modelBuilder.Entity<TypeRoomResortDetail>()
				.HasKey(trrd => new { trrd.IdTypeRoom, trrd.IdResortDetail});

			modelBuilder.Entity<User>()
				.HasOne(u => u.Role)
				.WithOne(r => r.User)
				.HasForeignKey<User>(u => u.IdRole);

			modelBuilder.Entity<UserDetail>()
				.HasOne(ud => ud.User)
				.WithOne(u => u.UserDetail)
				.HasForeignKey<UserDetail>(ud => ud.IdUser);

			modelBuilder.Entity<Resort>()
				.HasOne(r => r.Commune)
				.WithMany(c => c.Resort)
				.HasForeignKey(r => r.IdCommune);

			modelBuilder.Entity<ResortDetail>()
				.HasOne(rd => rd.Resort)
				.WithOne(r => r.ResortDetail)
				.HasForeignKey<ResortDetail>(rd => rd.IdResort);

			modelBuilder.Entity<ResortDetailServices>()
				.HasOne(rds => rds.Service)
				.WithMany(s => s.ResortDetailServices)
				.HasForeignKey(rds => rds.IdService);
			modelBuilder.Entity<ResortDetailServices>()
				.HasOne(rds => rds.ResortDetail)
				.WithMany(s => s.ResortDetailServices)
				.HasForeignKey(rds => rds.IdResortDetail);

			modelBuilder.Entity<Rate>()
				.HasOne(r => r.User)
				.WithMany(u => u.Rates)
				.HasForeignKey(r => r.IdUser);

			modelBuilder.Entity<District>()
				.HasOne(d => d.Province)
				.WithMany(p => p.Districts)
				.HasForeignKey(d => d.IdProvince);

			modelBuilder.Entity<Commune>()
				.HasOne(c => c.District)
				.WithMany(d => d.Communes)
				.HasForeignKey(c => c.IdDistrict);

			modelBuilder.Entity<ConvenientResort>()
				.HasOne(cvr => cvr.Convenient)
				.WithMany(r => r.ConvenientResorts)
				.HasForeignKey(cvr => cvr.IdConvenient);
			modelBuilder.Entity<ConvenientResort>()
				.HasOne(cvr => cvr.Resort)
				.WithMany(r => r.ConvenientResorts)
				.HasForeignKey(cvr => cvr.IdResort);

			modelBuilder.Entity<TypeRoomResortDetail>()
				.HasOne(trrd => trrd.ResortDetail)
				.WithMany(rd => rd.TypeRoomResortDetails)
				.HasForeignKey(cvr => cvr.IdResortDetail);
			modelBuilder.Entity<TypeRoomResortDetail>()
				.HasOne(trrd => trrd.TypeRoom)
				.WithMany(tr => tr.TypeRoomResortDetails)
				.HasForeignKey(cvr => cvr.IdTypeRoom);

		}
	}
}
