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
    public partial class EuQuero : PhoneApplicationPage
    {
        public EuQuero()
        {
            InitializeComponent();
        }

        private void queroView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (queroView.SelectedItem != null)
            {
                string value = (queroView.SelectedItem as TokenTeste).Name;
                //MessageBox.Show(value);
                value = "Eu quero " + value;
                string path = "//Action.xaml?value=" + value;
                NavigationService.Navigate(new Uri(path, UriKind.Relative));

            }
            
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            TokenTeste action1 = new TokenTeste() { Name = "frutas", ImagePath = "/Hackthon;component/images/fruta.png" };
            TokenTeste action2 = new TokenTeste() { Name = "pao", ImagePath = "/Hackthon;component/images/pao.png" };
            TokenTeste action3 = new TokenTeste() { Name = "coca-cola", ImagePath = "/Hackthon;component/images/coca-cola.png" };
            TokenTeste action4 = new TokenTeste() { Name = "sorvete", ImagePath = "/Hackthon;component/images/sorvete.png" };
            TokenTeste action5 = new TokenTeste() { Name = "dormir", ImagePath = "/Hackthon;component/images/dormir.png" };
            TokenTeste action6 = new TokenTeste() { Name = "agua", ImagePath = "/Hackthon;component/images/agua.png"};

            var actions = new List<TokenTeste>();
            actions.Add(action1);
            actions.Add(action2);
            actions.Add(action3);
            actions.Add(action4);
            actions.Add(action5);
            actions.Add(action6);

            queroView.DataContext = actions;

        }



    }
}