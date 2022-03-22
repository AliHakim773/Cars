using Microsoft.EntityFrameWorkCore;

namespace Cars.Models;

public class CarsContext : DbContext
{
  public CarsContext(DbContextOptions<CarsContext> options) : base(options) { }

  public Dbset<Car> Cars { get; set; }

}