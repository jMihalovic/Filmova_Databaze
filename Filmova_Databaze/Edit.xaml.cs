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
    /// Interakční logika pro Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        bool IsUpdating { get; set; }

        public Edit()
        {
            InitializeComponent();
            DataContext = new Movie();
            IsUpdating = false;
        }

        Movie mm;
        public Edit(Movie m)
        {
            InitializeComponent();
            mm = m;
            DataContext = m;
            IsUpdating = true;
            Movie.AllMovies.Remove(m);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdating == false)
            {
                Movie.AllMoviesFiltered.Add((Movie)DataContext);
                Movie.AllMovies.Add((Movie)DataContext);
            }
            this.Close();
        }
    }
}
