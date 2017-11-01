using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Interfaces
{
    public interface IMeasureInformation
    {
        Int64 TripId { get; }
        Int64 EntryId { get; }
        

        double Speed { get; set; }
        double Acceleration { get; set; }
        double Jerk { get; set; }
    }
}
