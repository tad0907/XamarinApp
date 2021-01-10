using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Pages.ControlsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolbarItemPage : ContentPage
    {
        public ToolbarItemPage()
        {
            InitializeComponent();
        }

        private void AAAAToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("クリックされたのは", "AAAA", "OK");
        }

        private void BBBBToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("クリックされたのは", "BBBB", "OK");
        }
    }
}