using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Pages.DeviceSwitchPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceSwitchPage : ContentPage
    {
        public DeviceSwitchPage()
        {
            InitializeComponent();

            if(Device.RuntimePlatform == Device.iOS)
            {
                MyImage.Source = "Dragon.png";
            }
            else if (Device.RuntimePlatform == Device.Android)
            {
                MyImage.Source = "Dragon.png";
            }
            else if (Device.RuntimePlatform == Device.UWP)
            {
                MyImage.Source = @"Images/Dragon2.png";
            }
        }
    }
}