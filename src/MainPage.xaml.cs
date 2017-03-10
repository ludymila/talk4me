using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Hackthon
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string context = (MenuItens.SelectedItem as ListBoxItem).Content.ToString();
            //MessageBox.Show(conte);
            if (MenuItens.SelectedIndex == 0)
            {
                string path = "//EuQuero.xaml?context=" + context;
                NavigationService.Navigate(new Uri(path, UriKind.Relative));
            }
            else if (MenuItens.SelectedIndex == 1)
            {
                string path = "//EuVou.xaml?context=" + context;
                NavigationService.Navigate(new Uri(path, UriKind.Relative));
            }
            else if (MenuItens.SelectedIndex == 2)
            {
                string path = "//EuEstou.xaml?context=" + context;
                NavigationService.Navigate(new Uri(path, UriKind.Relative));
            }
            else if (MenuItens.SelectedIndex == 3)
            {
                string path = "//About.xaml";
                NavigationService.Navigate(new Uri(path, UriKind.Relative));
            }
        }
    }
}