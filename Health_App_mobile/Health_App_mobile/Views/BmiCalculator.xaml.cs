using Health_App_mobile.ViewModels;
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
    public partial class BmiCalculator : ContentPage
    {
        public BmiCalculator()
        {
            InitializeComponent();
            BindingContext = new BMI();
        }
    }
}