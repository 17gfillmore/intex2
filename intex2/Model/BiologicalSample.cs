using System;
using System.Collections.Generic;

#nullable disable

namespace intex2.Model
{
    public partial class BiologicalSample
    {
        public double? BiosampleId { get; set; }
        public string BurialId { get; set; }
        public double? ClusterNum { get; set; }
        public double? RackNum { get; set; }
        public string BagNum { get; set; }
        public double? SampleDate { get; set; }
        public string PreviouslySampled { get; set; }
        public string SampleNotes { get; set; }
        public string Initials { get; set; }
        public double? SampleNumber { get; set; }
        public double? MaximumCranialLength { get; set; }
        public double? MaximumCranialBreadth { get; set; }
        public double? BasionBregmaHeight { get; set; }
        public double? BasionNasion { get; set; }
        public double? BasionProsthionLength { get; set; }
        public double? BizygomaticDiameter { get; set; }
        public double? NasionProsthion { get; set; }
        public double? MaximumNasalBreadth { get; set; }
        public double? InterorbitalBreadth { get; set; }
    }
}
