using AutoMapper;
using MusicBrainz.Api.Domain.Models;
using MusicBrainz.Api.DTO;
using MusicBrainz.Api.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBrainz.Api.Mapping
{
    /// <summary>
    /// ModelToResourceProfile Class
    /// </summary>
    public class ModelToResourceProfile : Profile
    {
        /// <summary>
        /// ModelToResourceProfile - Mapping
        /// </summary>
        public ModelToResourceProfile()
        {
            CreateMap<Artist, ArtistResource>();

            CreateMap<Artist, ArtistDto>()
               .ForMember(src => src.name, opt => opt.MapFrom(src => src.Name))
               .ForMember(src => src.alias,
                           opts => opts.MapFrom(
                               r => r.Aliases
                               .Where(y => !string.IsNullOrEmpty(y.ToString().Trim()))
                               .Select(x => x.Name.Trim()).ToArray()));

        }
    }
}
