using System;
using System.Collections.Generic;

#nullable disable

namespace intex2.Models
{
    public partial class Artifact
    {
        public string BurialId { get; set; }
        public string ArtifactId { get; set; }
        public string ArtifactDescription { get; set; }
        public string PhotoDate { get; set; }
        public string ScientificDate { get; set; }
        public string Sampled { get; set; }
        public string SampledDate { get; set; }
        public string RackNum { get; set; }
        public string BagNum { get; set; }
    }
}
