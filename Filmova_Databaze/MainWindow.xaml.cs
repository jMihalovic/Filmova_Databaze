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
using Newtonsoft.Json;

namespace Filmova_Databaze
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            Movie.InitMovies("movies.txt");
            Movie m = new Movie();
            DataContext = m;
            Movies.SelectedIndex = 0;
        }

        private void Movies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie mc = (Movie)((sender as ListBox).SelectedItem);
            DataContext = mc;
        }

        private void Movies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie mc = (Movie)((sender as ListBox).SelectedItem);
            Edit em = new Edit(mc);
            em.ShowDialog();
        }

        private void But_Add_Click(object sender, RoutedEventArgs e)
        {
            Edit em = new Edit();
            em.ShowDialog();
        }

        private void But_Change_Click(object sender, RoutedEventArgs e)
        {
            Movie mc = (Movie)Movies.SelectedItem;
            Edit em = new Edit(mc);
            em.ShowDialog();
            Movie.AllMovies.Add(mc);
        }

        private void But_Delete_Click(object sender, RoutedEventArgs e)
        {
            Movie md = (Movie)Movies.SelectedItem;
            Confirm cm = new Confirm(md);
            cm.ShowDialog();
            Movie m = new Movie();
            DataContext = m;
            Movies.SelectedIndex = 0;
        }

        private void But_Filters_Click(object sender, RoutedEventArgs e)
        {
            Filters ft = new Filters();
            ft.ShowDialog();
            Movie m = new Movie();
            DataContext = m;
            Movies.SelectedIndex = 0;
        }

        private void But_Save_Click(object sender, RoutedEventArgs e)
        {
            string mov = JsonConvert.SerializeObject(Movie.AllMovies);
            System.IO.File.WriteAllText("movies.txt", $"{'{'}{'"'}movSave{'"'}:{mov}{'}'}");
            MessageBox.Show("Saved");
        }
    }
}
