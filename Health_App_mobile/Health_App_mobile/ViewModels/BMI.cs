using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Health_App_mobile.ViewModels
{
    internal class BMI : INotifyPropertyChanged
    {
        private double magassag = 180;
        private double testsuly = 72;
        private const double bmiindex = 1.0;
        public double Magassag
        {
            get => magassag;
            set
            {
                magassag = NextStep(value);
                Eredmenyfrissitese();
            }
        }
        public double Testsuly
        {
            get => testsuly;
            set
            {
                testsuly = NextStep(value);
                Eredmenyfrissitese();
            }
        }
        public double Bmi
            => Math.Round(Testsuly / Math.Pow(Magassag / 100, 2), 2);
        public string Osztalyozas
        {
            get
            {
                if (Bmi < 18.5)
                    return "Soványság";
                else if (Bmi < 25)
                    return "Normál testsúly";
                else if (Bmi < 30)
                    return "Túlsúlyos";
                else
                    return "Elhízott";
            }
        }
        private void Eredmenyfrissitese()
        {
            Valtozas(nameof(Bmi));
            Valtozas(nameof(Osztalyozas));
        }
        private double NextStep(double value)
            => Math.Round(value / bmiindex) * bmiindex;

        private void Valtozas(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
