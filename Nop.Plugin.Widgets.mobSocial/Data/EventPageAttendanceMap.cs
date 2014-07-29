﻿using System.Data.Entity.ModelConfiguration;
using Nop.Plugin.Widgets.MobSocial.Domain;

namespace Nop.Plugin.Widgets.MobSocial.Data
{

    public class EventPageAttendanceMap : EntityTypeConfiguration<EventPageAttendance>
    {

        public EventPageAttendanceMap()
        {
            ToTable("EventPageAttendance");

            //Map the primary key
            HasKey(m => m.Id);

            //Map the additional properties
            Property(m => m.EventPageId);
            Property(m => m.CustomerId);
            Property(m => m.AttendanceStatusId);

            Property(m => m.DateCreated).HasColumnType("datetime2");
            Property(m => m.DateUpdated).HasColumnType("datetime2").IsOptional();

           
            
        }

    }
}
