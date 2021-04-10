using Mummies.Models.MummyDb;
using Mummies.Models.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummies.Models.ViewModels
{
    //New class that allows view to recieve both book information and page info
    public class SearchDatabaseViewModel
    {
        public IEnumerable<FagElGamousDatabaseByLocation> Burials { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public SearchInfo? CurrentSearch { get; set; }
        public string Query { get; set; }

    }
}
