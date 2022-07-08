using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueSquareBugTracker.Data.Entities
{
    public class Ticket
    {
        public Ticket()
        {
            Documents = new HashSet<TicketDocument>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? OwnerId { get; set; }
        public User Owner { get; set; }
        public int? InChargeId { get; set; }
        public User InCharge { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Context { get; set; }
        public virtual ICollection<TicketDocument> Documents { get; set; }
        public int? TicketPriorityId { get; set; }
        public virtual TicketPriority Priority{ get; set; }
        public int? TicketTypeId { get; set; }
        public virtual TicketType Type { get; set; }
        public ICollection<TicketActivity> Activities { get; set; }
        public ICollection<TicketMessage> Messages { get; set; }
    }
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Owner).WithMany(x => x.OwnedTickets).HasForeignKey(x => x.OwnerId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(x => x.InCharge).WithMany(x => x.InChargeTickets).HasForeignKey(x => x.InChargeId).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.Documents).WithOne(x => x.Ticket).HasForeignKey(x => x.TicketId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(x => x.Priority).WithMany(x => x.Tickets).HasForeignKey(x => x.TicketPriorityId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(x => x.Type).WithMany(x => x.Tickets).HasForeignKey(x => x.TicketPriorityId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
