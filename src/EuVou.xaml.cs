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
    public partial class ContentPage : PhoneApplicationPage
    {
        public ContentPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            TokenTeste action1 = new TokenTeste() { Name = "brincar", ImagePath = "/Hackthon;component/images/brincar.png" };
            TokenTeste action2 = new TokenTeste() { Name = "andar", ImagePath = "/Hackthon;component/images/andar.png" };
            TokenTeste action3 = new TokenTeste() { Name = "dormir", ImagePath = "/Hackthon;component/images/dormir.png" };
            TokenTeste action4 = new TokenTeste() { Name = "comer", ImagePath = "/Hackthon;component/images/comer.png" };
            TokenTeste action5 = new TokenTeste() { Name = "estudar", ImagePath = "/Hackthon;component/images/estudar.png" };
            TokenTeste action6 = new TokenTeste() { Name = "ao banheiro", ImagePath = "/Hackthon;component/images/banheiro.png" };

            var actions = new List<TokenTeste>();
            actions.Add(action1);
            actions.Add(action2);
            actions.Add(action3);
            actions.Add(action4);
            actions.Add(action5);
            actions.Add(action6);
            vouView.DataContext = actions;

        }

        private void vouView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (vouView.SelectedItem != null)
            {
                string value = (vouView.SelectedItem as TokenTeste).Name;
                //MessageBox.Show(value);
                value = "Eu vou " + value;
                string path = "//Action.xaml?value=" + value;
                NavigationService.Navigate(new Uri(path, UriKind.Relative));

            }
            
            
            
        }
    }
}