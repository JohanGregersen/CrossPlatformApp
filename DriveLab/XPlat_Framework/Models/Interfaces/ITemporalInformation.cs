using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Interfaces
{
    public interface ITemporalInformation
    {
        Int64 TripId { get; }
        Int64 EntryId { get; }

        DateTime Timestam { get; set; }
        TimeSpan SecondsToLag { get; set; }
    }
}
