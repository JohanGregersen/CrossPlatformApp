using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Interfaces.Dimensions
{
    interface ITimeDimension
    {
        int TimeId { get; set; }
        Int16 Hour { get; set; }
        Int16 Minute { get; set; }
        Int16 Second { get; set; }
    }
}
