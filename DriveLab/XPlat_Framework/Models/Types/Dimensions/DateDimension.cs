using System;
using System.Collections.Generic;
using System.Text;
using DriveLab.Models.Interfaces.Dimensions;

namespace DriveLab.Models.Types.Dimensions
{
    public class DateDimension : IDateDimension
    {
        public int DateId { get; set; }
        public Int16 Year { get; set; }
        public Int16 Month { get; set; }
        public Int16 Day { get; set; }
        public Int16 DayOfWeek { get; set; }
        public bool Weekend { get; set; }
        public bool Holiday { get; set; }
        public Int16 Quarter { get; set; }
        public Int16 Season { get; set; }
    }
}
