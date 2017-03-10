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
    public partial class EuEstou : PhoneApplicationPage
    {
        public EuEstou()
        {
            InitializeComponent();
        }

        private void estouView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (estouView.SelectedItem != null)
            {
                string value = (estouView.SelectedItem as TokenTeste).Name;
                //MessageBox.Show(value);
                value = "Eu estou " + value;
                string path = "//Action.xaml?value=" + value;
                NavigationService.Navigate(new Uri(path, UriKind.Relative));
            }
            
            
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            TokenTeste action1 = new TokenTeste() { Name = "triste", ImagePath = "/Hackthon;component/images/triste.png" };
            TokenTeste action2 = new TokenTeste() { Name = "alegre", ImagePath = "/Hackthon;component/images/alegre.png" };
            TokenTeste action3 = new TokenTeste() { Name = "com sono", ImagePath = "/Hackthon;component/images/sono.png" };
            TokenTeste action4 = new TokenTeste() { Name = "com raiva", ImagePath = "/Hackthon;component/images/raiva.png" };
            TokenTeste action5 = new TokenTeste() { Name = "assustado", ImagePath = "/Hackthon;component/images/assustado.png" };
            TokenTeste action6 = new TokenTeste() { Name = "ocupado", ImagePath = "/Hackthon;component/images/ocupado.png" };

            var actions = new List<TokenTeste>();
            actions.Add(action1);
            actions.Add(action2);
            actions.Add(action3);
            actions.Add(action4);
            actions.Add(action5);
            actions.Add(action6);

            estouView.DataContext = actions;

        }

    }
}