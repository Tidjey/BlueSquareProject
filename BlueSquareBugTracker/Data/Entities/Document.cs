using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueSquareBugTracker.Data.Entities
{
    public class Document
    {
        public Document()
        {
            TicketDocuments = new HashSet<TicketDocument>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public int? UploaderId { get; set; }
        public virtual User Uploader { get; set; }
        public virtual ICollection<TicketDocument> TicketDocuments { get; set; }

    }
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Uploader).WithMany(x => x.Documents).HasForeignKey(x => x.UploaderId).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(x => x.TicketDocuments).WithOne(x => x.Document).HasForeignKey(x => x.DocumentId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
