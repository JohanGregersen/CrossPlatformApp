using DriveLab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Types
{
    public class Fact : IFact
    {
        public Int64 EntryId { get; set; }
        public int CarId { get; set; }
        public IQualityInformation Quality { get; set; }
        public ISegmentInformation Segment { get; set; }
        public ITemporalInformation Temporal { get; set; }
        public ISpatialInformation Spatial { get; set; }
        public IMeasureInformation Measure { get; set; }
        public IFlagInformation Flag { get; set; }
    }
}
