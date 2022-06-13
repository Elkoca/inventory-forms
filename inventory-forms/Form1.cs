using inventory_api_wrapper;
using inventory_api_wrapper.Models;

namespace inventory_forms;

public partial class Form1 : Form
{
    InventoryApiWrapper _client;
    public Form1()
    {
        _client = new InventoryApiWrapper();
        InitializeComponent();
    }

    private async void ListProducts_Click(object sender, EventArgs e)
    {
        List<Products?>? a = await _client.ListProduct();

        dataGridView1.DataSource = a;
    }
}