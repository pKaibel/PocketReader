using PocketReader.Models;
using PocketReader.Views;

namespace PocketReader
{
    public partial class MainPage : ContentPage
    {
        // Constructor for the MainPage class
        public MainPage()
        {
            InitializeComponent();
        }

        // Auf die Auswahl eines Listenelements reagieren
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedItem = e.SelectedItem as Bookmark;

            // Navigation zur Detail-Seite
            var bookmarkPage = new BookmarkViewPage(selectedItem);
            await Navigation.PushAsync(bookmarkPage);

            // Selection zurücksetzen
            ((ListView)sender).SelectedItem = null;
        }

        // Auf das Hinzufügen eines neuen Bookmarks reagieren
        private void OnItemAdded(object sender, EventArgs e)
        {
            
        }
    }
}
