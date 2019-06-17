using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.Resources
{
    /// <summary>
    /// Artist Resource Class
    /// </summary>
    public class ArtistResource
    {
        /// <summary>
        /// ArtistId
        /// </summary>
        public Guid ArtistId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
    }
}
