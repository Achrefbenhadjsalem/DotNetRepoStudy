﻿using AM.ApplicationCore.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infra.Configuration
{
    public class ReservationTicketConfiguration: IEntityTypeConfiguration<ReservationTicket>
    {
        public void Configure(EntityTypeBuilder<ReservationTicket> builder)
        {
            builder.HasKey(p => new {p.PassengerFK, p.TicketFK, p.DateReservation });
        }

    }
}
