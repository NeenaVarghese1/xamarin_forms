using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()

        {
            InitializeComponent();
        }

        private async void DashMyPolicies_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());

        }

    }
}
