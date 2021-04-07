using Health_App_mobile.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Command = MvvmHelpers.Commands.Command;

namespace Health_mobile_app.ViewModels
{
    public class DietPageData : BaseViewModel
    {
        public ObservableRangeCollection<Diet> Diet { get; set; }
        public ObservableRangeCollection<Grouping<string, Diet>> DietGroup { get; set; }
        public AsyncCommand RefreshCommand { get; }

        public AsyncCommand<Diet> FavoriteCommand { get; }
        public AsyncCommand<Diet> SelectedCommand { get; }

        public Command LoadMoreCommand { get; }
        public Command DelayLoadMoreCommand { get; }
        public Command ClearCommand { get; }

        public DietPageData()
        {
            Title = "Diet Menu";

            Diet = new ObservableRangeCollection<Diet>();
            DietGroup = new ObservableRangeCollection<Grouping<string, Diet>>();

            LoadMore();

            RefreshCommand = new AsyncCommand(Refresh);
            LoadMoreCommand = new Command(LoadMore);
            ClearCommand = new Command(Clear);
            DelayLoadMoreCommand = new Command(DelayLoadMore);

            FavoriteCommand = new AsyncCommand<Diet>(Favorite);
            SelectedCommand = new AsyncCommand<Diet>(Selected);
        }
        async Task Favorite(Diet diet)
        {
            if (diet == null)
                return;

            await Application.Current.MainPage.DisplayAlert("Kedvencekhez adva", diet.Etel, "OK");

        }
        Diet previouslySelected;
        Diet selectedDiet;
        public Diet SelectedDiet
        {
            get => selectedDiet;
            set => SetProperty(ref selectedDiet, value);
        }
        async Task Selected(Diet diet)
        {
            if (diet == null)
                return;
            //SelectedDiet = null;
            await Application.Current.MainPage.DisplayAlert("Kiválasztva", diet.Etel, "Ok");
        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }

        void LoadMore()
        {
            if (Diet.Count >= 20)
                return;

            Diet.Add(new Diet { Etkezes = "Reggeli", Etel = "Zabkasa", Mennyiseg = "100g" });
            Diet.Add(new Diet { Etkezes = "Ebéd", Etel = "Ami jól esik", Mennyiseg = "Sokat" });
            Diet.Add(new Diet { Etkezes = "Vacsora", Etel = "Ne egyél sokat", Mennyiseg = "2 db alma" });
            Diet.Add(new Diet { Etkezes = "Reggeli", Etel = "Zabkasa2", Mennyiseg = "100g" });
            Diet.Add(new Diet { Etkezes = "Ebéd", Etel = "Ami jól esik2", Mennyiseg = "Sokat" });
            Diet.Add(new Diet { Etkezes = "Vacsora", Etel = "Ne egyél sokat2", Mennyiseg = "2 db alma" });

            DietGroup.Clear();

            DietGroup.Add(new Grouping<string, Diet>("Reggeli", Diet.Where(d => d.Etkezes == "Reggeli")));
            DietGroup.Add(new Grouping<string, Diet>("Ebéd", Diet.Where(d => d.Etkezes == "Ebéd")));
            DietGroup.Add(new Grouping<string, Diet>("Vacsora", Diet.Where(d => d.Etkezes == "Vacsora")));
        }

        void DelayLoadMore()
        {
            if (Diet.Count <= 10)
                return;

            LoadMore();
        }
        void Clear()
        {
            Diet.Clear();
            DietGroup.Clear();
        }
    }
}
