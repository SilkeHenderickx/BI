namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AGVStagingContext : DbContext
    {
        public AGVStagingContext()
            : base("name=AGVStagingContext")
        {
        }

        public virtual DbSet<Staging_AGV> Staging_AGV { get; set; }
        public virtual DbSet<Staging_Alert> Staging_Alert { get; set; }
        public virtual DbSet<Staging_Customer> Staging_Customer { get; set; }
        public virtual DbSet<Staging_SpeedCategory> Staging_SpeedCategory { get; set; }
        public virtual DbSet<Staging_AlertDescription> Staging_AlertDescription { get; set; }

        public void AddAlert(Staging_Alert alert)
        {
            using (var ctx = new AGVStagingContext())
            {
                ctx.Staging_Alert.Add(alert);
                ctx.SaveChanges();
            }
        }

        public void AddCustomer(Staging_Customer customer)
        {
            using (var ctx = new AGVStagingContext())
            {
                ctx.Staging_Customer.Add(customer);
                ctx.SaveChanges();
            }
        }

        public void AddAGV(Staging_AGV agv)
        {
            using (var ctx = new AGVStagingContext())
            {
                ctx.Staging_AGV.Add(agv);
                ctx.SaveChanges();
            }
        }

        public void AddAlertDescription(Staging_AlertDescription alertDescription)
        {
            using (var ctx = new AGVStagingContext())
            {
                ctx.Staging_AlertDescription.Add(alertDescription);
                ctx.SaveChanges();
            }
        }

        public void AddSpeedCategory(Staging_SpeedCategory speedCategory)
        {
            using (var ctx = new AGVStagingContext())
            {
                ctx.Staging_SpeedCategory.Add(speedCategory);
                ctx.SaveChanges();
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staging_AGV>()
                .Property(e => e.Identification)
                .IsFixedLength();

            modelBuilder.Entity<Staging_Alert>()
                .Property(e => e.AlertType)
                .IsUnicode(false);

            modelBuilder.Entity<Staging_Alert>()
                .Property(e => e.TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Staging_Customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Staging_Customer>()
                .Property(e => e.CustomerCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Staging_Customer>()
                .Property(e => e.CustomerBranch)
                .IsUnicode(false);

            modelBuilder.Entity<Staging_Customer>()
                .HasMany(e => e.Staging_AGV)
                .WithRequired(e => e.Staging_Customer)
                .HasForeignKey(e => e.CustKey)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staging_SpeedCategory>()
                .Property(e => e.SpeedCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Staging_AlertDescription>()
                .Property(e => e.AlertDescription)
                .IsUnicode(false);
        }
    }
}
