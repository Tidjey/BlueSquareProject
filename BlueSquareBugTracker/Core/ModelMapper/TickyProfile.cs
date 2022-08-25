using AutoMapper;
using BlueSquareBugTracker.Data.Entities;
using BlueSquareBugTracker.Models;

namespace BlueSquareBugTracker.Core.ModelMapper
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<Ticket, TicketFormViewModel>();
        }
    }
}
