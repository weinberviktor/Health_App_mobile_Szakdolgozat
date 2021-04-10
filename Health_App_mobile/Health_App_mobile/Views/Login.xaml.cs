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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registration());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var dbut = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Felhasznalok.db");
            var db = new SQLiteConnection(dbut);
            var lekerdzeses = db.Table<RegUsers>().Where(u => u.Felhasznev.Equals(Entryfelhasz.Text) && u.Jelszo.Equals(Entryjelsz.Text)).FirstOrDefault();
            if(lekerdzeses!=null)
            {
                App.Current.MainPage = new NavigationPage(new Activity());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var eredmeny = await this.DisplayAlert("Nem található felhasználó", "Regisztrálj!", "OK", "Kilép");

                    if (eredmeny)
                        await Navigation.PushAsync(new Activity());
                    else
                    {
                        await Navigation.PushAsync(new Registration());
                    }
                });
            }
        }
    }
}