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

        this.RefreshProducts();
        InitializeComponent();
    }

    private async void ListProducts_Click(object sender, EventArgs e)
    {
        List<Products?>? products = await _client.ListProduct();
        var productsBinding = new BindingList<Products>(products);

        dataGridView1.DataSource = productsBinding;
    }

    private async void RefreshProducts()
    {
        _products = await _client.ListProduct();
        dataGridView1.DataSource = this._products;
    }
}