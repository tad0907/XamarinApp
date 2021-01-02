using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Objects;
using XamarinApp.Pages.CorouselPages;
using XamarinApp.Pages.DisplayActionSheetPages;
using XamarinApp.Pages.MessageBoxPages;

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
                "左右にスワイプしてページを移動する。", "Carousel.png"));
            dtos.Add(new MenuDto("MessageBoxPage",
                "メッセージを表示する。", "MessageBox.png"));
            dtos.Add(new MenuDto("DisplayActionSheetPage",
                "選択リストから選べる問い合わせ。", "DisplayActionSheetPage.png"));

            MyListView.ItemsSource = dtos;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as MenuDto;
            //DisplayAlert(item.Title, item.SubTitle, "OK");

            switch (item.Title)
            {
                case "CarouselMainPage":
                    Navigation.PushAsync(new CarouselMainPage());
                    break;
                case "MessageBoxPage":
                    Navigation.PushAsync(new MessageBoxPage());
                    break;
                case "DisplayActionSheetPage":
                    Navigation.PushAsync(new DisplayActionSheetPage());
                    break;
                default:
                    break;
            }
        }
    }
}