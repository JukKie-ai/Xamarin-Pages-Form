using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinalPage : ContentPage {
        public FinalPage() {
            InitializeComponent();

            fName.Text = Application.Current.Properties["fName"].ToString();
            mName.Text = Application.Current.Properties["mName"].ToString();
            lName.Text = Application.Current.Properties["lName"].ToString();
            birthday.Text = Application.Current.Properties["birthday"].ToString();
            gender.Text = Application.Current.Properties["gender"].ToString();

            elementary.Text = Application.Current.Properties["entryElementary"].ToString();
            eYear.Text = Application.Current.Properties["entryEYear"].ToString();
            hSchool.Text = Application.Current.Properties["entryHighSchool"].ToString();
            hYear.Text = Application.Current.Properties["entryHYear"].ToString();
            college.Text = Application.Current.Properties["entryCollege"].ToString();

            skill1.Text = Application.Current.Properties["skill1"].ToString();
            skill2.Text = Application.Current.Properties["skill2"].ToString();
            skill3.Text = Application.Current.Properties["skill3"].ToString();
            skill4.Text = Application.Current.Properties["skill4"].ToString();
            skill5.Text = Application.Current.Properties["skill5"].ToString();
        }
    }
}