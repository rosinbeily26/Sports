using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class City{
    [Key]
    public  int City_id { get; set; }
    public required string City_name { get; set; }
    public required string District_name { get; set; }
    public required string taluka_name { get; set; }

    

}
