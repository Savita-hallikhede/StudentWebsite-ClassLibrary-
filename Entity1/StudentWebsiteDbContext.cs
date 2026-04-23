
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entity1
{
    public class StudentWebsiteDbContext : DbContext
    {

        public StudentWebsiteDbContext(DbContextOptions<StudentWebsiteDbContext> options) : base(options)
        {

        }
        public DbSet<Clg> Clgs { get; set; }

        public DbSet<Std> Stds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //converting json file into the object file of clg 
            string DataofClg = System.IO.File.ReadAllText("clg.json");
            List<Clg> ClgOBJ = JsonSerializer.Deserialize<List<Clg>>(DataofClg);

            foreach (Clg clg in ClgOBJ)
            {
                modelBuilder.Entity<Clg>().HasData(clg);
            }

            // converting json file into the object file of std
            string DataofStd = System.IO.File.ReadAllText("stdrecord.json");
            List<Std> StudentOBJ = JsonSerializer.Deserialize<List<Std>>(DataofStd);

            foreach (Std std in StudentOBJ)
            {
                modelBuilder.Entity<Std>().HasData(std);
            }

        }





    }
}





