using Health_App_mobile.Models;
using Health_App_mobile.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Command = MvvmHelpers.Commands.Command;

namespace Health_App_mobile.ViewModels
{
    public class OwnDietVM : BaseViewModel
    {
        public ObservableRangeCollection<Diet> Diet { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Diet> RemoveCommand { get; }

        public OwnDietVM()
        {
            Diet = new ObservableRangeCollection<Diet>();

            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RemoveCommand = new AsyncCommand<Diet>(Remove);
        }
        async Task Add()
        {
            var etel = await App.Current.MainPage.DisplayPromptAsync("Saját Étrend", "Étel");
            var mennyiseg = await App.Current.MainPage.DisplayPromptAsync("Mennyiség", "");
            await DietService.AddDiet(etel, mennyiseg);
            await Refresh();
        }
        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            Diet.Clear();
            var diets = await DietService.GetDiet();
            Diet.AddRange(diets);
            IsBusy = false;
        }

        async Task Remove(Diet diet)
        {
            await DietService.RemoveDiet(diet.Id);
            await Refresh();
        }
    }
}
