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
        public IList<Etelek> Eteleklista { get; set; }
        public Activity()
        {
            InitializeComponent();
            Eteleklista = new List<Etelek>();
            Eteleklista.Add(new Etelek { Etelneve = "Fehér kenyér", Etelemennyiseg = "180g/szelet", Etelekaloria="60 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Fehér kenyér", Etelemennyiseg = "180g/szelet", Etelekaloria = "60 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Fehér kenyér", Etelemennyiseg = "180g/szelet", Etelekaloria = "60 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Fehér kenyér", Etelemennyiseg = "180g/szelet", Etelekaloria = "60 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Fehér kenyér", Etelemennyiseg = "180g/szelet", Etelekaloria = "60 kcal" });

            BindingContext = this;
        }

        public class Etelek
        {
            public string Etelneve { get; set; }
            public string Etelemennyiseg { get; set; }
            public string Etelekaloria { get; set; }
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            //Application.Current.Properties["Szoveg"] = etel.Text;
            DisplayAlert("Étel felírva","Eltároltuk az ételed erre a napra","Ok");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //etel.Text = string.Empty;
        }
    }
}