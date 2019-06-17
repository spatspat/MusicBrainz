using MusicBrainz.Api.Domain.Models;
using MusicBrainz.Api.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.Domain.Services
{
    /// <summary>
    /// Artist Service Interface
    /// </summary>
    public interface IArtistService
    {
        /// <summary>
        /// SearchArtists
        /// </summary>
        /// <param name="searchcriteria"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<SearchArtistResultDto> SearchArtists(string searchcriteria, int pageNumber, int pageSize);

        /// <summary>
        /// ArtistRelease
        /// </summary>
        /// <param name="artistid"></param>
        /// <param name="numberOfAlbum"></param>
        /// <returns></returns>
        SearchReleasesDto ArtistRelease(string artistid, int? numberOfAlbum);
    }
}
