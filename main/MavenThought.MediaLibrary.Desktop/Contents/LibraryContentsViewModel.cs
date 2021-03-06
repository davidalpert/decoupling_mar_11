using MavenThought.Commons.Events;
using MavenThought.Commons.WPF.Events;
using MavenThought.MediaLibrary.Desktop.Events;

namespace MavenThought.MediaLibrary.Desktop.Contents
{
    /// <summary>
    /// View model to show the contents
    /// </summary>
    public class LibraryContentsViewModel : AbstractNotifyPropertyChanged, IHandleEventsOfType<IMovieAdded> 
    {
        public LibraryContentsViewModel()
        {
            this.Contents = "This are the contents of the library";
        }

        /// <summary>
        /// Gets or sets the contents
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// The movie was added
        /// </summary>
        /// <param name="event">Event to get the contents from</param>
        public void Handle(IMovieAdded @event)
        {
            this.Contents = string.Format("The movie {0} was added to the collection", @event.Movie.Title);

            this.OnPropertyChanged(() => Contents);
        }
    }
}