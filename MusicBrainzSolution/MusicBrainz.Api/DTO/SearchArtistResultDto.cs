using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.DTO
{
    /// <summary>
    /// Search Artist Result Data Transfer Object 
    /// </summary>
    public class SearchArtistResultDto
    {
        /// <summary>
        /// results
        /// </summary>
        public List<ArtistDto> results { get; set; }

        /// <summary>
        /// numberOfSearchResults
        /// </summary>
        public int numberOfSearchResults { get; set; }

        /// <summary>
        /// page
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// numberOfPages
        /// </summary>
        public int numberOfPages { get; set; }

    }
}
