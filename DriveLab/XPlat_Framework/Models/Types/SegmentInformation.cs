using DriveLab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.Devices.Geolocation;

namespace DriveLab.Models.Types
{
    public class SegmentInformation : ISegmentInformation
    {
        public Int64 SegmentId { get; set; }
        public Int64 OSMId { get; }
        public string RoadName { get; }
        public Int16 RoadType { get; }
        public Int16 Oneway { get; }
        public Int16 Bridge { get; }
        public Int16 Tunnel { get; }
        public Int16 MaxSpeed { get; set; }
        public bool Direction { get; }

        public Geopath RoadLine { get; }

        //PostgisLineString RoadLine { get; }
    }
}
