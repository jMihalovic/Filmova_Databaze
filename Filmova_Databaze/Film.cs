using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmova_Databaze
{
    public class Movie : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }

        private string genre;
        public string Genre
        {
            get => genre;
            set { genre = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Genre")); }
        }

        private string countryOfOrigin;
        public string CountryOfOrigin
        {
            get => countryOfOrigin;
            set { countryOfOrigin = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CountryOfOrigin")); }
        }

        private int year;
        public int Year
        {
            get => year;
            set { year = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Year")); }
        }

        private int length;
        public int Length
        {
            get => length;
            set { length = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Length")); }
        }

        private string director;
        public string Director
        {
            get => director;
            set { director = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Director")); }
        }

        private string script;
        public string Script
        {
            get => script;
            set { script = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Script")); }
        }

        private string camera;
        public string Camera
        {
            get => camera;
            set { camera = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Camera")); }
        }

        private string music;
        public string Music
        {
            get => music;
            set { music = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Music")); }
        }

        private string actors;
        public string Actors
        {
            get => actors;
            set { actors = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Actors")); }
        }
        public static ObservableCollection<Movie> AllMovies { get; set; } = new ObservableCollection<Movie>();

        public static void InitMovies(string json)
        {
            AllMovies.Add(new Movie {Name = "ugfzufuzf", Genre = "swtrtxt", CountryOfOrigin = "ftzf", Year = 5464, Length = 5456465, Director = "ztfftz", Script = "", Camera = "", Music = "", Actors = ""});
            AllMovies.Add(new Movie { Name = "fzufzufu", Genre = "trxtrrtxtxr", CountryOfOrigin = "tzf", Year = 55465, Length = 465456, Director = "tzfzt", Script = "", Camera = "", Music = "", Actors = "" });
            AllMovies.Add(new Movie { Name = "uzfuzfzuf", Genre = "trxtxtrx", CountryOfOrigin = "tfzfztf", Year = 55456465, Length = 465456, Director = "ztftzf", Script = "", Camera = "", Music = "", Actors = "" });
            AllMovies.Add(new Movie { Name = "ufzufu", Genre = "trxtrxf", CountryOfOrigin = "ztfztf", Year = 5445, Length = 65464, Director = "ztfztf", Script = "", Camera = "", Music = "", Actors = "" });
            AllMovies.Add(new Movie { Name = "hjkihjhkh", Genre = "tzfzf", CountryOfOrigin = "ztfztfzt", Year = 4545, Length = 65464, Director = "ztfzfz", Script = "", Camera = "", Music = "", Actors = "" });
            AllMovies.Add(new Movie { Name = "weqweq", Genre = "ztfzf", CountryOfOrigin = "rstrs", Year = 45645, Length = 46546, Director = "zutf", Script = "", Camera = "", Music = "", Actors = "" });
        }

    }
}
