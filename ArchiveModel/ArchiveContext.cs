using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveModel
{
    public class ArchiveContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Archive> Archives { get; set; }

        public string DbPath { get; }

        public ArchiveContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            Directory.CreateDirectory(path + @"\MyArchive");
            DbPath = System.IO.Path.Join(path + @"\MyArchive", "archive.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();
        }
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
