using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.Domain.Models
{
    /// <summary>
    /// Alias Class
    /// </summary>
    public class Aliase
    {
        /// <summary>
        /// AliaseId
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AliaseId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Artist
        /// </summary>
        public Artist Artist { get; set; }
    }
}
