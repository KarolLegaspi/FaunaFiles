using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaunaFiles.DataModel
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=MSI\\SQLEXPRESS;Database=FaunaFiles;Integrated Security=SSPI;TrustServerCertificate=true");
            }
        }

        public DbSet<Pet> Pets { get; set; } 
        public DbSet<PetOwner> PetOwners { get; set; }
        public DbSet<Vet> Vet { get; set; }
    }
}
