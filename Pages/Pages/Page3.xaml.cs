using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage {
        public Page3() {
            InitializeComponent();
        }

        private async void BackTwoButton_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new Page2());
        }

        private async void NextThreeButton_Clicked(object sender, EventArgs e) {
            Application.Current.Properties["skill1"] = entrySkill1.Text;
            Application.Current.Properties["skill2"] = entrySkill2.Text;
            Application.Current.Properties["skill3"] = entrySkill3.Text;
            Application.Current.Properties["skill4"] = entrySkill4.Text;
            Application.Current.Properties["skill5"] = entrySkill5.Text;
            await Navigation.PushAsync(new FinalPage());
        }
    }
}