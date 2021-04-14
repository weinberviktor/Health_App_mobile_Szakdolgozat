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
            Eteleklista.Add(new Etelek { Etelneve = "Fehér kenyér", Etelemennyiseg = "60g/szelet", Etelekaloria="180 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Barna kenyér", Etelemennyiseg = "30g/szelet", Etelekaloria = "75 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Zsömle", Etelemennyiseg = "54g/db", Etelekaloria = "149 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Kifli", Etelemennyiseg = "44g/db", Etelekaloria = "120 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Vaj", Etelemennyiseg = "10g", Etelekaloria = "72 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Csirkemell sonka", Etelemennyiseg = "1 szelet", Etelekaloria = "12 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Téliszalámi", Etelemennyiseg = "10 g", Etelekaloria = "50 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Pulykamell sonka", Etelemennyiseg = "12 g", Etelekaloria = "13 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Sajtos Párizsi", Etelemennyiseg = "9 g", Etelekaloria = "13 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Főtt tojás", Etelemennyiseg = "1 db", Etelekaloria = "81 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Húsleves tésztával", Etelemennyiseg = "1 tányér", Etelekaloria = "188 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Zöldségleves", Etelemennyiseg = "1 tányér", Etelekaloria = "192 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Gulyásleves", Etelemennyiseg = "1 tányér", Etelekaloria = "356 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Bableves", Etelemennyiseg = "1 tányér", Etelekaloria = "384 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Gyömölcsleves", Etelemennyiseg = "1 tányér", Etelekaloria = "245 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Zöldborsóleves", Etelemennyiseg = "1 tányér", Etelekaloria = "198 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Alma", Etelemennyiseg = "1 db", Etelekaloria = "95 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Pestos tészta", Etelemennyiseg = "1 adag/270 g", Etelekaloria = "931 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Rakott Krumpli", Etelemennyiseg = "1 adag/400 g", Etelekaloria = "50 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Rántott hús", Etelemennyiseg = "70 g", Etelekaloria = "147 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Főtt fehér rizs", Etelemennyiseg = "300 g", Etelekaloria = "390 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Főtt krumpli", Etelemennyiseg = "1 adag/300 g", Etelekaloria = "231 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Sült krumpli", Etelemennyiseg = "117 g", Etelekaloria = "342 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Görörg Saláta", Etelemennyiseg = "1 adag/250 g", Etelekaloria = "180 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Cézár Saláta", Etelemennyiseg = "1 adag/250 g", Etelekaloria = "288 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Paradicsomos tészta", Etelemennyiseg = "1 adag/400 g", Etelekaloria = "318 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Sajtal sonkávaL töltött csirkemell", Etelemennyiseg = "1 adag/200 g", Etelekaloria = "480 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Marha bélszín steak", Etelemennyiseg = "1 adag/150 g", Etelekaloria = "308 kcal" });

            BindingContext = this;
        }

        public class Etelek
        {   
            public string Etelneve { get; set; }
            public string Etelemennyiseg { get; set; }
            public string Etelekaloria { get; set; }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //osszkaloria.Text = ($"{Eteleklista.Count}"+ "napi kalória");
            //osszkaloria.Text = (nameof(Etelek));
            //osszkaloria.Text = Etelekaloria.ToString();

        }
        private void Kereso_TextChanged(object sender, TextChangedEventArgs e)
        {
            var kereseserdemeny = Eteleklista.Where(k => k.Etelneve.ToLower().Contains(kereso.Text.ToLower()));
            listview.ItemsSource = kereseserdemeny;
        }
    }
}