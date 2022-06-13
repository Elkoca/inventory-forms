using inventory_api_wrapper;
using inventory_api_wrapper.Models;
using System.ComponentModel;

namespace inventory_forms;

public partial class Form1 : Form
{
    private InventoryApiWrapper _client;
    private List<Products?>? _products;

    public Form1()
    {
        _client = new InventoryApiWrapper();
        InitializeComponent();

        this.RefreshProducts();
    }

    private async void ListProducts_Click(object sender, EventArgs e)
    {
        await RefreshProducts();
    }

    private async Task RefreshProducts()
    {
        //ProductGridView.CellDoubleClick();
        ProductGridView.DataSource = null;
        LoadingGif.Show();
        _products = await _client.ListProduct();
        LoadingGif.Hide();
        ProductGridView.DataSource = this._products;
    }
}