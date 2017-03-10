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
using System.Windows.Media.Imaging;

namespace Hackthon
{
    public partial class Action: PhoneApplicationPage
    {
        public Action()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            
            var dic = NavigationContext.QueryString;
            string valor = dic["value"];
            //MessageBox.Show(valor);
            PageTitle.Text = valor;
            
            string[] vec = valor.Split(' ');

            string newpath = "/Hackthon;component/images/" + vec[vec.Length - 1] + ".png";

            //MessageBox.Show(newpath);

            BitmapImage tn = new BitmapImage();

            tn.SetSource(Application.GetResourceStream(new Uri(newpath, UriKind.Relative)).Stream);
            image1.Source = tn;

             string path = "http://translate.google.com.br/translate_tts?ie=UTF-8&q=" + valor +"&tl=pt&total=1&idx=0&textlen=14&prev=input";
            media.AutoPlay = true;
            media.Source = new Uri(path, UriKind.Absolute);
           


        }

        private void PhoneApplicationPage_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}