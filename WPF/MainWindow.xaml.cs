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
using WPF.ViewModels;

namespace WPF
{
    public partial class MainWindow : Window
    {
        PersonRepo pr = new PersonRepo();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = pr;

            var getPerson = PersonRepo.Load();
            MedarbejderList.ItemsSource = getPerson;
        }

        #region Controls

        //Clickables, Menu

        private void Menu0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Menu1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Menu2_Click(object sender, RoutedEventArgs e)
        {

        }

        //Clickables, TopMenu

        private void TopButton0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TopButton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TopButton2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TopButton3_Click(object sender, RoutedEventArgs e)
        {

        }

        //Clickables, Customs

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Validate_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion
    }

}
