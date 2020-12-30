using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Objects;

namespace XamarinApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            var dtos = new List<MenuDto>();

            dtos.Add(new MenuDto("AAAAA", "aaaaaaaa", "mail.png"));
            dtos.Add(new MenuDto("BBBBB", "bbbbbbbcccccccccccccccc", "mail.png"));

            MyListView.ItemsSource = dtos;
        }
    }
}