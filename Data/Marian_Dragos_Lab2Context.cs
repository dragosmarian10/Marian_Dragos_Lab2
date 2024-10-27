using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marian_Dragos_Lab2.Models;

namespace Marian_Dragos_Lab2.Data
{
    public class Marian_Dragos_Lab2Context : DbContext
    {
        public Marian_Dragos_Lab2Context (DbContextOptions<Marian_Dragos_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Marian_Dragos_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Marian_Dragos_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
