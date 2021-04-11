using System;
using System.Collections.Generic;

#nullable disable

namespace intex2.Model
{
    public partial class BurialId
    {
        public string BurialId1 { get; set; }
        public double? LowPairNs { get; set; }
        public double? HighPairNs { get; set; }
        public string BurialLocationNs { get; set; }
        public double? LowPairEw { get; set; }
        public double? HighPairEw { get; set; }
        public string BurialLocationEw { get; set; }
        public string BurialArea { get; set; }
        public double? BurialNum { get; set; }
        public string F10 { get; set; }
    }
}
