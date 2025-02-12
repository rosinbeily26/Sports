using System.Collections;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Data;

namespace MyWebAPI.Services;

public class HomePageService
{
        private readonly ApplicationDbContext _context;
        public HomePageService(ApplicationDbContext context)
        {
            _context=context;
        }

    public List<City> GetLocation(string searchLocation){
        var location=_context.tamil_nadu_cities_talukas.ToList();
        return location;
    }
    public List<Turf> GetTurfDetails(){
        var turfDetails=_context.Turf.ToList();
        return turfDetails;
    }

    
}

