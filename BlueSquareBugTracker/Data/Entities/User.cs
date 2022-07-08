using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueSquareBugTracker.Data.Entities
{
    public class User
    {
        public User()
        {
            OwnedTickets = new HashSet<Ticket>();
            InChargeTickets = new HashSet<Ticket>();
            Documents = new HashSet<Document>();
            Documents = new HashSet<Document>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public string AvatarUrl { get; set; }
        public ICollection<Ticket> OwnedTickets { get; set; }
        public ICollection<Ticket> InChargeTickets { get; set; }
        public int? UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<TicketActivity> TicketActivities { get; set; }
        public ICollection<TicketMessage> TicketMessages { get; set; }
    }
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.UserRole).WithMany(x => x.Users).HasForeignKey(x => x.UserRoleId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
