using inventory_api_wrapper;
using inventory_api_wrapper.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace inventory_forms;

public partial class ProductListForm : Form
{
    private DataGridViewColumn? _sortColumn;
    private ListSortDirection? _sortOrder;

    private InventoryApiWrapper _client;
    private List<Products> _products;

    private GetProductListResponse _productListResponse;


    //private SortableBindingList<Products> _productList;
    //public SortableBindingList<Products> ProductList
    private SortableBindingList<GetProductResponse> _productList;
    public SortableBindingList<GetProductResponse> ProductList
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

    public ProductListForm()
    {

        InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        _client = new InventoryApiWrapper();
        await this.RefreshProducts();

        //var gridFrom = new AdvancedGrid(_products);
        //gridFrom.Show();
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
            _productListResponse = await _client.ListProduct();
            ProductList = new SortableBindingList<GetProductResponse>(_productListResponse.Items);
        }
        catch (Exception ex)
        {
            //API error
            exceptionTextBox.Text = $"Error: {ex.Message}";
            exceptionTextBox.Show();
        }

        //add button
        //DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
        //uninstallButtonColumn.Name = "actionButtonDataGridViewTextBoxColumn";
        //uninstallButtonColumn.HeaderText = "Details";
        //int columnIndex = 6;
        //if (ProductGridView.Columns["actionButtonDataGridViewTextBoxColumn"] == null)
        //{
        //    ProductGridView.Columns.Insert(columnIndex, uninstallButtonColumn);
        //}

        LoadingGif.Hide();

    }

    private async void searchBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Return)
        {
            searchButton_Click(sender, e);
        }
    }
    private async void searchButton_Click(object sender, EventArgs e)
    {
        //Viker ikke som at denne er nødvendig, om jeg ikke skal ha med paging
        List<GetProductResponse> filteredProducts = _productListResponse.Items.Where(x =>
            Regex.IsMatch(x.Name.ToString(), searchBox.Text.Trim(), RegexOptions.IgnoreCase) ||
            Regex.IsMatch(x.ArticleNo.ToString(), searchBox.Text.Trim(), RegexOptions.IgnoreCase)
        ).ToList();

        ProductList = new SortableBindingList<GetProductResponse>(filteredProducts);
    }
    private async void searchBox_TextChanged(object sender, EventArgs e)
    {
        //Usikker på om api update realtime vil fungere så bra, Kanskje om jeg skrur ned limiten??
    }
    private async void productGridView_SortedChange(object sender, EventArgs e)
    {
        //Kan bruke denne for å lagre sorteringa, selv om jeg endrer datagrunlaget ved søk
        
        _sortColumn = ProductGridView.SortedColumn;

        _sortOrder = 
            ProductGridView.SortOrder == SortOrder.Ascending ?  ListSortDirection.Ascending :
            ProductGridView.SortOrder == SortOrder.Descending ? ListSortDirection.Descending : 
            _sortOrder = null;

        //ProductGridView.Sort(_sortColumn, _sortOrder);
    }



    private async void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            if (e.ColumnIndex == ProductGridView.Columns["editProductButton"].Index)
                ProductGridView_CellDoubleClick(sender, e);
        }
    }

    private void ProductGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            var thisRow = ProductGridView.Rows[e.RowIndex];
            if (thisRow.DataBoundItem is GetProductResponse selectedProduct)
            {
                Guid ProductId = selectedProduct.ProductId;
                //Open edit window
            }
        }
    }

    private async void ProductGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        foreach (DataGridViewRow Myrow in ProductGridView.Rows)
        {
            //Gjør om de med stock == 0 til rød
            if (Convert.ToInt32(Myrow.Cells[4].Value) == 0) 
            {
                Myrow.DefaultCellStyle.BackColor = Color.Red;
                Myrow.Cells["availableGridViewTextBoxColumn"].Value = "False";
            }
            else
            {
                Myrow.Cells["availableGridViewTextBoxColumn"].Value = "True";
            }
            //Setter tekst på knappene
            Myrow.Cells["editProductButton"].Value = "Details";
            //var a = Myrow.Cells.OfType<>(); editProductButton
        }
    }

    private async void NewProductButton_Click(object sender, EventArgs e)
    {
        //Open Nytt produkt vindu
    }

    private async void DeleteProductButton_Click(object sender, EventArgs e)
    {
        //Legge til Are you sure you want to delete this row

        var Selectedrow = ProductGridView.SelectedRows;
        if(Selectedrow.Count != 1)
        {
            //må endre denne til en bedre errormelding
            throw new Exception("no Selected Rows");
        }
        else
        {
            var thisRow = Selectedrow[0];
            if (thisRow.DataBoundItem is GetProductResponse selectedProduct)
            {
                Guid ProductId = selectedProduct.ProductId;
                //Delete denne
                //Melding om at produktet er slettet
                //refresh data
            }
        }
    }





}