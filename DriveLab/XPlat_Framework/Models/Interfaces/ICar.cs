using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Interfaces
{
    public interface ICar
    {
         Int16 CarId { get; }
         string CarType { get; }
         string Brand { get; }
         string Model { get; }
         double FuelConsumption { get; }
         double EnergyConsumption { get; }
         double Weight { get; }
         Int16 Capacity { get; }
         Int64 IMEI { get; set; }
         string Username { get; set; }
    }
}
