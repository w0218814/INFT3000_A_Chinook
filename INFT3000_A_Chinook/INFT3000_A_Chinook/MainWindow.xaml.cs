using System.Windows;
using System.Windows.Navigation;

namespace INFT3000_A_Chinook  
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Handler for window loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Navigate to Home Page on load
            mainFrame.NavigationService.Navigate(new Pages.Home());
        }

        // Navigation handlers demonstrate effective use of LINQ for page transitions

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Home());
        }

        private void ViewAlbums_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Albums());
        }

        private void ViewArtists_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Artists());
        }

        private void ViewTracks_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.Tracks());
        }

        private void ViewMusicCatalog_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.MusicCatalog());
        }

        private void ViewCustomerOrders_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new Pages.CustomerOrders());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
