using Microsoft.EntityFrameworkCore;
using MusicBrainz.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.Persistence.Contexts
{
    /// <summary>
    /// Database Context
    /// </summary>
    public class MBDbContext : DbContext
    {
        /// <summary>
        /// Table Artists
        /// </summary>
        public DbSet<Artist> Artists { get; set; }

        /// <summary>
        /// Table Aliases
        /// </summary>
        public DbSet<Aliase> Aliases { get; set; }

        /// <summary>
        /// Context constructor
        /// </summary>
        /// <param name="options"></param>
        public MBDbContext(DbContextOptions<MBDbContext> options) : base(options)
        {

        }
    }
}
