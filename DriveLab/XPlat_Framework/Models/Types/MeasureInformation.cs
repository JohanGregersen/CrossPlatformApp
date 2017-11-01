using DriveLab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Types
{
    public class MeasureInformation : IMeasureInformation
    {
        public Int64 TripId { get; }
        public Int64 EntryId { get; }


        public double Speed { get; set; }
        public double Acceleration { get; set; }
        public double Jerk { get; set; }
    }
}
