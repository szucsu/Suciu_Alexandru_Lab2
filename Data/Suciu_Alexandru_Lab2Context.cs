using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Suciu_Alexandru_Lab2.Models;

namespace Suciu_Alexandru_Lab2.Data
{
    public class Suciu_Alexandru_Lab2Context : DbContext
    {
        public Suciu_Alexandru_Lab2Context (DbContextOptions<Suciu_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Suciu_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Suciu_Alexandru_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Suciu_Alexandru_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Suciu_Alexandru_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
