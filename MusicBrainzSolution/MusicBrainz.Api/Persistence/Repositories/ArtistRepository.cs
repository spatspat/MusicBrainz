using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicBrainz.Api.Domain.Models;
using MusicBrainz.Api.Domain.Repositories;
using MusicBrainz.Api.Persistence.Contexts;

namespace MusicBrainz.Api.Persistence.Repositories
{
    /// <summary>
    /// Artist Repository Class
    /// </summary>
    public class ArtistRepository : BaseRepository,IArtistRepository
    {
        /// <summary>
        /// Artist Repository Constructor
        /// </summary>
        /// <param name="context"></param>
        public ArtistRepository(MBDbContext context) : base(context)
        {
        }

        /// <summary>
        /// SearchArtistName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Artist>> SearchArtistName(string name)
        {
            var Artistname = await _mBDbContext.Artists
                .Include(p => p.Aliases)
                .Where(a => a.Name.Trim().StartsWith(name) || a.Name.Contains(name))
                .OrderBy(a => a.Name)
                .ToListAsync();

            return  Artistname;
        }

    }
}
