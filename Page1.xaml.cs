using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void TitleViewBcakButton_Click(object sender, EventArgs e)
        {

        }

        private void ExpanderActivePolicy_Tapped(object sender, EventArgs e)
        {
            ExpandedContent.IsVisible = !ExpandedContent.IsVisible;
        }

        private void ExpanderPayments_Tapped(object sender, EventArgs e)
        {

            ExpandedPayment.IsVisible = !ExpandedPayment.IsVisible;
        }

        private void ExpanderLpasedPolicy_Tapped(object sender, EventArgs e)
        {
            ExpandedLappsed.IsVisible = !ExpandedLappsed.IsVisible;

        }

        private void ExpanderPolicyChanges_Tapped(object sender, EventArgs e)
        {

            ExpandedChanges.IsVisible = !ExpandedChanges.IsVisible;


        }
    }
}