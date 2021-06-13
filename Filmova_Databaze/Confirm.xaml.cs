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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Filmova_Databaze
{
    /// <summary>
    /// Interakční logika pro Confirm.xaml
    /// </summary>
    public partial class Confirm : Window
    {
        Movie mm;
        public Confirm(Movie m)
        {
            InitializeComponent();
            DataContext = m;
            mm = m;
        }

        private void but_Yes_Click(object sender, RoutedEventArgs e)
        {
            Movie.AllMovies.Remove(mm);
            Movie.AllMoviesFiltered.Remove(mm);
            Close();
        }

        private void but_No_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
