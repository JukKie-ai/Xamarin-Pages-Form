using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage {
        public Page2() {
            InitializeComponent();
        }

        private async void NextTwoButton_Clicked(object sender, EventArgs e) {

            Application.Current.Properties["entryElementary"] = entryElementary.Text;
            Application.Current.Properties["entryEYear"] = entryEYear.Text;
            Application.Current.Properties["entryHighSchool"] = entryHighSchool.Text;
            Application.Current.Properties["entryHYear"] = entryHYear.Text;
            Application.Current.Properties["entryCollege"] = entryCollege.Text;
            await Navigation.PushAsync(new Page3());
        }

        private async void BackOneButton_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new MainPage());
        }
    }
}