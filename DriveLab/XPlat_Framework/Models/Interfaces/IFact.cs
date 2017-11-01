using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Interfaces
{
    public interface IFact
    {
        Int64 EntryId { get; set; }
        int CarId { get; set; }
        IQualityInformation Quality { get; set; }
        ISegmentInformation Segment { get; set; }
        ITemporalInformation Temporal { get; set; }
        ISpatialInformation Spatial { get; set; }
        IMeasureInformation Measure { get; set; }
        IFlagInformation Flag { get; set; }
    }
}
