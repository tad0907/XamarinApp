using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Pages.ControlsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        private ObservableCollection<ProductDto> _products = new ObservableCollection<ProductDto>();

        public SearchBarPage()
        {
            InitializeComponent();

            _products.Add(new ProductDto(1, "DragonQuestI"));
            _products.Add(new ProductDto(2, "FinalFantasyV"));
            _products.Add(new ProductDto(3, "SuperMario"));

            ProductListView.ItemsSource = _products;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProductListView.ItemsSource = GetProduct(e.NewTextValue);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        private IEnumerable<ProductDto> GetProduct(string searchText = null)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return _products;
            }

            return _products.Where(x => x.ProductName.Contains(searchText));
        }
    }

    public sealed class ProductDto
    {
        public ProductDto(int id, string productName)
        {
            Id = id;
            ProductName = productName;
        }

        public int Id { get; }

        public string ProductName { get; }
    }
}