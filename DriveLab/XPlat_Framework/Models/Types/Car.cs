using DriveLab.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Types
{
    public class Car : ICar
    {
        public Int16 CarId { get; }
        public string CarType { get; }
        public string Brand { get; }
        public string Model { get; }
        public double FuelConsumption { get; }
        public double EnergyConsumption { get; }
        public double Weight { get; }
        public Int16 Capacity { get; }
        public Int64 IMEI { get; set; }
        public string Username { get; set; }
    }
}
