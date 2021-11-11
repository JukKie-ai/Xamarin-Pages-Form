using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pages {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private async void NextOneButton_Clicked(object sender, EventArgs e) {

            Application.Current.Properties["fName"] = entryFName.Text;
            Application.Current.Properties["mName"] = entryMName.Text;
            Application.Current.Properties["lName"] = entryLName.Text;
            Application.Current.Properties["birthday"] = entryBirthday.Text;
            Application.Current.Properties["gender"] = entryGender.Text;
            await Navigation.PushAsync(new Page2());
        }
    }
}
