using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicBrainz.Api.Domain.Models;
using MusicBrainz.Api.Domain.Services;
using MusicBrainz.Api.DTO;
using MusicBrainz.Api.Resources;

namespace MusicBrainz.Api.Controllers
{
    /// <summary>
    /// Artist Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;

        /// <summary>
        /// Artist Controller Constructor
        /// </summary>
        /// <param name="artistService"></param>
        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }


        /// <summary>
        /// Search
        /// </summary>
        /// <param name="search_criteria"></param>
        /// <param name="page_number"></param>
        /// <param name="page_size"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("search/{search_criteria}/{page_number}/{page_size}")]
        public async Task<IActionResult> Search(string search_criteria, int? page_number, int? page_size)
        {
            //If page number of page size is null then use default value
            var currentPageNumber = page_number ?? 1;
            var currentPageSize = page_size ?? 5;

            if (string.IsNullOrEmpty(search_criteria))
            {
                return BadRequest("Please provide search criteria value...");

            }

            var result = await _artistService.SearchArtists(search_criteria, currentPageNumber,currentPageSize);

            if (result.results.Count() <= 0)
            {
                return NotFound("No records found...");
            }

            return Ok(result);
        }


        /// <summary>
        /// Releases
        /// </summary>
        /// <param name="artistid"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{artistid}/releases")]
        public IActionResult Releases(string artistid)
        {
            if (string.IsNullOrEmpty(artistid))
            {
                return BadRequest("Please provide artist id value...");
            }
            //else
            //{
            //    bool successfullyParsed = Guid.TryParse(artistid, out _);
            //    if (successfullyParsed == false)
            //    {
            //        return BadRequest("Please provide valid Guid artist id...");
            //    }

            //}

            var result = _artistService.ArtistRelease(artistid, null);



            if (result.releases.Count <= 0)
            {
                return NotFound("No records found...");
            }

            return Ok(result);


        }

        /// <summary>
        /// GetFirstTenAlbum
        /// </summary>
        /// <param name="artistid"></param>
        /// <param name="numberOfAlbum"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{artistid}/albums")]
        public IActionResult GetFirstTenAlbum(string artistid, int? numberOfAlbum = 10)
        {

            if (string.IsNullOrEmpty(artistid))
            {
                return BadRequest("Please provide artist id value...");
            }
            else
            {
                bool successfullyParsed = Guid.TryParse(artistid, out _);
                if (successfullyParsed == false)
                {
                    return BadRequest("Please provide valid Guid artist id...");
                }

            }

            var result = _artistService.ArtistRelease(artistid, numberOfAlbum);


            if (result.releases.Count <= 0)
            {
                return NotFound("No records found...");
            }

            return Ok(result);
        }
    }
}