using MusicBrainz.Api.Domain.Models;
using MusicBrainz.Api.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MetaBrainz.MusicBrainz.Interfaces.Entities;
using MusicBrainz.Api.DTO;

namespace MusicBrainz.Api.Test
{
    public class ArtistServiceFake : IArtistService
    {
        private readonly List<Artist> _artist;

        public ArtistServiceFake()
        {
            _artist = new List<Artist>()
            {
                new Artist(){ArtistId=new Guid("6456A893-C1E9-4E3D-86F7-0008B0A3AC8A"),Name="Jack Johnson",Country="US"},
                new Artist(){ArtistId=new Guid("144EF525-85E9-40C3-8335-02C32D0861F3"),Name="John Mayer",Country="US"},
                new Artist(){ArtistId=new Guid("B625448E-BF4A-41C3-A421-72AD46CDB831"),Name="John Coltrane",Country="US"},
            };
        }

        public readonly Task<SearchArtistResultDto> _searchArtistResults;
        public readonly SearchReleasesDto _searchReleasesDto;

        public Task<SearchArtistResultDto> SearchArtists(string searchcriteria, int pageNumber, int pageSize)
        {
            return _searchArtistResults;
        }

        public SearchReleasesDto ArtistRelease(string artistid, int? numberOfAlbum)
        {
            return _searchReleasesDto;
        }

    }
}
