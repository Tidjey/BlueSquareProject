using System.ComponentModel.DataAnnotations;

namespace BlueSquareBugTracker.Models
{
    public class TicketFormViewModel
    {
        [Required]
        public int TickeTypeId { get; set; }
        [Required]
        public int TicketPriorityId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Context { get; set; }
        public Dictionary<int, string> Types { get; set; }
        public Dictionary<int, string> Priorities { get; set; }
        public IEnumerable<IFormFile> Documents { get; set; }

    }
}
