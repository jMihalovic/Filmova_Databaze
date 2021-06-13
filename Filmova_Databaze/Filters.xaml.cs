using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Filmova_Databaze
{
    /// <summary>
    /// Interakční logika pro Filters.xaml
    /// </summary>
    public partial class Filters : Window
    {
        public Filters()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            string s1 = (string)FBox.Text;
            string s2 = (string)TFilt.Text;
            Movie.AllMoviesFiltered.Clear();
            List<Movie> list = new List<Movie>();
            foreach(Movie x in Movie.AllMovies)
            {
                switch (s1)
                {
                    default:
                        list.Add(x);
                        break;
                    case "Nothing":
                        list.Add(x);
                        break;
                    case "Name":
                        if (x.Name.Contains(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Name).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Name).ToList(); }
                        }
                        break;
                    case "Genre":
                        if (x.Genre.Contains(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Name).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Name).ToList(); }
                        }
                        break;
                    case "Country Of Origin":
                        if (x.CountryOfOrigin.Contains(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Name).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Name).ToList(); }
                        }
                        break;
                    case "Year":
                        if (x.Year == Convert.ToInt32(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Year).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Year).ToList(); }
                        }
                        break;
                    case "Length":
                        if (x.Length == Convert.ToInt32(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Length).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Length).ToList(); }
                        }
                        break;
                    case "Director":
                        if (x.Director.Contains(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Name).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Name).ToList(); }
                        }
                        break;
                    case "Script":
                        if (x.Script.Contains(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Name).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Name).ToList(); }
                        }
                        break;
                    case "Camera":
                        if (x.Camera.Contains(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Name).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Name).ToList(); }
                        }
                        break;
                    case "Music":
                        if (x.Music.Contains(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Name).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Name).ToList(); }
                        }
                        break;
                    case "Actors":
                        if (x.Actors.Contains(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Name).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Name).ToList(); }
                        }
                        break;
                    case "Rating":
                        if (x.Rating == Convert.ToInt32(s2))
                        {
                            list.Add(x);
                            if (SBox.SelectedIndex == 0) { list = list.OrderBy(Movie => Movie.Rating).ToList(); }
                            if (SBox.SelectedIndex == 1) { list = list.OrderByDescending(Movie => Movie.Rating).ToList(); }
                        }
                        break;
                }
            }
            foreach (Movie m in list)
                Movie.AllMoviesFiltered.Add(m);
            Close();
        }
    }
}
