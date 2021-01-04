using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Pages.NoBuckButtonPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoBuckButtonPage : ContentPage
    {
        public NoBuckButtonPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}