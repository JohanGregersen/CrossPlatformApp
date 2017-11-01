using DriveLab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Types
{
    public class QualityInformation : IQualityInformation
    {
        public Int64 TripId { get; }
        public Int64 EntryId { get; }
        public Int16 QualityId { get; }
        public Int16 Sat { get; }
        public double Hdop { get; }
    }
}
