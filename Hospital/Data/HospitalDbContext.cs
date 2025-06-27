using System.Data;
using Microsoft.EntityFrameworkCore;
using Hospital.Entities;

namespace Hospital.Data
{
    public class HospitalDbContext: DbContext

    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> option) : base(option)
        {

        }
        public DbSet<Register> Registeres { get; set; }


        
    }
}
