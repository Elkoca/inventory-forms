using inventory_api_wrapper;
using inventory_api_wrapper.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace inventory_forms;

public partial class Form1 : Form
{
    private DataGridViewColumn? _sortColumn;
    private ListSortDirection? _sortOrder;

    private InventoryApiWrapper _client;
    private List<Products> _products;


    private SortableBindingList<Products> _productList;
    public SortableBindingList<Products> ProductList
    {
        get { return _productList; }
        set 
        {
            ProductGridView.DataSource = value;
            if(_sortColumn != null && _sortOrder != null)
            {
                ProductGridView.Sort(_sortColumn, (ListSortDirection)_sortOrder);
            }

            _productList = value; 
        }
    }

    public Form1()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        _client = new InventoryApiWrapper();
        await this.RefreshProducts();
    }

    private async void ListProducts_Click(object sender, EventArgs e)
    {
        await RefreshProducts();
    }

    private async Task RefreshProducts()
    {

        ProductGridView.DataSource = null;
        exceptionTextBox.Hide();
        LoadingGif.Show();

        try
        {
            _products = await _client.ListProduct();
            ProductList = new SortableBindingList<Products>(_products);
        }
        catch (Exception ex)
        {
            //API error
            exceptionTextBox.Text = $"Error: {ex.Message}";
            exceptionTextBox.Show();
        }

        LoadingGif.Hide();

    }

    //Kan hende at disse kan være de samme
    private void searchButton_Click(object sender, EventArgs e)
    {
        //Regex regex = new Regex();
        List<Products> filteredProducts = _products.Where(x => 
            Regex.IsMatch(x.Name, searchBox.Text.Trim(), RegexOptions.IgnoreCase) || 
            Regex.IsMatch(x.Id.ToString(), searchBox.Text.Trim(), RegexOptions.IgnoreCase)
        ).ToList();

        ProductList = new SortableBindingList<Products>(filteredProducts);
    }

    private void searchBox_TextChanged(object sender, EventArgs e)
    {
        //Regex regex = new Regex();
        List <Products> filteredProducts = _products.Where(x =>
            Regex.IsMatch(x.Name, searchBox.Text.Trim(), RegexOptions.IgnoreCase) ||
            Regex.IsMatch(x.Id.ToString(), searchBox.Text.Trim(), RegexOptions.IgnoreCase)
        ).ToList();

        ProductList = new SortableBindingList<Products>(filteredProducts);
    }

    private void productGridView_SortedChange(object sender, EventArgs e)
    {
        //Kan bruke denne for å lagre sorteringa, selv om jeg endrer datagrunlaget ved søk
        
        _sortColumn = ProductGridView.SortedColumn;

        _sortOrder = 
            ProductGridView.SortOrder == SortOrder.Ascending ?  ListSortDirection.Ascending :
            ProductGridView.SortOrder == SortOrder.Descending ? ListSortDirection.Descending : 
            _sortOrder = null;

        //ProductGridView.Sort(_sortColumn, _sortOrder);
    }
}