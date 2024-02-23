using System;
using System.Collections.Generic;

namespace PROG2500_A2_Chinook.Models; //Now A3

public partial class Genre
{
    public int GenreId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
