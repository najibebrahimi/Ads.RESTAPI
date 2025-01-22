using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Ads.RESTAPI.Models;

public class AdContext : DbContext
{
    public AdContext(DbContextOptions<AdContext> options)
    : base(options)
    {
    }

    public DbSet<Ad> Ads { get; set; } = null!;
}
