using System;
using System.Collections.Generic;
using System.Linq;
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
            Eteleklista.Add(new Etelek { Etelneve = "Sajtal sonkával töltött csirkemell", Etelemennyiseg = "1 adag/200 g", Etelekaloria = "480 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Marha bélszín steak", Etelemennyiseg = "1 adag/150 g", Etelekaloria = "308 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Padlizsán krém", Etelemennyiseg = "16 g", Etelekaloria = "9 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Tonhalas szendvics", Etelemennyiseg = "50 g", Etelekaloria = "92 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Sült lazac", Etelemennyiseg = "1 adag/300 g", Etelekaloria = " 532 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Chiamag pudding", Etelemennyiseg = "100 g", Etelekaloria = "137 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Gyümölcsös túrókrém", Etelemennyiseg = "100 g", Etelekaloria = "62 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Paradicsomos csirkemell hajdinával", Etelemennyiseg = "250 g", Etelekaloria = "507 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Rántotta felturbózva", Etelemennyiseg = "260 g", Etelekaloria = "388 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Zöldséges csirke", Etelemennyiseg = "350 g", Etelekaloria = "247 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Kuszkusz", Etelemennyiseg = "50 g", Etelekaloria = "188 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Zabkása Áfonyával", Etelemennyiseg = "150 g", Etelekaloria = "468 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Pulykamáj Zöld salátával", Etelemennyiseg = "500 g", Etelekaloria = "283 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Cukkini", Etelemennyiseg = "250 g", Etelekaloria = "42 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Édesburgonya", Etelemennyiseg = "100 g", Etelekaloria = "105 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Vöröslencse", Etelemennyiseg = "50 g", Etelekaloria = "189 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Light mozzarella", Etelemennyiseg = "125 g", Etelekaloria = "206 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Sütőtök", Etelemennyiseg = "200 g", Etelekaloria = "154 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Cékla", Etelemennyiseg = "200 g", Etelekaloria = "129 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Fehérje turmix", Etelemennyiseg = "15 g", Etelekaloria = "60 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Padlizsán párolva", Etelemennyiseg = "250 g", Etelekaloria = "78 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Basmati rizs", Etelemennyiseg = "50 g", Etelekaloria = "177 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Tonhal sósvízben", Etelemennyiseg = "150 g", Etelekaloria = "166 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Darált  marhahús", Etelemennyiseg = "150 g", Etelekaloria = "176 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Répa párolva", Etelemennyiseg = "150 g", Etelekaloria = "64 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Kesudió", Etelemennyiseg = "30 g", Etelekaloria = "179 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Bogyós gyümölcs", Etelemennyiseg = "100 g", Etelekaloria = "45 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Mandulatej", Etelemennyiseg = "2 dcl", Etelekaloria = "26 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Zabpehely", Etelemennyiseg = "15 g", Etelekaloria = "67 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Piritott csirkemáj hagymás édesburgonyával", Etelemennyiseg = "550 g", Etelekaloria = "613 kcal" });
            Eteleklista.Add(new Etelek { Etelneve = "Paradicsomos marharagu tésztával", Etelemennyiseg = "330 g", Etelekaloria = "625 kcal" });
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
            //osszkaloria.Text = ($"{(nameof(Etelek).Count())}"+ "napi kalória");
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