using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Health_App_mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity : ContentPage
    {
        public Activity()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Szoveg"] = etel.Text;
            DisplayAlert("Étel felírva","Eltároltuk az ételed erre a napra","Ok");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            etel.Text = string.Empty;
        }

    }
}