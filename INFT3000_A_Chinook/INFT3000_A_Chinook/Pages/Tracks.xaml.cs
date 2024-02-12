using INFT3000_A_Chinook.Models;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using INFT3000_A_Chinook.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;

namespace INFT3000_A_Chinook.Pages //Now A3
{
    public partial class Tracks : Page
    {
        ChinookContext _context = new ChinookContext();
        ObservableCollection<Track> _fullTrackList;
        CollectionViewSource tracksViewSource;

        public Tracks()
        {
            InitializeComponent();
            Loaded += Tracks_Loaded;
        }

        private void Tracks_Loaded(object sender, RoutedEventArgs e)
        {
            tracksViewSource = (CollectionViewSource)FindResource(nameof(tracksViewSource));
            // Ensure _fullTrackList is initialized before using it
            _fullTrackList = new ObservableCollection<Track>(_context.Tracks.ToList());
            tracksViewSource.Source = _fullTrackList;
        }

        // Search enhancements: Filter tracks by keywords - meets requirement
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterTracks((sender as TextBox).Text);
        }

        // Search enhancements: Filter tracks by keywords - meets requirement
        private void FilterTracks(string keyword)
        {
            // Check if _fullTrackList is not null before applying the filter
            if (_fullTrackList == null)
            {
                return; // Optionally, handle the situation when _fullTrackList is null
            }

            if (string.IsNullOrWhiteSpace(keyword))
            {
                tracksViewSource.Source = _fullTrackList;
            }
            else
            {
                var filteredList = _fullTrackList.Where(t => t.Name.Contains(keyword)).ToList();
                tracksViewSource.Source = new ObservableCollection<Track>(filteredList);
            }
        }

        private void TrackSearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Search by track name...")
            {
                textBox.Text = "";
            }
        }

        private void TrackSearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Search by track name...";
            }
        }
    }
}
