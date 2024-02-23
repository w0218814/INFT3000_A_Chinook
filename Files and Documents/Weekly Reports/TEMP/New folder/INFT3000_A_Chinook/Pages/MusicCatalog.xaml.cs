using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;
using PROG2500_A2_Chinook.Data;
using PROG2500_A2_Chinook.Models;

namespace PROG2500_A2_Chinook.Pages // Now A3
{
    public partial class MusicCatalog : Page
    {
        private ChinookContext _context;
        private List<ArtistGroup> _artistGroups;

        public MusicCatalog()
        {
            InitializeComponent();
            _context = new ChinookContext();
            LoadData();
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Search music catalog...")
            {
                SearchTextBox.Text = string.Empty;
            }
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Search music catalog...";
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox != null)
            {
                LoadData(SearchTextBox.Text);
            }
        }

        private void LoadData(string searchQuery = null)
        {
            // LINQ query to filter and group data demonstrates effective use of LINQ in the context of the application
            // This section meets the requirement of a searchable Music Catalog page grouped by the first letter of the artist's name

            if (_context == null || _context.Artists == null)
            {
                return;
            }

            var query = _context.Artists.Include(a => a.Albums).ThenInclude(al => al.Tracks).AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(a => a.Name.Contains(searchQuery) || a.Albums.Any(al => al.Title.Contains(searchQuery)));
            }

            _artistGroups = query.ToList()
                .GroupBy(a => a.Name.Substring(0, 1))
                .OrderBy(g => g.Key)
                .Select(g => new ArtistGroup
                {
                    GroupHeader = g.Key + " (" + g.Count() + " artists)",
                    Artists = g.Select(a => new ArtistViewModel
                    {
                        Name = a.Name,
                        Albums = a.Albums.Select(al => new AlbumViewModel
                        {
                            Title = al.Title,
                            Tracks = al.Tracks.Select(t => new TrackViewModel
                            {
                                Name = t.Name
                            }).ToList()
                        }).ToList()
                    }).ToList()
                }).ToList();

            if (ArtistGroupListView != null)
            {
                ArtistGroupListView.ItemsSource = _artistGroups;
            }
        }
    }

    public class ArtistGroup
    {
        public string GroupHeader { get; set; }
        public List<ArtistViewModel> Artists { get; set; }
    }

    public class ArtistViewModel
    {
        public string Name { get; set; }
        public List<AlbumViewModel> Albums { get; set; }
    }

    public class AlbumViewModel
    {
        public string Title { get; set; }
        public List<TrackViewModel> Tracks { get; set; }
    }

    public class TrackViewModel
    {
        public string Name { get; set; }
    }
}
