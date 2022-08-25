using BlueSquareBugTracker.Core.Security;
using BlueSquareBugTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlueSquareBugTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApllyConfigurations(modelBuilder);
            Seeding(modelBuilder);
        }
        protected void ApllyConfigurations(ModelBuilder modelBuilder)
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
            #region TicketPriority
            modelBuilder.Entity<TicketPriority>().HasData(
                new TicketPriority
                {
                    Id = 1,
                    Name = "Basse",
                    Priority = 1
                },
                new TicketPriority
                {
                    Id = 2,
                    Name = "Moyenne",
                    Priority = 2
                },
                new TicketPriority
                {
                    Id = 3,
                    Name = "Haute",
                    Priority = 3
                }
            );
            #endregion
            #region User
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserRoleId = 1,
                    Created = DateTime.Now,
                    Mail = "client@xxx.yyy",
                    Password = Crypt.Hash("**********"),
                    AvatarUrl = ""
                },
                new User
                {
                    Id = 2,
                    UserRoleId = 2,
                    Created = DateTime.Now,
                    Mail = "operator@xxx.yyy",
                    Password = Crypt.Hash("**********"),
                    AvatarUrl = ""
                },
                new User
                {
                    Id = 3,
                    UserRoleId = 3,
                    Created = DateTime.Now,
                    Mail = "admin@xxx.yyy",
                    Password = Crypt.Hash("**********"),
                    AvatarUrl = ""
                }
            );
            #endregion
        }
        #region DbSets
        public virtual DbSet<Document> Document { get;set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TicketActivity> TicketActivity { get; set; }
        public virtual DbSet<TicketDocument> TicketDocument { get; set; }
        public virtual DbSet<TicketMessage> TicketMessage { get; set; }
        public virtual DbSet<TicketPriority> TicketPriority { get; set; }
        public virtual DbSet<TicketType> TicketType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        #endregion
    }
}
