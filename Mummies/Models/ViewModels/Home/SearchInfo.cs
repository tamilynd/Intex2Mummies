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
        public bool West { get; set; } = true;
        public bool WestOrient { get; set; } = true;
        public bool EastOrient { get; set; } = true;
        public bool UnknownOrient { get; set; } = true;
        public int DepthMin { get; set; } = 0;
        public int DepthMax { get; set; } = 5;
        public bool Black { get; set; } = true;
        public bool Blond { get; set; } = true;
        public bool BrownRed { get; set; } = true;
        public bool Brown { get; set; } = true;
        public bool Red { get; set; } = true;
        public bool UnknownColor { get; set; } = true;
        public bool Female { get; set; } = true;
        public bool Male { get; set; } = true;
        public bool UnknownGender { get; set; } = true;
        public bool Adult { get; set; } = true;
        public bool Child { get; set; } = true;
        public bool Infant { get; set; } = true;
        public bool Newborn { get; set; } = true;
        public bool UnknownAge { get; set; } = true;
        public bool LittleBones { get; set; } = true;
        public bool FullWrap { get; set; } = true;
        public bool PartialWrap { get; set; } = true;
        public bool UnknownWrap { get; set; } = true;
        public string WrapWords { get; set; } = "";
        public string ItemWords { get; set; } = "";

        public IQueryable<FagElGamousDatabaseByLocation> GetQuery(IMummyRepository context)
        {
            IQueryable<FagElGamousDatabaseByLocation> query = context.FagElGamousDatabaseByLocation;

            //Location
            //query = query.Where(b => b.BurialAreaNorthOrSouthUpper >= NorthMin);
            //query = query.Where(b => b.BurialAreaEastOrWestUpper >= EastMin);
            //query = query.Where(b => b.BurialAreaNorthOrSouthUpper >= NorthMax);
            //query = query.Where(b => b.BurialAreaEastOrWestUpper >= EastMax);
            if(!West)
            {
                query = query.Where(b => b.Burialxeorw == "E");
            }

            //Orientation
            if (UnknownOrient || EastOrient || WestOrient) 
            {
                if (!UnknownOrient)
                {
                    query = query.Where(b => b.BurialDirection != "U");
                    query = query.Where(b => b.BurialDirection != "");
                }
                if (!WestOrient)
                {
                    query = query.Where(b => b.BurialDirection != "W");
                }
                if (!EastOrient)
                {
                    query = query.Where(b => b.BurialDirection != "E");
                }
            }
            //Depth
            //query = query.Where(b => b.BurialDepth >= DepthMin);
            //query = query.Where(b => b.BurialDepth <= DepthMax);


            //Hair
            if(Black || Blond || BrownRed || Brown || Red || UnknownColor)
            {
                if (!Black)
                {
                    query = query.Where(b => b.HairColorCode != "K");
                }
                if (!Blond)
                {
                    query = query.Where(b => b.HairColorCode != "D");
                }
                if (!Brown)
                {
                    query = query.Where(b => b.HairColorCode != "B");
                }
                if (!BrownRed)
                {
                    query = query.Where(b => b.HairColorCode != "A");
                }
                if (!Red)
                {
                    query = query.Where(b => b.HairColorCode != "R");
                }
                if (!UnknownColor)
                {
                    query = query.Where(b => b.HairColorCode != "U");
                    query = query.Where(b => b.HairColorCode != "");
                }
            }


            //Gender
            if (Female || Male || UnknownGender)
            {
                if (!Female)
                {
                    query = query.Where(b => b.GenderCode != "F");
                }
                if (!Male)
                {
                    query = query.Where(b => b.GenderCode != "M");
                }
                if (!UnknownGender)
                {
                    query = query.Where(b => b.GenderCode != "U");
                    query = query.Where(b => b.GenderCode != "");
                }
            }

            //Age
            if (Adult || Child || Infant || Newborn || UnknownGender)
            {
                if (!Adult)
                {
                    query = query.Where(b => b.AgeCodeSingle != "A");
                }
                if (!Child)
                {
                    query = query.Where(b => b.AgeCodeSingle != "C");
                }
                if (!Infant)
                {
                    query = query.Where(b => b.AgeCodeSingle != "I");
                }
                if (!Newborn)
                {
                    query = query.Where(b => b.AgeCodeSingle != "N");
                }
                if (!UnknownAge)
                {
                    query = query.Where(b => b.AgeCodeSingle != "U");
                    query = query.Where(b => b.AgeCodeSingle != "");
                }
            }

            //Wrappings
            if (LittleBones || FullWrap || PartialWrap || UnknownWrap)
            {
                if (!LittleBones)
                {
                    query = query.Where(b => b.BurialWrapping != "B");
                }
                if (!FullWrap)
                {
                    query = query.Where(b => b.BurialWrapping != "W");
                }
                if (!PartialWrap)
                {
                    query = query.Where(b => b.BurialWrapping != "H");
                }
                if (!UnknownWrap)
                {
                    query = query.Where(b => b.BurialWrapping != "U");
                    query = query.Where(b => b.BurialWrapping != "");
                }
            }
            //query = query + " ORDER BY BurialId;";

            return context.FagElGamousDatabaseByLocation;
        }

    }
}
