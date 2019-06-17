using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.DTO
{
    /// <summary>
    /// Artist Data Transfer Object
    /// </summary>
    public class ArtistDto
    {
        /// <summary>
        /// name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// country
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// alias
        /// </summary>
        public string[] alias { get; set; }

        /// <summary>
        /// linkToArtistAlbums
        /// </summary>
        public string[] linkToArtistAlbums { get; set; }
    }
}
