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

        public string GetQuery()
        {
            string query = "SELECT * FROM FagElGamousDatabaseByLocation WHERE";

            //Location
            query = query + " ((BurialAreaNorthOrSouthUpper >= " + NorthMin;
            query = query + " AND BurialAreaEastOrWestUpper >= " + EastMin; 
            query = query + " AND BurialAreaNorthOrSouthUpper <= " + NorthMax;
            query = query + " AND BurialAreaEastOrWestUpper <= " + EastMax + ")";
            if(!West)
            {
                query = query + " OR Burialxeorw = \'W\')";
            }
            else
            {
                query = query + " AND Burialxeorw = \'E\')";
            }
            //Orientation
            if (UnknownOrient || EastOrient || WestOrient) 
            {
                if (!UnknownOrient)
                {
                    query = query + " AND BurialDirection != \'U\' AND BurialDirection != \'\'";
                }
                if (!WestOrient)
                {
                    query = query + " AND BurialDirection != \'W\'";
                }
                if (!EastOrient)
                {
                    query = query + " AND BurialDirection != \'E\'";
                }
            }
            //Depth
            query = query + " AND (BurialDepth <= " + DepthMin;
            query = query + " AND BurialDepth >= " + DepthMax + ")";


            //Hair
            if(Black || Blond || BrownRed || Brown || Red || UnknownColor)
            {
                if (!Black)
                {
                    query = query + " AND HairColorCode != \'K\'";
                }
                if (!Blond)
                {
                    query = query + " AND HairColorCode != \'D\'";
                }
                if (!Brown)
                {
                    query = query + " AND HairColorCode != \'B\'";
                }
                if (!BrownRed)
                {
                    query = query + " AND HairColorCode != \'A\'";
                }
                if (!Red)
                {
                    query = query + " AND HairColorCode != \'R\'";
                }
                if (!UnknownColor)
                {
                    query = query + " AND HairColorCode != \'U\' AND HairColorCode != \'\'";
                }
            }


            //Gender
            if (Female || Male || UnknownGender)
            {
                if (!Female)
                {
                    query = query + " AND GenderCode != \'F\'";
                }
                if (!Male)
                {
                    query = query + " AND GenderCode != \'M\'";
                }
                if (!UnknownGender)
                {
                    query = query + " AND GenderCode != \'U\' AND GenderCode != \'\'";
                }
            }

            //Age
            if (Adult || Child || Infant || Newborn || UnknownGender)
            {
                if (!Adult)
                {
                    query = query + " AND AgeCodeSingle != \'A\'";
                }
                if (!Child)
                {
                    query = query + " AND AgeCodeSingle != \'C\'";
                }
                if (!Infant)
                {
                    query = query + " AND AgeCodeSingle != \'I\'";
                }
                if (!Newborn)
                {
                    query = query + " AND AgeCodeSingle != \'N\'";
                }
                if (!UnknownAge)
                {
                    query = query + " AND AgeCodeSingle != \'U\' AND AgeCodeSingle != \'\'";
                }
            }

            //Wrappings
            if (LittleBones || FullWrap || PartialWrap || UnknownWrap)
            {
                if (!LittleBones)
                {
                    query = query + " AND BurialWrapping != \'B\'";
                }
                if (!FullWrap)
                {
                    query = query + " AND BurialWrapping != \'W\'";
                }
                if (!PartialWrap)
                {
                    query = query + " AND BurialWrapping != \'H\'";
                }
                if (!UnknownWrap)
                {
                    query = query + " AND BurialWrapping != \'U\' AND AgeCodeSingle != \'\'";
                }
            }
            //query = query + " ORDER BY BurialId;";

            return query;
        }

    }
}
