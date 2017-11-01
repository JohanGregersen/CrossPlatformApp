using DriveLab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Types
{
    public class FlagInformation : IFlagInformation
    {
        public Int64 TripId { get; }
        public Int64 EntryId { get; }

        public bool Speeding { get; set; }
        public bool Accelerating { get; set; }
        public bool Jerking { get; set; }
        public bool Braking { get; set; }
        public bool SteadySpeed { get; set; }
    }
}
