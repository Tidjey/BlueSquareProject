namespace BlueSquareBugTracker.Data.Entities
{
    public class TicketState
    {
        public TicketState()
        {
            Tickets = new HashSet<Ticket>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
