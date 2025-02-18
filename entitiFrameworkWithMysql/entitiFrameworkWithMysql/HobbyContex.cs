using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitiFrameworkWithMysql.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace entitiFrameworkWithMysql
{
    internal class HobbyContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=book;user=root;password=113119Ii",
                    new MySqlServerVersion(new Version(8, 0, 30)));
            }
        }
        public HobbyContex(DbContextOptions<HobbyContex> options)
            : base(options) { }
        public HobbyContex() { }
       
        public virtual DbSet<Hobby> Hobby {  get; set; }

    }
}
