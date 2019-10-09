using MyAwesomeProject.Data.Entities;
using MyAwesomeProject.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyAwesomeProject.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }

		public DbSet<Category> Categories { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
		public DbSet<Demographic> Demographics { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Region> Regions { get; set; }
		public DbSet<Shipper> Shippers { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<Territory> Territories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		    foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
		    {
		        entityType.Relational().TableName = entityType.DisplayName();
		    }
			modelBuilder.Entity<UserInRole>().HasKey(o => new { o.UserId, o.RoleId });
			modelBuilder.Entity<UserInRole>()
				.HasOne<User>(sc => sc.User)
				.WithMany(s => s.UserInRoles)
				.HasForeignKey(sc => sc.UserId);
			modelBuilder.Entity<UserInRole>()
				.HasOne<Role>(sc => sc.Role)
				.WithMany(s => s.UserInRoles)
				.HasForeignKey(sc => sc.RoleId);

			modelBuilder.Entity<CustomerDemographic>().HasKey(o => new { o.CustomerId, o.DemographicId });
			modelBuilder.Entity<CustomerDemographic>()
				.HasOne<Customer>(sc => sc.Customer)
				.WithMany(s => s.CustomerDemographics)
				.HasForeignKey(sc => sc.CustomerId);
			modelBuilder.Entity<CustomerDemographic>()
				.HasOne<Demographic>(sc => sc.Demographic)
				.WithMany(s => s.CustomerDemographics)
				.HasForeignKey(sc => sc.DemographicId);
			modelBuilder.Entity<EmployeeTerritory>().HasKey(o => new { o.EmployeeId, o.TerritoryId });
			modelBuilder.Entity<EmployeeTerritory>()
				.HasOne<Employee>(sc => sc.Employee)
				.WithMany(s => s.EmployeeTerritories)
				.HasForeignKey(sc => sc.EmployeeId);
			modelBuilder.Entity<EmployeeTerritory>()
				.HasOne<Territory>(sc => sc.Territory)
				.WithMany(s => s.EmployeeTerritories)
				.HasForeignKey(sc => sc.TerritoryId);
			modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.OrderId, o.ProductId });
			modelBuilder.Entity<OrderDetail>()
				.HasOne<Order>(sc => sc.Order)
				.WithMany(s => s.OrderDetails)
				.HasForeignKey(sc => sc.OrderId);
			modelBuilder.Entity<OrderDetail>()
				.HasOne<Product>(sc => sc.Product)
				.WithMany(s => s.OrderDetails)
				.HasForeignKey(sc => sc.ProductId);
			
			SeedAdminUser(modelBuilder);
		}
		
		private void SeedAdminUser(ModelBuilder modelBuilder)
		{
			var adminRole = new Role { RoleId = 1, RoleName = "admin" };
			modelBuilder.Entity<Role>().HasData(adminRole);

			byte[] passwordHash, passwordSalt;
			AuthHelper.CreatePasswordHash("admin", out passwordHash, out passwordSalt);
			var adminUser = new User
			{
				UserId = 1,
				Username = "admin",
				FirstName = "Default",
				LastName = "Admin",
				PasswordHash = passwordHash,
				PasswordSalt = passwordSalt
			};
			modelBuilder.Entity<User>().HasData(adminUser);

			modelBuilder.Entity<UserInRole>().HasData(new UserInRole
			{
				RoleId = adminRole.RoleId,
				UserId = adminUser.UserId
			});
		}
	}
}
