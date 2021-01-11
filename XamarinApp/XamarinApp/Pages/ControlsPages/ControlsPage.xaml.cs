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
            dtos.Add(new MenuDto("SwitchBindablePage",
                "Switchの使い方＋バインディング。", "NotePC.png"));
            dtos.Add(new MenuDto("SliderPage",
                "Sliderの使い方。", "NotePC.png"));
            dtos.Add(new MenuDto("StepperPage",
                "Stepperの使い方。", "NotePC.png"));
            dtos.Add(new MenuDto("EntryPage",
                "Entryの使い方。", "NotePC.png"));
            dtos.Add(new MenuDto("EditorPage",
                "Editorの使い方。", "NotePC.png"));
            dtos.Add(new MenuDto("PickerPage",
                "Pickerはコンボボックスのような感じ。", "NotePC.png"));
            dtos.Add(new MenuDto("PickerBindablePage",
                "PickerIDで識別などのためのバインディング。", "NotePC.png"));
            dtos.Add(new MenuDto("DateTimePickerPage",
                "DateTimePickerの使い方。", "NotePC.png"));
            dtos.Add(new MenuDto("SearchBarPage",
                "SearchBarの使い方。", "NotePC.png"));
            dtos.Add(new MenuDto("ToolbarItemPage",
                "ToolbarItemの使い方。", "NotePC.png"));
            dtos.Add(new MenuDto("TableViewPage",
                "TableViewの使い方。", "NotePC.png"));
            dtos.Add(new MenuDto("ActivityIndicatorPage",
                "処理中にくるくる。。", "NotePC.png"));

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
                case "SwitchBindablePage":
                    Navigation.PushAsync(new SwitchBindablePage());
                    break;
                case "SliderPage":
                    Navigation.PushAsync(new SliderPage());
                    break;
                case "StepperPage":
                    Navigation.PushAsync(new StepperPage());
                    break;
                case "EntryPage":
                    Navigation.PushAsync(new EntryPage());
                    break;
                case "EditorPage":
                    Navigation.PushAsync(new EditorPage());
                    break;
                case "PickerPage":
                    Navigation.PushAsync(new PickerPage());
                    break;
                case "PickerBindablePage":
                    Navigation.PushAsync(new PickerBindablePage());
                    break;
                case "DateTimePickerPage":
                    Navigation.PushAsync(new DateTimePickerPage());
                    break;
                case "SearchBarPage":
                    Navigation.PushAsync(new SearchBarPage());
                    break;
                case "ToolbarItemPage":
                    Navigation.PushAsync(new ToolbarItemPage());
                    break;
                case "TableViewPage":
                    Navigation.PushAsync(new TableViewPage());
                    break;
                case "ActivityIndicatorPage":
                    Navigation.PushAsync(new ActivityIndicatorPage());
                    break;
                default:
                    break;
            }
        }
    }
}