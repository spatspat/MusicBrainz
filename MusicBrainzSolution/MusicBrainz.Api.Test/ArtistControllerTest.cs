using MusicBrainz.Api.Controllers;
using MusicBrainz.Api.Domain.Services;
using Xunit;
using MusicBrainz.Api.Services;
using MusicBrainz.Api.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MusicBrainz.Api.DTO;
using System.Linq;

namespace MusicBrainz.Api.Test
{
    public class ArtistControllerTest
    {
        IArtistService _artistService;
        IArtistRepository _artistRepository;
        IMapper _mapper;
        ArtistController _controller;

        public ArtistControllerTest()
        {
            _artistService = new ArtistService(_artistRepository, _mapper);
            _controller = new ArtistController(_artistService);
        }


        [Fact]
        public void Releases()
        {
            // Arrange


            // Act
            IActionResult actionResult = _controller.Releases("c44e9c22-ef82-4a77-9bcd-af6c958446d6");

            //Assert

            OkObjectResult result = actionResult as OkObjectResult;
            //Assert.NotNull(actionResult);
            Assert.NotNull(result);
            //Assert.Equal(25, (result.Value as SearchReleasesDto).releases.Count);
        }


        [Fact]
        public void ReleasebyTenAlbum()
        {
            // Arrange
            // Act
            IActionResult actionResult = _controller.GetFirstTenAlbum("c44e9c22-ef82-4a77-9bcd-af6c958446d6");
            // Assert
            OkObjectResult result = actionResult as OkObjectResult;
            Assert.NotNull(result);
            Assert.Equal(10, (result.Value as SearchReleasesDto).releases.Count);
        }


        //[Fact]
        //public async Task SearchGet()
        //{
        //    // Arrange
        //    //var controller = new ArtistController();

        //    // Act
        //    IActionResult actionResult = await _controller.Search("joh",1,2);
        //    var x = await _artistService.SearchArtists("joh", 1, 2);
        //    // Assert
        //    Assert.NotNull(actionResult);

        //    OkObjectResult result = actionResult as OkObjectResult;

        //    Assert.NotNull(result);

        //    List<string> messages = result.Value as List<string>;

        //    Assert.Equal(2, messages.Count);
        //    Assert.Equal("value1", messages[0]);
        //    Assert.Equal("value2", messages[1]);
        //}


        //ArtistController _controller;
        //IArtistService _artistService;
        //IArtistRepository _artistRepository;
        //IMapper _mapper;

        //public ArtistControllerTest()
        //{
        //    _artistService = new ArtistService(_artistRepository, _mapper);
        //    _controller = new ArtistController(_artistService);
        //}

        //[Fact]
        //public void Get_WhenCalled_ReturnsOkResult()
        //{
        //    //Arrange
        //    var searchcriteria = "joh";
        //    int? pagenumber = 1;
        //    int? pagesize = 1;
        //    // Act


        //    //var service = new Mock<IArtistService>();
        //    IActionResult result = _controller.Search(searchcriteria, pagenumber, pagesize).Result;

        //    var okObjectResult = result as OkObjectResult;


        //    //var items = Assert.IsType<Task<IActionResult>>(okResult);

        //    // Assert
        //    Assert.NotNull(okObjectResult);
        //    //var response = okResult as OkNegotiatedContentResult<SearchArtistResultDto>;

        //    //Assert.IsType<OkObjectResult>(okResult.Result);
        //    //Assert.Equal(3, items.Count);
        //}

        //[Fact]
        //public void SearchTest()
        //{
        //    // Arrange
        //    // Act
        //    // Assert

        //}
    }
}
