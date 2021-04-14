using System;
using System.Collections.Generic;

#nullable disable

namespace intex2.Models
{
    public partial class BurialCharacteristic
    {
        public string? BurialId { get; set; }
        public double? SouthToHead { get; set; }
        public double? SouthToFeet { get; set; }
        public double? WestToHead { get; set; }
        public double? WestToFeet { get; set; }
        public string? LengthRemainsMeasured { get; set; }
        public string? LengthRemainsCalculated { get; set; }
        public double? DepthRemains { get; set; }
        public string? HeadDirection { get; set; }
        public string? Cluster { get; set; }
        public string? YearFound { get; set; }
        public string? MonthFound { get; set; }
        public string? DayFound { get; set; }
    }
}
