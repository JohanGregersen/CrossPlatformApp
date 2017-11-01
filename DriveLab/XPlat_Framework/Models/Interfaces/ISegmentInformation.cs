using System;
using System.Collections.Generic;
using System.Text;
using Windows.Devices.Geolocation;

namespace DriveLab.Models.Interfaces
{
    public interface ISegmentInformation
    {
        Int64 SegmentId { get; set; }
        Int64 OSMId { get; }
        string RoadName { get; }
        Int16 RoadType { get; }
        Int16 Oneway { get; }
        Int16 Bridge { get; }
        Int16 Tunnel { get; }
        Int16 MaxSpeed { get; set; }
        bool Direction { get; }

        Geopath RoadLine { get; }

        //PostgisLineString RoadLine { get; }
    }
}
