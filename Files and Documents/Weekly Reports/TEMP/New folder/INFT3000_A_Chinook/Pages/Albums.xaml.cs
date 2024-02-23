using Microsoft.EntityFrameworkCore;
using PROG2500_A2_Chinook.Data;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using PROG2500_A2_Chinook.Models;
using System;

namespace PROG2500_A2_Chinook.Pages // Now A3
{
    public partial class Albums : Page
    {
        private ChinookContext _context = new ChinookContext();
        private CollectionViewSource albumsViewSource;
        private ObservableCollection<Album> _fullAlbumList;

        public Albums()
        {
            InitializeComponent();

            albumsViewSource = (CollectionViewSource)FindResource(nameof(albumsViewSource));

            LoadAlbumsData();
        }

        private void LoadAlbumsData()
        {
            // Ensure that we catch any exceptions that might occur during data loading
            try
            {
                _context.Albums.Include(a => a.Artist).Load();
                _fullAlbumList = _context.Albums.Local.ToObservableCollection();
                albumsViewSource.Source = _fullAlbumList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading albums: {ex.Message}");
            }
        }

        // Search enhancements: Filter albums by title using LINQ - meets requirement
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Ensure the control is initialized before using it
            if (albumsViewSource != null)
            {
                FilterAlbums(SearchTextBox.Text);
            }
        }

        // Search enhancements: Filter albums by title using LINQ - meets requirement
        private void FilterAlbums(string searchTerm)
        {
            if (_fullAlbumList == null) return;

            searchTerm = searchTerm?.Trim();

            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "Search by album title...")
            {
                albumsViewSource.Source = _fullAlbumList;
            }
            else
            {
                albumsViewSource.Source = _fullAlbumList.Where(a => a.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            }
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "Search by album title...")
            {
                SearchTextBox.Text = string.Empty;
            }
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                SearchTextBox.Text = "Search by album title...";
            }
        }
    }
}
