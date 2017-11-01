using DriveLab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.Devices.Geolocation;

namespace DriveLab.Models.Types
{
    public class SpatialInformation : ISpatialInformation
    {
        public Int64 TripId { get; }
        public Int64 EntryId { get; }

        public Geocoordinate Point { get; }
        public Geocoordinate MPoint { get; }
    }
}
