﻿using AutoMapper;
using Evento.Core.Domain;
using Evento.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evento.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Event, EventDTO>()
                .ForMember(x => x.AvaiableTicketsCount, m => m.MapFrom(p => p.AvailableTickets.Count()))
                .ForMember(x => x.PurchasedTicketsCount, m => m.MapFrom(p => p.PurchasedTickets.Count()))
                .ForMember(x => x.TicketsCount, m => m.MapFrom(p => p.Tickets.Count()));
                cfg.CreateMap<Event, EventDetailsDTO>();
                cfg.CreateMap<Ticket,TicketDTO>();
                cfg.CreateMap<Ticket, TicketDetailsDTO>();
                cfg.CreateMap<User, AccountDTO>();
            })
            .CreateMapper();
    }
}
