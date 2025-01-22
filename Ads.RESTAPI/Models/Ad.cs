﻿namespace Ads.RESTAPI.Models;

public class Ad
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public decimal? Price { get; set; }
    public string? Category { get; set; }

}
