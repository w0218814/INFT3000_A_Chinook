using Microsoft.EntityFrameworkCore;
using INFT3000_A_Chinook.Data;
using INFT3000_A_Chinook.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace INFT3000_A_Chinook.Pages // Now A3
{
    public partial class Artists : Page
    {
        private ChinookContext _context = new ChinookContext();
        private CollectionViewSource artistsViewSource;
        private ObservableCollection<Artist> _fullArtistList;

        public Artists()
        {
            InitializeComponent();
            artistsViewSource = (CollectionViewSource)FindResource(nameof(artistsViewSource));
            _context.Artists.Load();
            _fullArtistList = _context.Artists.Local.ToObservableCollection();

            // Initialize the data source with the full list of artists
            FilterArtists(string.Empty);
        }

        // Search enhancements: Filter artists by name using LINQ - meets requirement
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterArtists(SearchTextBox.Text);
        }

        // Search enhancements: Filter artists by name using LINQ - meets requirement
        private void FilterArtists(string searchTerm)
        {
            if (_fullArtistList == null) return;

            searchTerm = searchTerm?.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                artistsViewSource.Source = _fullArtistList;
            }
            else
            {
                var filteredList = _fullArtistList
                    .Where(artist => artist.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                artistsViewSource.Source = new ObservableCollection<Artist>(filteredList);
            }
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Search by artist name...")
            {
                SearchTextBox.Text = string.Empty;

                // Refresh the data source with the full list of artists
                FilterArtists(string.Empty);
            }
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Search by artist name...";
            }
        }
    }
}
