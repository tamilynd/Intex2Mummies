using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummies.Models.MummyDb
{
    public class EFMummyRepository : IMummyRepository
    {
        private MummyDbContext _context;

        public EFMummyRepository(MummyDbContext context)
        {
            _context = context;
        }

        public IQueryable<BiologicalSamples> BiologicalSamples => _context.BiologicalSamples;
        public IQueryable<ByuFagElGamousDb> ByuFagElGamous => _context.ByuFagElGamousDb;
        public IQueryable<C14Data> C14Data => _context.C14Data;
        public IQueryable<Cranial2002> Cranial2002 => _context.Cranial2002;
        public IQueryable<FagElGamousDatabaseByLocation> FagElGamousDatabaseByLocation => _context.FagElGamousDatabaseByLocation;
        public IQueryable<Oraclespread> OracleSpread => _context.Oraclespread;
    }
}
