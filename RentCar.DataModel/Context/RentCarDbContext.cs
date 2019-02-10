using EntityFramework.DynamicFilters;
using RentCar.DataModel.Entities;
using RentCar.DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Context
{
    public class RentCarDbContext : DbContext
    {
        public RentCarDbContext() : base("RentCarConnectionString")
        {
        }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ClientPreferredContactMedium> ClientPreferredContactMediums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties()
            .Where(x => x.Name == "Id")
            .Configure(x => x.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));

            modelBuilder.Filter("IsDeleted", (IEntityBase d) => d.IsDeleted, false);

            modelBuilder.Entity<Vehicle>()
            .HasRequired(vehicle => vehicle.VehicleBrand)
            .WithMany(vehicle => vehicle.Vehicles)
            .HasForeignKey(vehicle => vehicle.VehicleBrandId)
            .WillCascadeOnDelete(false);    

        }

        public override int SaveChanges()
        {
            CreateAuditLogInformation();
            return base.SaveChanges();
        }

        public void CreateAuditLogInformation()
        {
            foreach (var entry in ChangeTracker.Entries<IAuditEntityBase>().Where(x => x.State == EntityState.Added))
            {
                var entity = entry.Entity;
                entity.CreatedDate = DateTime.Now;
            }

            foreach (var entry in ChangeTracker.Entries<IAuditEntityBase>().Where(x => x.State == EntityState.Modified))
            {
                var entity = entry.Entity;
                entity.ModifiedDate = DateTime.Now;
            }
        }
    }
}
