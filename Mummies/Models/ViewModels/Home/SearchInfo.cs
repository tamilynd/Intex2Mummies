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
        public bool ItemsFound { get; set; } = true;
        public bool NoItemsFound { get; set; } = true;
        public string WrapWords { get; set; } = "";
        public string ItemWords { get; set; } = "";
        public List<string> BoneOptions { get; set; } = new List<string>()
        {
            //"Femur Length",
            //"Humerus Length",
            //"Femur Head Measurement",
            //"Humerus Head Measurement",
            "Cranial Length",
            "Cranial Breadth",
            "Basion Bregma Height",
            "Basion Nasion",
            "Basion Prosthion Length",
            "Bizygomatic Diameter",
            "Nasion Prosthion",
            "Nasal Breadth",
            "Interorbital Breadth"
        };
        public string BoneSearch { get; set; }
        public decimal BoneMin { get; set; } = 0;
        public decimal BoneMax { get; set; } = 200;

        public string GetUrl()
        {
            string Url = "";

            if(this.NorthMin != 0)
            {
                Url = Url + "-1-" + this.NorthMin + "&";
            }
            if (this.NorthMax != 200)
            {
                Url = Url + "-2-" + this.NorthMax + "&";
            }
            if (this.EastMin != 0)
            {
                Url = Url + "-3-" + this.EastMin + "&";
            }
            if (this.EastMax != 100)  
            {
                Url = Url + "-4-" + this.EastMax + "&";
            }
            if (!this.West)
            {
                Url = Url + "-5-&";
            }
            if (!this.WestOrient)
            {
                Url = Url + "-6-&";
            }
            if (!this.EastOrient)
            {
                Url = Url + "-7-&";
            }
            if (!this.UnknownOrient)
            {
                Url = Url + "-8-&";
            }
            if (this.DepthMin != 0)
            {
                Url = Url + "-9-" + this.DepthMin + "&";
            }
            if (this.DepthMax != 5)
            {
                Url = Url + "-10-" + this.DepthMax + "&";
            }
            if (!this.Black)
            {
                Url = Url + "-11-&";
            }
            if (!this.Blond)
            {
                Url = Url + "-12-&";
            }
            if (!this.BrownRed)
            {
                Url = Url + "-13-&";
            }
            if (!this.Brown)
            {
                Url = Url + "-14-&";
            }
            if (!this.Red)
            {
                Url = Url + "-15-&";
            }
            if (!this.UnknownColor)
            {
                Url = Url + "-16-&";
            }
            if (!this.Female)
            {
                Url = Url + "-17-&";
            }
            if (!this.Male)
            {
                Url = Url + "-18-&";
            }
            if (!this.UnknownGender)
            {
                Url = Url + "-19-&";
            }
            if (!this.Adult)
            {
                Url = Url + "-20-&";
            }
            if (!this.Child)
            {
                Url = Url + "-21-&";
            }
            if (!this.Infant)
            {
                Url = Url + "-22-&";
            }
            if (!this.Newborn)
            {
                Url = Url + "-23-&";
            }
            if (!this.UnknownAge)
            {
                Url = Url + "-24-&";
            }
            if (!this.LittleBones)
            {
                Url = Url + "-25-&";
            }
            if (!this.FullWrap)
            {
                Url = Url + "-26-&";
            }
            if (!this.PartialWrap)
            {
                Url = Url + "-27-&";
            }
            if (!this.UnknownWrap)
            {
                Url = Url + "-28-&";
            }
            if (!this.ItemsFound)
            {
                Url = Url + "-29-&";
            }
            if (!this.NoItemsFound)
            {
                Url = Url + "-30-&";
            }
            if(this.WrapWords != null) {
                if (this.WrapWords.Length != 0)
                {
                    Url = Url + "-32-" + this.WrapWords + "&";
                }
            }
            if(this.ItemWords != null) { 
                if (this.ItemWords.Length != 0)
                {
                    Url = Url + "-33-" + this.ItemWords + "&";
                }
            }
            if (this.BoneMin != 0 || this.BoneMax != 200)
            {
                Url = Url + "-34-" + this.BoneSearch + "&" + this.BoneMin + "&" + this.BoneMax + "&";
            }

            return Url;

        }

        public void SetSearch(string url)
        {
            if (url.Contains("-1-"))
            {
                url = url.Replace("-1-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.NorthMin = int.Parse(value);
                url = url.Replace(value + "&", "");
            }
            if (url.Contains("-2-"))
            {
                url = url.Replace("-2-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.NorthMax = int.Parse(value);
                url = url.Replace(value + "&", "");
            }
            if (url.Contains("-3-"))
            {
                int i;
                url = url.Replace("-3-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.EastMin = int.Parse(value);
                url = url.Replace(value+"&", "");
            }
            if (url.Contains("-4-"))
            {
                int i;
                url = url.Replace("-4-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.EastMax = int.Parse(value);
                url = url.Replace(value + "&", "");
            }
            if (url.Contains("-5-"))
            {
                this.West = false;
                url = url.Replace("-5-&", "");
            }
            if (url.Contains("-6-"))
            {
                this.WestOrient = false;
                url = url.Replace("-6-&", "");
            }
            if (url.Contains("-7-"))
            {
                this.EastOrient = false;
                url = url.Replace("-7-&", "");
            }
            if (url.Contains("-8-"))
            {
                this.UnknownOrient = false;
                url = url.Replace("-8-&", "");
            }
            if (url.Contains("-9-"))
            {
                url = url.Replace("-9-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.DepthMin = int.Parse(value);
                url = url.Replace(value + "&", "");
            }
            if (url.Contains("-10-"))
            {
                url = url.Replace("-10-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.DepthMax = int.Parse(value);
                url = url.Replace(value + "&", "");
            }
            if (url.Contains("-11-"))
            {
                this.Black = false;
                url = url.Replace("-11-&", "");
            }
            if (url.Contains("-12-"))
            {
                this.Blond = false;
                url = url.Replace("-12-&", "");
            }
            if (url.Contains("-13-"))
            {
                this.BrownRed = false;
                url = url.Replace("-13-&", "");
            }
            if (url.Contains("-14-"))
            {
                this.Brown = false;
                url = url.Replace("-14-&", "");
            }
            if (url.Contains("-15-"))
            {
                this.Red = false;
                url = url.Replace("-15-&", "");
            }
            if (url.Contains("-16-"))
            {
                this.UnknownColor = false;
                url = url.Replace("-16-&", "");
            }
            if (url.Contains("-17-"))
            {
                this.Female = false;
                url = url.Replace("-17-&", "");
            }
            if (url.Contains("-18-"))
            {
                this.Male = false;
                url = url.Replace("-18-&", "");
            }
            if (url.Contains("-19-"))
            {
                this.UnknownGender = false;
                url = url.Replace("-19-&", "");
            }
            if (url.Contains("-20-"))
            {
                this.Adult = false;
                url = url.Replace("-20-&", "");
            }
            if (url.Contains("-21-"))
            {
                this.Child = false;
                url = url.Replace("-21-&", "");
            }
            if (url.Contains("-22-"))
            {
                this.Infant = false;
                url = url.Replace("-22-&", "");
            }
            if (url.Contains("-23-"))
            {
                this.Newborn = false;
                url = url.Replace("-23-&", "");
            }
            if (url.Contains("-24-"))
            {
                this.UnknownAge = false;
                url = url.Replace("-24-&", "");
            }
            if (url.Contains("-25-"))
            {
                this.LittleBones = false;
                url = url.Replace("-25-&", "");
            }
            if (url.Contains("-26-"))
            {
                this.FullWrap = false;
                url = url.Replace("-26-&", "");
            }
            if (url.Contains("-27-"))
            {
                this.PartialWrap = false;
                url = url.Replace("-27-&", "");
            }
            if (url.Contains("-28-"))
            {
                this.UnknownWrap = false;
                url = url.Replace("-28-&", "");
            }
            if (url.Contains("-29-"))
            {
                this.ItemsFound = false;
                url = url.Replace("-29-&", "");
            }
            if (url.Contains("-30-"))
            {
                this.NoItemsFound = false;
                url = url.Replace("-30-&", "");
            }
            if (url.Contains("-32-"))
            {
                url = url.Replace("-32-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.WrapWords = value;
                url = url.Replace(value + "&", "");
            }
            if (url.Contains("-33-"))
            {
                url = url.Replace("-33-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.ItemWords = value;
                url = url.Replace(value + "&", "");
            }
            if (url.Contains("-34-"))
            {
                url = url.Replace("-34-", "");
                string value = url.Substring(0, url.IndexOf("&"));
                this.BoneSearch = value;
                url = url.Replace(value + "&", "");
                string min = url.Substring(0, url.IndexOf("&"));
                this.BoneMin = int.Parse(min);
                url = url.Replace(min + "&", "");
                string max = url.Substring(0, url.IndexOf("&"));
                this.BoneMin = int.Parse(max);
            }
        }

        public IEnumerable<FagElGamousDatabaseByLocation> GetBurials(IQueryable<FagElGamousDatabaseByLocation> Query, IQueryable<Cranial2002> cranial)
        {

            IQueryable<FagElGamousDatabaseByLocation> query = Query;
            //Location
            query = query.Where(b => b.BurialAreaNorthOrSouthUpper >= this.NorthMin);
            query = query.Where(b => b.BurialAreaEastOrWestUpper >= this.EastMin);
            query = query.Where(b => b.BurialAreaNorthOrSouthLower <= this.NorthMax);
            query = query.Where(b => b.BurialAreaEastOrWestLower <= this.EastMax);
            if (!this.West)
            {
                query = query.Where(b => b.Burialxeorw == "E");
            }

            //Orientation
            if (this.UnknownOrient || this.EastOrient || this.WestOrient)
            {
                if (!this.UnknownOrient)
                {
                    query = query.Where(b => b.BurialDirection != "U");
                    query = query.Where(b => b.BurialDirection != "");
                    query = query.Where(b => b.BurialDirection != null);

                }
                if (!this.WestOrient)
                {
                    query = query.Where(b => b.BurialDirection != "W");
                }
                if (!this.EastOrient)
                {
                    query = query.Where(b => b.BurialDirection != "E");
                }
            }
            //Depth
            if (this.DepthMax == 5 && this.DepthMin == 0)
            {
                query = query.Where(b => b.BurialDepth >= this.DepthMin || b.BurialDepth == null);
                query = query.Where(b => b.BurialDepth <= this.DepthMax || b.BurialDepth == null);
            }
            else
            {
                query = query.Where(b => b.BurialDepth >= this.DepthMin);
                query = query.Where(b => b.BurialDepth <= this.DepthMax);
            }

            //Hair
            if (this.Black || this.Blond || this.BrownRed || this.Brown || this.Red || this.UnknownColor)
            {
                if (!this.Black)
                {
                    query = query.Where(b => b.HairColorCode != "K");
                }
                if (!this.Blond)
                {
                    query = query.Where(b => b.HairColorCode != "D");
                }
                if (!this.Brown)
                {
                    query = query.Where(b => b.HairColorCode != "B");
                }
                if (!this.BrownRed)
                {
                    query = query.Where(b => b.HairColorCode != "A");
                }
                if (!this.Red)
                {
                    query = query.Where(b => b.HairColorCode != "R");
                }
                if (!this.UnknownColor)
                {
                    query = query.Where(b => b.HairColorCode != "U");
                    query = query.Where(b => b.HairColorCode != "");
                    query = query.Where(b => b.HairColorCode != null);
                }
            }


            //Gender
            if (this.Female || this.Male || this.UnknownGender)
            {
                if (!this.Female)
                {
                    query = query.Where(b => b.GenderCode != "F");
                }
                if (!this.Male)
                {
                    query = query.Where(b => b.GenderCode != "M");
                }
                if (!this.UnknownGender)
                {
                    query = query.Where(b => b.GenderCode != "U");
                    query = query.Where(b => b.GenderCode != "");
                    query = query.Where(b => b.GenderCode != null);

                }
            }

            //Age
            if (this.Adult || this.Child || this.Infant || this.Newborn || this.UnknownGender)
            {
                if (!this.Adult)
                {
                    query = query.Where(b => b.AgeCodeSingle != "A");
                }
                if (!this.Child)
                {
                    query = query.Where(b => b.AgeCodeSingle != "C");
                }
                if (!this.Infant)
                {
                    query = query.Where(b => b.AgeCodeSingle != "I");
                }
                if (!this.Newborn)
                {
                    query = query.Where(b => b.AgeCodeSingle != "N");
                }
                if (!this.UnknownAge)
                {
                    query = query.Where(b => b.AgeCodeSingle != "U");
                    query = query.Where(b => b.AgeCodeSingle != "");
                    query = query.Where(b => b.AgeCodeSingle != null);

                }
            }

            //Wrappings
            if (this.LittleBones || this.FullWrap || this.PartialWrap || this.UnknownWrap)
            {
                if (!this.LittleBones)
                {
                    query = query.Where(b => b.BurialWrappingCode != "B");
                }
                if (!this.FullWrap)
                {
                    query = query.Where(b => b.BurialWrappingCode != "W");
                }
                if (!this.PartialWrap)
                {
                    query = query.Where(b => b.BurialWrappingCode != "H");
                }
                if (!this.UnknownWrap)
                {
                    query = query.Where(b => b.BurialWrappingCode != "U");
                    query = query.Where(b => b.BurialWrappingCode != "");
                    query = query.Where(b => b.BurialWrappingCode != null);
                }
            }

            //Wrap Words this
            if (this.WrapWords != "" && this.WrapWords != null)
            {
                List<string> WrapList = this.WrapWords.Split(",").ToList();
                List<string> Burials = new List<string>();
                foreach (string word in WrapList)
                {
                    Burials.AddRange(Query.Where(b => b.OsteologyNotes.Contains(word)
                    || b.Column73.Contains(word)
                    || b.Column74.Contains(word)
                    || b.Column75.Contains(word)
                    || b.Column76.Contains(word)
                    || b.Column77.Contains(word)
                    || b.Column78.Contains(word)
                    || b.Column79.Contains(word)
                    || b.Column80.Contains(word)
                    || b.Column81.Contains(word)
                    || b.Column82.Contains(word)).Select(b => b.BurialId).ToList());
                }
                query = query.Where(b => Burials.Contains(b.BurialId));
            }

            //Items this
            if (this.NoItemsFound || this.ItemsFound)
            {
                if (!this.NoItemsFound)
                {
                    List<string> NIF = cranial.Where(b => b.BuriedWithArtifacts == true).Select(b => b.BurialId).ToList();
                    query = query.Where(b => NIF.Contains(b.BurialId));
                }
                if (!this.ItemsFound)
                {
                    List<string> IF = cranial.Where(b => b.BuriedWithArtifacts == false).Select(b => b.BurialId).ToList();

                    query = query.Where(b => IF.Contains(b.BurialId));
                }
            }

            //Items Words
            if (this.ItemWords != "" && this.ItemWords != null)
            {
                if (this.ItemWords.Contains(","))
                {
                    List<string> ItemList = this.ItemWords.Split(",").ToList();
                    List<string> burials = new List<string>();
                    foreach (string word in ItemList)
                    {
                        burials.AddRange(cranial.Where(b => b.BurialArtifactDescription.Contains(word)).Select(b => b.BurialId).ToList());
                    }
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else
                {
                    List<string> items =cranial.Where(b => b.BurialArtifactDescription.Contains(this.ItemWords)).Select(b => b.BurialId).ToList();
                    query = query.Where(b => items.Contains(b.BurialId));
                }
            }

            //Bone Length
            if(this.BoneSearch != "" && this.BoneSearch != null)
            {
                //if(this.BoneSearch == "Femur Length") {
                //    List<string> burials = new List<string>();
                //    burials.AddRange(cranial.Where(b => b.FemurLength <= this.BoneMax && b.FemurLength >= this.BoneMin).Select(b => b.BurialId).ToList());
                //    query = query.Where(b => burials.Contains(b.BurialId));
                //}
                //else if (this.BoneSearch == "Humerus Length")
                //{
                //    List<string> burials = new List<string>();
                //    burials.AddRange(cranial.Where(b => b.HumerusLength <= this.BoneMax && b.HumerusLength >= this.BoneMin).Select(b => b.BurialId).ToList());
                //    query = query.Where(b => burials.Contains(b.BurialId));
                //}
                //else if (this.BoneSearch == "Humerus Head Measurement")
                //{
                //    List<string> burials = new List<string>();
                //    burials.AddRange(cranial.Where(b => b.HumerusHead <= this.BoneMax && b.HumerusHead >= this.BoneMin).Select(b => b.BurialId).ToList());
                //    query = query.Where(b => burials.Contains(b.BurialId));
                //}
                //else if (this.BoneSearch == "Femur Head Measurement")
                //{
                //    List<string> burials = new List<string>();
                //    burials.AddRange(cranial.Where(b => b.FemurHead <= this.BoneMax && b.FemurHead >= this.BoneMin).Select(b => b.BurialId).ToList());
                //    query = query.Where(b => burials.Contains(b.BurialId));
                //}
                if (this.BoneSearch == "Cranial Length")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.MaximumCranialLength <= this.BoneMax && (decimal)b.MaximumCranialLength >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else if (this.BoneSearch == "Cranial Breadth")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.MaximumCranialBreadth <= this.BoneMax && (decimal)b.MaximumCranialBreadth >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else if (this.BoneSearch == "Basion Bregma Height")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.BasionBregmaHeight <= this.BoneMax && (decimal)b.BasionBregmaHeight >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else if (this.BoneSearch == "Basion Nasion")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.BasionNasion <= this.BoneMax && (decimal)b.BasionNasion >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else if (this.BoneSearch == "Basion Prosthion Length")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.BasionProsthionLength <= this.BoneMax && (decimal)b.BasionProsthionLength >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else if (this.BoneSearch == "Bizygomatic Diameter")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.BizygomaticDiameter <= this.BoneMax && (decimal)b.BizygomaticDiameter >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else if (this.BoneSearch == "Nasion Prosthion")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.NasionProsthion <= this.BoneMax && (decimal)b.NasionProsthion >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else if (this.BoneSearch == "Nasal Breadth")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.MaximumNasalBreadth <= this.BoneMax && (decimal)b.MaximumNasalBreadth >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
                else if (this.BoneSearch == "Interorbital Breadth")
                {
                    List<string> burials = new List<string>();
                    burials.AddRange(cranial.Where(b => (decimal)b.InterorbitalBreadth <= this.BoneMax && (decimal)b.InterorbitalBreadth >= this.BoneMin).Select(b => b.BurialId).ToList());
                    query = query.Where(b => burials.Contains(b.BurialId));
                }
            }

            return query;
        }

    }
}
