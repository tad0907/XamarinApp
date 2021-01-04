using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Objects;
using XamarinApp.Pages.ControlsPages;
using XamarinApp.Pages.CorouselPages;
using XamarinApp.Pages.DeviceSwitchPages;
using XamarinApp.Pages.DisplayActionSheetPages;
using XamarinApp.Pages.MessageBoxPages;
using XamarinApp.Pages.NoBuckButtonPages;
using XamarinApp.Pages.PageEventPages;

namespace XamarinApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            var dtos = new List<MenuDto>();

            dtos.Add(new MenuDto("ControlsPage",
                "コントロールの一覧。", "NotePC.png"));
            dtos.Add(new MenuDto("CarouselMainPage",
                "左右にスワイプしてページを移動する。", "NotePC.png"));
            dtos.Add(new MenuDto("MessageBoxPage",
                "メッセージを表示する。", "NotePC.png"));
            dtos.Add(new MenuDto("DisplayActionSheetPage",
                "選択リストから選べる問い合わせ。", "NotePC.png"));
            dtos.Add(new MenuDto("DeviceSwitchPage",
                "デバイスごとの切り替え。", "NotePC.png"));
            dtos.Add(new MenuDto("PageEventPage",
                "LoadとCloseに代わるもの。", "NotePC.png"));
            dtos.Add(new MenuDto("NoBuckButtonPage",
                "ナビゲーションの戻るボタンを消す。", "NotePC.png"));

            MyListView.ItemsSource = dtos;
        }

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as MenuDto;

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
                case "DeviceSwitchPage":
                    Navigation.PushAsync(new DeviceSwitchPage());
                    break;
                case "PageEventPage":
                    Navigation.PushAsync(new PageEventPage());
                    break;
                case "NoBuckButtonPage":
                    Navigation.PushAsync(new NoBuckButtonPage());
                    break;
                case "ControlsPage":
                    Navigation.PushAsync(new ControlsPage());
                    break;
                default:
                    break;
            }
        }
    }
}