using System;
using System.Collections.Generic;

#nullable disable

namespace intex2.Models
{
    public partial class BurialNote
    {
        public string BurialId { get; set; }
        public string? BurialNotes { get; set; }
        public string? OsteologyNotes { get; set; }
    }
}
