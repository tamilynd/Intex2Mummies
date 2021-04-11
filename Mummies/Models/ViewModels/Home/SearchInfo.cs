using Mummies.Models.MummyDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummies.Models.ViewModels.Home
{
    public class SearchInfo
    {
        public int NorthMin { get; set; } = 0;
        public int NorthMax { get; set; } = 200;
        public int EastMin { get; set; } = 0;
        public int EastMax { get; set; } = 100;
        public bool West { get; set; }
        public bool WestOrient { get; set; } 
        public bool EastOrient { get; set; }
        public bool UnknownOrient { get; set; }
        public int DepthMin { get; set; }
        public int DepthMax { get; set; }
        public bool Black { get; set; }
        public bool Blond { get; set; }
        public bool BrownRed { get; set; }
        public bool Brown { get; set; }
        public bool Red { get; set; } 
        public bool UnknownColor { get; set; } 
        public bool Female { get; set; } 
        public bool Male { get; set; } 
        public bool UnknownGender { get; set; } 
        public bool Adult { get; set; } 
        public bool Child { get; set; } 
        public bool Infant { get; set; } 
        public bool Newborn { get; set; } 
        public bool UnknownAge { get; set; } 
        public bool LittleBones { get; set; } 
        public bool FullWrap { get; set; }
        public bool PartialWrap { get; set; } 
        public bool UnknownWrap { get; set; }
        public string WrapWords { get; set; }
        public string ItemWords { get; set; } 

    }
}
