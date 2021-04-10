using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummies.Models.MummyDb
{
    public interface IMummyRepository
    {
        IQueryable<BiologicalSamples> BiologicalSamples { get; }
        IQueryable<ByuFagElGamousDb> ByuFagElGamous { get; }
        IQueryable<C14Data> C14Data { get; }
        IQueryable<Cranial2002> Cranial2002 { get; }
        IQueryable<FagElGamousDatabaseByLocation> FagElGamousDatabaseByLocation { get; }
        IQueryable<Oraclespread> OracleSpread { get; }
    }
}
