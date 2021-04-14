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