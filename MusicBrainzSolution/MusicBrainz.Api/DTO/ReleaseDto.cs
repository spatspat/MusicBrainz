using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.DTO
{
    /// <summary>
    /// Release Data Transfer Object
    /// </summary>
    public class ReleaseDto
    {
        /// <summary>
        /// releaseID
        /// </summary>
        public string releaseID { get; set; }

        /// <summary>
        /// title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// label
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// numberOfTracks
        /// </summary>
        public int numberOfTracks { get; set; }

        /// <summary>
        /// otherArtists
        /// </summary>
        public List<clsArtist> otherArtists { get; set; }

        /// <summary>
        /// clsArtist
        /// </summary>
        public class clsArtist
        {
            /// <summary>
            /// id
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// name
            /// </summary>
            public string name { get; set; }
        }
    }
}
