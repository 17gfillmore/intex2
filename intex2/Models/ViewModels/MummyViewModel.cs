using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intex2.Models.ViewModels
{
    public class MummyViewModel
    {
        public List<RemainsCharacteristic> Remains { get; set; }

        public List<BurialCharacteristic> Burials { get; set; }

        public List<BurialId> Ids { get; set; }

        public List<BurialNote> Notes { get; set; }

        public List<BiologicalSample> Biologicals {get; set; }

        public List<Artifact> Artifacts { get; set; }
    }
}
