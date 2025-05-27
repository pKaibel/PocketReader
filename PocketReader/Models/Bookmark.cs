using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketReader.Models
{
    // The Bookmark class represents a bookmark with properties such as title, URL, time added, tags, and status.
    public class Bookmark
    {

        private string title;
        private string url;
        private string timeAdded;
        private string tags;
        private string status;      // "unread", "read", "archived", etc.

        /*  
         *  Beispiel für ein Bookmark-Objekt:
         *  { 
         *   "title": "Rhabarberkuchen mit Vanillecreme und Streusel von speedymaus | Chefkoch",
         *   "url": "https://www.chefkoch.de/rezepte/198191083776312/Rhabarberkuchen-mit-Vanillecreme-und-Streusel.html",
         *   "time_added": 1622027538,
         *   "tags": "kochen",
         *   "status": "unread"
         *  }
         */

        // Constructor
        // Initializes a new instance of the Bookmark class with default values.
        public Bookmark()
        {
            this.title = string.Empty;
            this.url = string.Empty;
            this.timeAdded = string.Empty;
            this.tags = string.Empty;
            this.status = "unread"; // Default status
        }

        // Constructor with parameters for the Bookmark class
        public Bookmark(string title, string url, string timeAdded, string tags, string status )
        {
            this.title = title;
            this.url = url;
            this.timeAdded = timeAdded;
            this.tags = tags;
            this.status = status;
        }

        // Properties for the Bookmark class        
        public string Title 
        {
            get { return title; }
            set { title = value; }
        }      
        public string Url 
        { 
            get { return url; }
            set { url = value; }
        }        
        public string TimeAdded 
        { 
            get { return timeAdded; }
            set { timeAdded = value; }
        }       
        public string Tags 
        { 
            get { return tags; }
            set { tags = value; }
        }
        // Status can be "unread", "read", "archived", etc.
        public string Status 
        { 
            get { return status; }
            set { status = value; }
        }

    }
}
