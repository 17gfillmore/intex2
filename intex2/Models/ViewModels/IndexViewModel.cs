using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace intex2.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<RemainsCharacteristic> Remains { get; set; }

        public List<BurialCharacteristic> Burials { get; set; }

        public PageNum pageNum { get; set; }
    }
}
