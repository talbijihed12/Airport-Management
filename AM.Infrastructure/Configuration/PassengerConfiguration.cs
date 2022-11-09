﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{


    
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasDiscriminator<String>("IsTraveller").HasValue<Traveller>("1")
                                                           .HasValue<Staff>("2")
                                                           .HasValue("0");
            builder.OwnsOne(p=> p.fullName , myname =>
            {
                myname.Property(f => f.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
                myname.Property(f => f.LastName).HasColumnName("PassLastName").IsRequired();
            })
;
        }
    }
}
