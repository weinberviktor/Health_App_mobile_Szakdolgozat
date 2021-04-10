using Health_App_mobile.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Health_App_mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbut = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Felhasznalok.db");
            var db = new SQLiteConnection(dbut);
            db.CreateTable<RegUsers>();
            var eszkozok = new RegUsers()
            {
                Felhasznev = Entryfelhasznev.Text,
                Jelszo = Entryjelszo.Text
            };
            db.Insert(eszkozok);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var eredmeny = await this.DisplayAlert("Regisztráció", "Sikeresen regisztráltál", "OK", ".");

                if (eredmeny)
                    await Navigation.PushAsync(new Login());

            });
        }
    }
}