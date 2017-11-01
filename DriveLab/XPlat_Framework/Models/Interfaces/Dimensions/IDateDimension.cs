using System;
using System.Collections.Generic;
using System.Text;

namespace DriveLab.Models.Interfaces.Dimensions
{
    interface IDateDimension
    {
        int DateId { get; set; }
        Int16 Year { get; set; }
        Int16 Month { get; set; }
        Int16 Day { get; set; }
        Int16 DayOfWeek { get; set; }
        bool Weekend { get; set; }
        bool Holiday { get; set; }
        Int16 Quarter { get; set; }
        Int16 Season { get; set; }
    }
}
