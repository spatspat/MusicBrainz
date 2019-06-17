using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MusicBrainz.Api.Domain.Models;
using MusicBrainz.Api.Domain.Repositories;
using MusicBrainz.Api.Domain.Services;
using MusicBrainz.Api.DTO;

namespace MusicBrainz.Api.Services
{
    /// <summary>
    /// Artist Service
    /// </summary>
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Artist Service Constructor
        /// </summary>
        /// <param name="artistRepository"></param>
        /// <param name="mapper"></param>
        public ArtistService(IArtistRepository artistRepository, IMapper mapper)
        {
            this._artistRepository = artistRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// SearchArtists
        /// </summary>
        /// <param name="searchcriteria"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public async Task<SearchArtistResultDto> SearchArtists(string searchcriteria, int pageNumber, int pageSize)
        {

            var allArtist = await _artistRepository.SearchArtistName(searchcriteria);

            var Pagination = allArtist.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            var lstArtistDTO = _mapper.Map<IEnumerable<Artist>, IEnumerable<ArtistDto>>(Pagination);

            SearchArtistResultDto result = new SearchArtistResultDto()
            {
                results = lstArtistDTO.ToList(),
                numberOfSearchResults = allArtist.Count(),
                page = pageNumber,
                pageSize = pageSize,
                numberOfPages = (int)Math.Ceiling(allArtist.Count() / (double)pageSize)
            };

            return result;
        }

        /// <summary>
        /// ArtistRelease
        /// </summary>
        /// <param name="artistid"></param>
        /// <param name="numberOfAlbum"></param>
        /// <returns></returns>
        public SearchReleasesDto ArtistRelease(string artistid, int? numberOfAlbum)
        {
            MusicBrainz.Data.Release MBrainzobj;

            int numAlbum = numberOfAlbum ?? 0;
            if (numAlbum != 0)
            {
                MBrainzobj = MusicBrainz.Search.Release(arid: artistid, limit: numAlbum);
            }
            else
            {
                MBrainzobj = MusicBrainz.Search.Release(arid: artistid);
            }
            

            List<ReleaseDto> lstRelease = new List<ReleaseDto>();

            if (MBrainzobj != null)
            {
                // Fill up a list of the releaseDTO which contains all the required release information.
                foreach (MusicBrainz.Data.ReleaseData objMusicBrainzRelease in MBrainzobj.Data)
                {
                    lstRelease.Add(new ReleaseDto()
                    {
                        releaseID = objMusicBrainzRelease.Id,
                        title = objMusicBrainzRelease.Title,
                        status = objMusicBrainzRelease.Status,
                        label = objMusicBrainzRelease.Labelinfolist.Count > 0 ?
                                objMusicBrainzRelease.Labelinfolist.First().Label.Name : null,
                        numberOfTracks = objMusicBrainzRelease.Mediumlist.Trackcount,
                        otherArtists = objMusicBrainzRelease.Artistcredit
                                         .Select(r => new ReleaseDto.clsArtist()
                                         { id = r.Artist.Id, name = r.Artist.Name }).ToList()

                    });
                }
            }

            SearchReleasesDto result = new SearchReleasesDto()
            {
               releases = lstRelease.ToList()
            };

            return result;
        }
    }
}
