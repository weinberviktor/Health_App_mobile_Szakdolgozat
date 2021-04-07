using Health_App_mobile.Models;
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
    public partial class OwnDiet : ContentPage
    {
        public OwnDiet()
        {
            InitializeComponent();
        }
        //private async void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var Item = ((ListView)sender).SelectedItem as Diet;
        //    if (Item == null)
        //        return;
        //    await DisplayAlert("Étel kiválasztva", Item.Etel, "Ok");
        //}
        //private void Listview_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    ((ListView)sender).SelectedItem = null;
        //}
        //private async void Menu_Clicked(object sender, EventArgs e)
        //{
        //    var Item = ((MenuItem)sender).BindingContext as Diet;
        //    if (Item == null)
        //        return;
        //    await DisplayAlert("Hozzáadva a kedvencekhez", Item.Etel, "Ok");
        //}
    }
}