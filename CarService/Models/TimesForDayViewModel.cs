using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.Models
{
    public class TimesForDayViewModel
    {
        public Dictionary<DateTime,bool> IsReservedTimes { get; set; }
    }
}