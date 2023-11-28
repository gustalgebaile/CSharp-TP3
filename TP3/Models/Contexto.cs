using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TP3.Models;

namespace TP3.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<TP3.Models.Livro> Livro { get; set; } = default!;
        public DbSet<TP3.Models.Time> Time { get; set; } = default!;

    }
}
