using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Interfaces
{
    public interface IFlagInformation
    {
        Int64 TripId { get; }
        Int64 EntryId { get; }
        
        bool Speeding { get; set; }
        bool Accelerating { get; set; }
        bool Jerking { get; set; }
        bool Braking { get; set; }
        bool SteadySpeed { get; set; }
    }
}
