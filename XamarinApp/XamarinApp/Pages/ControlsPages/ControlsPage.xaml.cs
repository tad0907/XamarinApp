using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Objects;

namespace XamarinApp.Pages.ControlsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage()
        {
            InitializeComponent();

            var dtos = new List<MenuDto>();

            dtos.Add(new MenuDto("SwitchPage",
                "Switchの使い方。", "NotePC.png"));

            MyListView.ItemsSource = dtos;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as MenuDto;

            switch (item.Title)
            {
                case "SwitchPage":
                    Navigation.PushAsync(new SwitchPage());
                    break;
                default:
                    break;
            }
        }
    }
}