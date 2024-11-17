using CodeFirstBasicApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CodeFirstBasicApi.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {
        }

        DbSet<GameEntity> Games => Set<GameEntity>();
        DbSet<MovieEntity> Movies => Set<MovieEntity>();
    }
}