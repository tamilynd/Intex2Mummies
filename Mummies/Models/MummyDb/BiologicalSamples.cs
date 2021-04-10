using System;
using System.Collections.Generic;

#nullable disable

namespace Mummies.Models.MummyDb
{
    public partial class BiologicalSamples
    {
        public string Index { get; set; }
        public string BurialId { get; set; }
        public string Rack { get; set; }
        public string Bag { get; set; }
        public string Low { get; set; }
        public string High { get; set; }
        public string NS { get; set; }
        public string Low2 { get; set; }
        public string High2 { get; set; }
        public string EW { get; set; }
        public string Area { get; set; }
        public string Burial { get; set; }
        public string Date { get; set; }
        public string PreviouslySampled { get; set; }
        public string Notes { get; set; }
        public string Initials { get; set; }
        public string Notes2 { get; set; }
    }
}
