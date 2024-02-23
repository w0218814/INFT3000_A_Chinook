using System;
using System.Collections.Generic;

namespace PROG2500_A2_Chinook.Models; //Now A3

public partial class MediaType
{
    public int MediaTypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
