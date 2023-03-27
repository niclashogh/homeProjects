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
using mvvm.Models;

namespace mvvm.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Profiles : Window
    {
        public Profiles()
        {
            InitializeComponent();
            AddProfileList();
 
        }

        private void AddProfileList()
        {
            ProfileRepo repo = new ProfileRepo();
            DataContext = repo;

            var load = ProfileRepo.Retrive();
            ProfileList.ItemsSource = load;
        }

        #region Buttons
        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Inspect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
