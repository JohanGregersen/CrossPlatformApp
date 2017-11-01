using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Interfaces
{
    public interface IQualityInformation
    {
        Int64 TripId { get; }
        Int64 EntryId { get; }
        Int16 QualityId { get; }
        Int16 Sat { get; }
        double Hdop { get; }
    }
}
