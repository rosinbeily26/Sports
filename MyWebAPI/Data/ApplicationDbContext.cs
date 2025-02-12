using Microsoft.EntityFrameworkCore;

namespace MyWebAPI.Data;

public class ApplicationDbContext:DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
    public DbSet<City> tamil_nadu_cities_talukas { get; set; }    
    public DbSet<Turf> Turf { get; set; }    

}