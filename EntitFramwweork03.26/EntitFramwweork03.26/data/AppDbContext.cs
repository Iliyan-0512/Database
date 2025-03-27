using EntitFramwweork03._26.Model;
using Microsoft.EntityFrameworkCore;

namespace EntitFramwweork03._26.data
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Thesis> Theses {  get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=C:\\iliyan\\proggraming\\SQL\\EntitFramwweork03.26\\EntitFramwweork03.26\\thesis.db");
                //.LogTo(Console.WriteLine,LogLevel.Information);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
