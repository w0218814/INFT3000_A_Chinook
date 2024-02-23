using System;
using System.Collections.Generic;

namespace INFT3000_A_Chinook.Models;  

public partial class Playlist
{
    public int PlaylistId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
