using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Data;
using MyWebAPI.Services;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyWebAPI.Controllers;

[ApiController]
public class HomePageController:ControllerBase
{
    private readonly HomePageService _homePageService;

    public HomePageController(HomePageService homePageService){
        _homePageService=homePageService;
    }
    [HttpGet]
    [Route("api/[Controller]/SearchLocation")]
    public List<City> GetLocation(string SearchLocation="hi"){
        var location = _homePageService.GetLocation(SearchLocation);
         return location;
    }

    [HttpGet]
    [Route("api/[Controller]/GetTurfDetails")]
    public List<Turf> GetTurfDetails(){
        List<Turf> turfDetails=_homePageService.GetTurfDetails();
        return turfDetails;

    }


}

