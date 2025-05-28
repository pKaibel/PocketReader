using PocketReader.Models;

namespace PocketReader.Views;

public partial class BookmarkViewPage : ContentPage
{
	private Bookmark bookmark;

    // Default constructor initializes a new Bookmark instance
    public BookmarkViewPage()
	{
		InitializeComponent();
		bookmark = new Bookmark(); // Initialize a new Bookmark instance
		BindingContext = bookmark; // Set the BindingContext to the bookmark instance
    }

    // Constructor that accepts a Bookmark instance
    public BookmarkViewPage(Bookmark _bookmark)
    {
        InitializeComponent();
        bookmark = _bookmark;      // Initialize with the provided Bookmark instance 
        BindingContext = bookmark; // Set the BindingContext to the bookmark instance
    }

    // Event handler for the URL button click event
    private async void OnUrlButtonClicked(object sender, EventArgs e)
    {
        var link = new Uri(bookmark.Url); // Create a new Uri from the bookmark URL
        await Launcher.OpenAsync(link);
    }
}