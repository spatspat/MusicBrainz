using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.DTO
{
    /// <summary>
    /// Search Release Data Transfer Object
    /// </summary>
    public class SearchReleasesDto
    {
        /// <summary>
        /// releases
        /// </summary>
        public List<ReleaseDto> releases { get; set; }
    }
}
