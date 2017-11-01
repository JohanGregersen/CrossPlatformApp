using System;
using System.Collections.Generic;
using System.Text;
using DriveLab.Models.Interfaces.Dimensions;

namespace DriveLab.Models.Types.Dimensions
{
     public class TimeDimension : ITimeDimension
    {
        public int TimeId { get; set; }
        public Int16 Hour { get; set; }
        public Int16 Minute { get; set; }
        public Int16 Second { get; set; }
    }
}
