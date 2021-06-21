using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<tootaja> tootaja { get; set; }
        public DbSet<tootajaLaps> tootajaLaps { get; set; }
        public DbSet<harukontor> harukontor { get; set; }
        public DbSet<vihjed> vihjed { get; set; }
        public DbSet<palved> palved { get; set; }
        public DbSet<tervisekontrollid> tervisekontrollid { get; set; }
        public DbSet<puhkused> puhkused { get; set; }
        public DbSet<puhkuseTyyp> puhkuseTyyp{ get; set; }
        public DbSet<haiguslehed> haiguslehed { get; set; }
        public DbSet<toosuhe> toosuhe { get; set; }
        public DbSet<ametinimetused> ametinimetused { get; set; }
        public DbSet<ligipaasuluba> ligipaasuluba { get; set; }
        public DbSet<ligipaasuloaTyyp> ligipaasuloaTyyp { get; set; }
        public DbSet<laenutuskord> laenutukord { get; set; }
        public DbSet<laenutatavEse> laenutatavEse { get; set; }
    }
}
