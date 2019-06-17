using MusicBrainz.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.Domain.Repositories
{
    /// <summary>
    /// Artist Repository Interface
    /// </summary>
    public interface IArtistRepository
    {
        /// <summary>
        /// SearchArtistName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<Artist>> SearchArtistName(string name);
    }
}
