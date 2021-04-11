using System;
using System.Collections.Generic;
using Mummies.Models.MummyDb;

namespace Mummies.Models.ViewModels.Researcher
{
    public class NewMummyViewModel
    {
        public List<ByuFagElGamousDb> MainDb { get; set; }

        public string location { get; set; }

        public List<FagElGamousDatabaseByLocation> LocationDb { get; set; }
    }
}
