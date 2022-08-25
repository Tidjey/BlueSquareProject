using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueSquareBugTracker.Data.Entities
{
    public class TicketType
    {
        public TicketType()
        {
            Tickets = new HashSet<Ticket>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
    public class TicketTypeConfiguration : IEntityTypeConfiguration<TicketType>
    {
        public void Configure(EntityTypeBuilder<TicketType> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
