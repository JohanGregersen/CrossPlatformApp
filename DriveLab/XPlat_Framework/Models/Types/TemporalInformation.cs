using DriveLab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Types
{
    public class TemporalInformation : ITemporalInformation
    {
        public Int64 TripId { get; }
        public Int64 EntryId { get; }

        public DateTime Timestam { get; set; }
        public TimeSpan SecondsToLag { get; set; }
    }
}
