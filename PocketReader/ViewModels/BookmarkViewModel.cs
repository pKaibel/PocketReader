using Newtonsoft.Json;
using PocketReader.Models;

namespace PocketReader.ViewModels
{
    //
    //  ViewModel für die Bookmark-Seite
    //  Pocket Reader App
    //
    //  Created by Philipp Kaibel on 22.05.25.
    //

    public class BookmarkViewModel : BindableObject
    {
        private List<Bookmark> bookmarks;

        // Constructor für die BookmarkViewModel-Klasse
        public BookmarkViewModel()
        {
            bookmarks = new List<Bookmark>();
            // Verwenden Sie den "await"-Operator, um sicherzustellen,
            // dass die Methode auf die Fertigstellung von LoadBookmarksAsync wartet.
            LoadBookmarksAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        //  Getter / Setter for the bookmark list
        public List<Bookmark> Bookmarks
        {
            get { return bookmarks; } // get: just return the current value of list
            set
            {
                bookmarks = value;

                // OnPropertyChanged:
                // Man kann hier den Namen des Aufrufers hinzufügen,
                // wenn man mehrere Change-Events behandeln will
                // Hier reicht der Aufruf ohne Namen.
                // OnPropertyChanged(nameof(Bookmarks));

                OnPropertyChanged(); // Notify the UI that the Bookmarks property has changed
            }
        }

        // Liste der Bookmarks aus der JSON-Datei deserialisieren
        private async Task LoadBookmarksAsync()
        {
            try
            {
                using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("data.json");
                using var reader = new StreamReader(fileStream);
                // string content = await reader.ReadToEndAsync();

                string content = reader.ReadToEnd(); // Synchron funktioniert zuverlässig

                var loadedBookmarks = JsonConvert.DeserializeObject<List<Bookmark>>(content);

                if (loadedBookmarks != null)
                    bookmarks = loadedBookmarks;

                // Prüfe ob content leer ist
                if (string.IsNullOrEmpty(content))
                {
                    System.Diagnostics.Debug.WriteLine("Datei ist leer!");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Inhalt: {content}");
                }

            }
            catch (Exception ex)
            {
                // Fehlerbehandlung (z.B. Logging)
                Console.WriteLine($"Error loading bookmarks: {ex.Message}");

            }
        }
    }
}
