using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Objects;
using XamarinApp.Pages.CorouselPages;

namespace XamarinApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            var dtos = new List<MenuDto>();

            dtos.Add(new MenuDto("CarouselMainPage",
                "カーセルページ：左右にスワイプしてページを移動する。", "Carousel.png"));

            MyListView.ItemsSource = dtos;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as MenuDto;
            //DisplayAlert(item.Title, item.SubTitle, "OK");

            if(item.Title == "CarouselMainPage")
            {
                Navigation.PushAsync(new CarouselMainPage());
            }
        }
    }
}