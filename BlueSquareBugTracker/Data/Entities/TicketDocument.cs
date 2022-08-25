using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueSquareBugTracker.Data.Entities
{
    public class TicketDocument
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
        public int? DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
    public class TicketDocumentConfiguration : IEntityTypeConfiguration<TicketDocument>
    {
        public void Configure(EntityTypeBuilder<TicketDocument> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Ticket).WithMany(x => x.Documents).HasForeignKey(x => x.TicketId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Document).WithMany(x => x.TicketDocuments).HasForeignKey(x => x.DocumentId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
