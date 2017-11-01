using System;
using System.Collections.Generic;
using System.Text;
using Windows.Devices.Geolocation;

namespace DriveLab.Models.Interfaces
{
    public interface ISpatialInformation
    {
        Int64 TripId { get; }
        Int64 EntryId { get; }

        Geocoordinate Point { get; }


        Geocoordinate MPoint { get; }
    }
}
