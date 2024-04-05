using INFT3000_A_Chinook.Models;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using INFT3000_A_Chinook.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using System.Diagnostics; // For Process.Start
using System; // For Uri and Exception

namespace INFT3000_A_Chinook.Pages
{
    public partial class Tracks : Page
    {
        private ChinookContext _context = new ChinookContext();
        private ObservableCollection<Track> _fullTrackList = new ObservableCollection<Track>();
        private CollectionViewSource tracksViewSource;

        public Tracks()
        {
            InitializeComponent();
            Loaded += Tracks_Loaded;
        }

        private void Tracks_Loaded(object sender, RoutedEventArgs e)
        {
            tracksViewSource = (CollectionViewSource)FindResource(nameof(tracksViewSource));
            // Eagerly include the album and artist data with each track
            _fullTrackList = new ObservableCollection<Track>(_context.Tracks
                .Include(t => t.Album)
                .ThenInclude(a => a.Artist)
                .ToList());
            tracksViewSource.Source = _fullTrackList;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterTracks((sender as TextBox).Text);
        }

        private void FilterTracks(string keyword)
        {
            if (_fullTrackList == null || tracksViewSource == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(keyword))
            {
                tracksViewSource.Source = _fullTrackList;
            }
            else
            {
                var filteredList = _fullTrackList.Where(t => t.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
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

        private void TrackDetail_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (sender is Border border && border.DataContext is Track track)
            {
                // Use the track's album artist for the search query if available
                string artistName = track.Album?.Artist?.Name ?? "Unknown Artist";
                string trackName = track.Name;

                string searchQuery = $"{artistName} {trackName}".Replace(" ", "+");
                string url = $"https://www.amazon.com/s?k={searchQuery}&i=digital-music&ref=nb_sb_noss_2";

                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to open the link: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
