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
    public partial class TableViewPage : ContentPage
    {
        public TableViewPage()
        {
            InitializeComponent();
        }

        private void EntryCell_Completed(object sender, EventArgs e)
        {
            DisplayAlert("エントリセル", "完了しました。", "OK");
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            DisplayAlert("スイッチセル", "変更しました。", "OK");
        }
    }
}