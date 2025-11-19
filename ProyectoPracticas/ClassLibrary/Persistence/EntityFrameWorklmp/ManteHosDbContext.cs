using System;
using System.Data.Entity;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using ManteHos.Entities;

namespace ManteHos.Persistence
{
    public class ManteHosDbContext : DbContextISW
    {
        public ManteHosDbContext() : base("Name=ManteHosDbConnection") //this is the connection string name
        {
            /*
            See DbContext.Configuration documentation
            */
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        static ManteHosDbContext()
        {
            Database.SetInitializer<ManteHosDbContext>(new DropCreateDatabaseIfModelChanges<ManteHosDbContext>());
        }

        // DbSets for persistent classes in your case study
        public virtual IDbSet<Area> Areas { get; set; }
        public virtual IDbSet<Employee> Employees { get; set; }
        public virtual IDbSet<Head> Heads { get; set; }
        public virtual IDbSet<Master> Masters { get; set; }
        public virtual IDbSet<Operator> Operators { get; set; }
        public virtual IDbSet<Incident> Incidents { get; set; }
        public virtual IDbSet<WorkOrder> WorkOrders { get; set; }
        public virtual IDbSet<Part> Parts { get; set; }
        public virtual IDbSet<UsedPart> UsedParts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Incident>()
                .HasOptional(i => i.WorkOrder) 
                .WithRequired(w => w.Incident) 
                .WillCascadeOnDelete(false);

            
            modelBuilder.Entity<Area>()
                .HasRequired(a => a.Master) 
                .WithOptional(m => m.Area) 
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ReportedIncidents)
                .WithRequired(i => i.Reporter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Area>()
                .HasMany(a => a.Incidents)
                .WithRequired(i => i.Area)
                .WillCascadeOnDelete(false);

            /*modelBuilder.Entity<WorkOrder>()
                .HasMany(w => w.UsedParts)
                .WithRequired(up => up.WorkOrder)
                .WillCascadeOnDelete(false);
            */
            modelBuilder.Entity<Part>()
                .HasMany(p => p.UsedParts)
                .WithRequired(up => up.Part)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkOrder>()
                .HasMany(w => w.Operators)
                .WithMany(o => o.WorkOrders)
                .Map(m =>
                {
                    m.ToTable("WorkOrderOperators");
                    m.MapLeftKey("WorkOrderId");
                    m.MapRightKey("OperatorId");
                });

            base.OnModelCreating(modelBuilder);
        }

        // Generic method to clear all the data (except some relations if needed)
        public override void RemoveAllData()
        {
            clearSomeRelationships();

            base.RemoveAllData(); 
        }

        // Sometimes it is needed to clear some relationships explicitly 
        private void clearSomeRelationships()
        {
//            SaveChanges();
        }

    }
}

