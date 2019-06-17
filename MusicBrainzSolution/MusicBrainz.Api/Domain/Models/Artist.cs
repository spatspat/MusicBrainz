using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.Domain.Models
{
    /// <summary>
    /// Artist Class
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// ArtistId
        /// </summary>
        public Guid ArtistId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// LinkToAlbum
        /// </summary>
        [NotMapped]
        public string LinkToAlbum { get; set; }

        /// <summary>
        /// Aliases
        /// </summary>
        public virtual ICollection<Aliase> Aliases { get; set; }
    }
}
