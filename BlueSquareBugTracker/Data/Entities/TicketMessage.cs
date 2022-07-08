using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueSquareBugTracker.Data.Entities
{
    public class TicketMessage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int? AuthorId { get; set; }   
        public virtual User Author { get; set; }

    }
    public class TicketMessageConfiguration : IEntityTypeConfiguration<TicketMessage>
    {
        public void Configure(EntityTypeBuilder<TicketMessage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Ticket).WithMany(x => x.Messages).HasForeignKey(x => x.TicketId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Author).WithMany(x => x.TicketMessages).HasForeignKey(x => x.AuthorId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
