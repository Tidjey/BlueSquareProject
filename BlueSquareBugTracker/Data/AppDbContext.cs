using BlueSquareBugTracker.Core.Security;
using BlueSquareBugTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlueSquareBugTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new TicketActivityConfiguration());
            modelBuilder.ApplyConfiguration(new TicketDocumentConfiguration());
            modelBuilder.ApplyConfiguration(new TicketMessageConfiguration());
            modelBuilder.ApplyConfiguration(new TicketPriorityConfiguration());
            modelBuilder.ApplyConfiguration(new TicketTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            Seeding(modelBuilder);
        }
        protected void Seeding(ModelBuilder modelBuilder)
        {
            #region UserRole
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    Id = 1,
                    RoleName = "Client"
                },
                new UserRole
                {
                    Id = 2,
                    RoleName = "Opérateur"
                },
                new UserRole
                {
                    Id = 3,
                    RoleName = "Admin"
                }
            );
            #endregion
            #region TicketType
            modelBuilder.Entity<TicketType>().HasData(
                new TicketType
                {
                    Id = 1,
                    Name = "Problème technique"
                },
                new TicketType
                {
                    Id = 2,
                    Name = "Réclamation"
                },
                new TicketType
                {
                    Id = 3,
                    Name = "Demande de développement"
                }
            );
            #endregion
            #region
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserRoleId = 1,
                    Created = DateTime.Now,
                    Mail = "client@xxx.yyy",
                    Password = Crypt.Hash("**********")
                },
                new User
                {
                    Id = 2,
                    UserRoleId = 2,
                    Created = DateTime.Now,
                    Mail = "operator@xxx.yyy",
                    Password = Crypt.Hash("**********")
                },
                new User
                {
                    Id = 3,
                    UserRoleId = 3,
                    Created = DateTime.Now,
                    Mail = "admin@xxx.yyy",
                    Password = Crypt.Hash("**********")
                }
            );
            #endregion
        }
        #region DbSets
        public virtual DbSet<Document> Documents {get;set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketActivity> TicketActivities { get; set; }
        public virtual DbSet<TicketDocument> TicketDocuments { get; set; }
        public virtual DbSet<TicketMessage> TicketMessages { get; set; }
        public virtual DbSet<TicketPriority> TicketPriorities { get; set; }
        public virtual DbSet<TicketType> TicketTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        #endregion
    }
}
