using inventory_api_wrapper.Models;

namespace inventory_forms
{
    partial class ProductListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.nameDQataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editProductButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.getProductResponseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListProducts = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.LoadingGif = new System.Windows.Forms.PictureBox();
            this.exceptionTextBox = new System.Windows.Forms.RichTextBox();
            this.getProductResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPriceResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewProductButton = new System.Windows.Forms.Button();
            this.productListPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProductTabControl = new System.Windows.Forms.TabControl();
            this.productsTabPage1 = new System.Windows.Forms.TabPage();
            this.productDetailsTabPage = new System.Windows.Forms.TabPage();
            this.ProductDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelProductDetailsButton = new System.Windows.Forms.Button();
            this.editProductDetailsButton = new System.Windows.Forms.Button();
            this.saveProductDetailsButton = new System.Windows.Forms.Button();
            this.addNewVendorProductDetailsButton = new System.Windows.Forms.Button();
            this.productIdProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.vendorProductDetailsComboBox = new System.Windows.Forms.ComboBox();
            this.productIdProductDetailsLabel = new System.Windows.Forms.Label();
            this.addNewProductTypeProductDetailsButton = new System.Windows.Forms.Button();
            this.nameProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.nameProductDetailsLabel = new System.Windows.Forms.Label();
            this.titleProductDetailsLabel = new System.Windows.Forms.Label();
            this.titleProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.vendorProductDetailsLabel = new System.Windows.Forms.Label();
            this.descriptionProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.productTypeProductDetailsLabel = new System.Windows.Forms.Label();
            this.descriptionProductDetailsLabel = new System.Windows.Forms.Label();
            this.productTypeProductDetailsComboBox = new System.Windows.Forms.ComboBox();
            this.stockProductDetailsLabel = new System.Windows.Forms.Label();
            this.currencyProductDetailsLabel = new System.Windows.Forms.Label();
            this.stockProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.priceProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.barcodeProductDetailsLabel = new System.Windows.Forms.Label();
            this.currencyProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.barcodeProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.priceProductDetailsLabel = new System.Windows.Forms.Label();
            this.productTypePropertiesProductDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.productDescriptionProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.productTypeNameProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.productTypeIdProductDetailsLabel = new System.Windows.Forms.Label();
            this.productTypeNameProductDetailsLabel = new System.Windows.Forms.Label();
            this.productTypeIdProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.productTypeDescriptionProductDetailsLabel = new System.Windows.Forms.Label();
            this.vendorPropertiesProductDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.vendorNameProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.vendorIdProductDetailsLabel = new System.Windows.Forms.Label();
            this.vendorWebsiteProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameProductDetailsLabel = new System.Windows.Forms.Label();
            this.vendorWebsiteProductDetailsLabel = new System.Windows.Forms.Label();
            this.vendorIdProductDetailsTextBox = new System.Windows.Forms.TextBox();
            this.addProductTabPage = new System.Windows.Forms.TabPage();
            this.addNewProductDetailsButton = new System.Windows.Forms.Button();
            this.CancelAddProductButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductResponseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPriceResponseBindingSource)).BeginInit();
            this.productListPanel.SuspendLayout();
            this.ProductTabControl.SuspendLayout();
            this.productsTabPage1.SuspendLayout();
            this.productDetailsTabPage.SuspendLayout();
            this.ProductDetailsGroupBox.SuspendLayout();
            this.productTypePropertiesProductDetailsGroupBox.SuspendLayout();
            this.vendorPropertiesProductDetailsGroupBox.SuspendLayout();
            this.addProductTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductGridView.AutoGenerateColumns = false;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDQataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.articleNoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.availableGridViewTextBoxColumn,
            this.editProductButton});
            this.ProductGridView.DataSource = this.getProductResponseBindingSource1;
            this.ProductGridView.Location = new System.Drawing.Point(-2, 33);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowHeadersVisible = false;
            this.ProductGridView.RowTemplate.Height = 25;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(520, 382);
            this.ProductGridView.TabIndex = 1;
            this.ProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            this.ProductGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellDoubleClick);
            this.ProductGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductGridView_CellFormatting);
            this.ProductGridView.Sorted += new System.EventHandler(this.productGridView_SortedChange);
            // 
            // nameDQataGridViewTextBoxColumn
            // 
            this.nameDQataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDQataGridViewTextBoxColumn.FillWeight = 50F;
            this.nameDQataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDQataGridViewTextBoxColumn.Name = "nameDQataGridViewTextBoxColumn";
            this.nameDQataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 50F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 75F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleNoDataGridViewTextBoxColumn
            // 
            this.articleNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.articleNoDataGridViewTextBoxColumn.DataPropertyName = "ArticleNo";
            this.articleNoDataGridViewTextBoxColumn.FillWeight = 1F;
            this.articleNoDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.articleNoDataGridViewTextBoxColumn.Name = "articleNoDataGridViewTextBoxColumn";
            this.articleNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.articleNoDataGridViewTextBoxColumn.Width = 75;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.FillWeight = 1F;
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 65;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.FillWeight = 1F;
            this.createdDataGridViewTextBoxColumn.HeaderText = "Added";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableGridViewTextBoxColumn
            // 
            this.availableGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.availableGridViewTextBoxColumn.HeaderText = "Available";
            this.availableGridViewTextBoxColumn.Name = "availableGridViewTextBoxColumn";
            this.availableGridViewTextBoxColumn.ReadOnly = true;
            this.availableGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.availableGridViewTextBoxColumn.Width = 75;
            // 
            // editProductButton
            // 
            this.editProductButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editProductButton.FillWeight = 1F;
            this.editProductButton.HeaderText = "Details/Edit";
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.ReadOnly = true;
            this.editProductButton.Width = 75;
            // 
            // getProductResponseBindingSource1
            // 
            this.getProductResponseBindingSource1.DataSource = typeof(inventory_api_wrapper.Models.GetProductResponse);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(inventory_api_wrapper.Models.Products);
            // 
            // ListProducts
            // 
            this.ListProducts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ListProducts.AutoSize = true;
            this.ListProducts.Location = new System.Drawing.Point(204, 421);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(105, 25);
            this.ListProducts.TabIndex = 0;
            this.ListProducts.Text = "Refresh";
            this.ListProducts.UseVisualStyleBackColor = true;
            this.ListProducts.Click += new System.EventHandler(this.ListProducts_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(446, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(67, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(293, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(147, 23);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.Location = new System.Drawing.Point(362, 422);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(151, 23);
            this.DeleteProductButton.TabIndex = 4;
            this.DeleteProductButton.Text = "Delete selected product";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // LoadingGif
            // 
            this.LoadingGif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingGif.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("LoadingGif.Image")));
            this.LoadingGif.InitialImage = ((System.Drawing.Image)(resources.GetObject("LoadingGif.InitialImage")));
            this.LoadingGif.Location = new System.Drawing.Point(206, 186);
            this.LoadingGif.MaximumSize = new System.Drawing.Size(150, 124);
            this.LoadingGif.MinimumSize = new System.Drawing.Size(75, 62);
            this.LoadingGif.Name = "LoadingGif";
            this.LoadingGif.Size = new System.Drawing.Size(103, 96);
            this.LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingGif.TabIndex = 5;
            this.LoadingGif.TabStop = false;
            this.LoadingGif.Visible = false;
            // 
            // exceptionTextBox
            // 
            this.exceptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exceptionTextBox.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exceptionTextBox.ForeColor = System.Drawing.Color.Red;
            this.exceptionTextBox.Location = new System.Drawing.Point(20, 186);
            this.exceptionTextBox.MaximumSize = new System.Drawing.Size(476, 96);
            this.exceptionTextBox.MinimumSize = new System.Drawing.Size(400, 62);
            this.exceptionTextBox.Name = "exceptionTextBox";
            this.exceptionTextBox.Size = new System.Drawing.Size(476, 96);
            this.exceptionTextBox.TabIndex = 6;
            this.exceptionTextBox.Text = "";
            this.exceptionTextBox.Visible = false;
            // 
            // getProductResponseBindingSource
            // 
            this.getProductResponseBindingSource.DataSource = typeof(inventory_api_wrapper.Models.GetProductResponse);
            // 
            // getPriceResponseBindingSource
            // 
            this.getPriceResponseBindingSource.DataSource = typeof(inventory_api_wrapper.Models.GetPriceResponse);
            // 
            // NewProductButton
            // 
            this.NewProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewProductButton.Location = new System.Drawing.Point(3, 422);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(163, 23);
            this.NewProductButton.TabIndex = 8;
            this.NewProductButton.Text = "Add new product";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // productListPanel
            // 
            this.productListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.productListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productListPanel.Controls.Add(this.label1);
            this.productListPanel.Controls.Add(this.ListProducts);
            this.productListPanel.Controls.Add(this.showLabel);
            this.productListPanel.Controls.Add(this.comboBox1);
            this.productListPanel.Controls.Add(this.LoadingGif);
            this.productListPanel.Controls.Add(this.DeleteProductButton);
            this.productListPanel.Controls.Add(this.NewProductButton);
            this.productListPanel.Controls.Add(this.searchButton);
            this.productListPanel.Controls.Add(this.searchBox);
            this.productListPanel.Controls.Add(this.exceptionTextBox);
            this.productListPanel.Controls.Add(this.ProductGridView);
            this.productListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListPanel.Location = new System.Drawing.Point(3, 3);
            this.productListPanel.MinimumSize = new System.Drawing.Size(500, 200);
            this.productListPanel.Name = "productListPanel";
            this.productListPanel.Size = new System.Drawing.Size(520, 452);
            this.productListPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "products";
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Location = new System.Drawing.Point(3, 7);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(36, 15);
            this.showLabel.TabIndex = 10;
            this.showLabel.Text = "Show";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // ProductTabControl
            // 
            this.ProductTabControl.Controls.Add(this.productsTabPage1);
            this.ProductTabControl.Controls.Add(this.productDetailsTabPage);
            this.ProductTabControl.Controls.Add(this.addProductTabPage);
            this.ProductTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductTabControl.Location = new System.Drawing.Point(0, 0);
            this.ProductTabControl.Name = "ProductTabControl";
            this.ProductTabControl.SelectedIndex = 0;
            this.ProductTabControl.Size = new System.Drawing.Size(534, 496);
            this.ProductTabControl.TabIndex = 10;
            // 
            // productsTabPage1
            // 
            this.productsTabPage1.Controls.Add(this.productListPanel);
            this.productsTabPage1.Location = new System.Drawing.Point(4, 24);
            this.productsTabPage1.Name = "productsTabPage1";
            this.productsTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage1.Size = new System.Drawing.Size(526, 458);
            this.productsTabPage1.TabIndex = 0;
            this.productsTabPage1.Text = "Stock list";
            // 
            // productDetailsTabPage
            // 
            this.productDetailsTabPage.Controls.Add(this.ProductDetailsGroupBox);
            this.productDetailsTabPage.Controls.Add(this.productTypePropertiesProductDetailsGroupBox);
            this.productDetailsTabPage.Controls.Add(this.vendorPropertiesProductDetailsGroupBox);
            this.productDetailsTabPage.Location = new System.Drawing.Point(4, 24);
            this.productDetailsTabPage.Name = "productDetailsTabPage";
            this.productDetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productDetailsTabPage.Size = new System.Drawing.Size(526, 468);
            this.productDetailsTabPage.TabIndex = 1;
            this.productDetailsTabPage.Text = "Product details";
            // 
            // ProductDetailsGroupBox
            // 
            this.ProductDetailsGroupBox.Controls.Add(this.cancelProductDetailsButton);
            this.ProductDetailsGroupBox.Controls.Add(this.editProductDetailsButton);
            this.ProductDetailsGroupBox.Controls.Add(this.saveProductDetailsButton);
            this.ProductDetailsGroupBox.Controls.Add(this.addNewVendorProductDetailsButton);
            this.ProductDetailsGroupBox.Controls.Add(this.productIdProductDetailsTextBox);
            this.ProductDetailsGroupBox.Controls.Add(this.vendorProductDetailsComboBox);
            this.ProductDetailsGroupBox.Controls.Add(this.productIdProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.addNewProductTypeProductDetailsButton);
            this.ProductDetailsGroupBox.Controls.Add(this.nameProductDetailsTextBox);
            this.ProductDetailsGroupBox.Controls.Add(this.nameProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.titleProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.titleProductDetailsTextBox);
            this.ProductDetailsGroupBox.Controls.Add(this.vendorProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.descriptionProductDetailsTextBox);
            this.ProductDetailsGroupBox.Controls.Add(this.productTypeProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.descriptionProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.productTypeProductDetailsComboBox);
            this.ProductDetailsGroupBox.Controls.Add(this.stockProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.currencyProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.stockProductDetailsTextBox);
            this.ProductDetailsGroupBox.Controls.Add(this.priceProductDetailsTextBox);
            this.ProductDetailsGroupBox.Controls.Add(this.barcodeProductDetailsLabel);
            this.ProductDetailsGroupBox.Controls.Add(this.currencyProductDetailsTextBox);
            this.ProductDetailsGroupBox.Controls.Add(this.barcodeProductDetailsTextBox);
            this.ProductDetailsGroupBox.Controls.Add(this.priceProductDetailsLabel);
            this.ProductDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductDetailsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.ProductDetailsGroupBox.Name = "ProductDetailsGroupBox";
            this.ProductDetailsGroupBox.Size = new System.Drawing.Size(497, 262);
            this.ProductDetailsGroupBox.TabIndex = 37;
            this.ProductDetailsGroupBox.TabStop = false;
            this.ProductDetailsGroupBox.Text = "Product properties";
            // 
            // cancelProductDetailsButton
            // 
            this.cancelProductDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelProductDetailsButton.Location = new System.Drawing.Point(6, 235);
            this.cancelProductDetailsButton.Name = "cancelProductDetailsButton";
            this.cancelProductDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.cancelProductDetailsButton.TabIndex = 1;
            this.cancelProductDetailsButton.Text = "Cancel";
            this.cancelProductDetailsButton.UseVisualStyleBackColor = true;
            this.cancelProductDetailsButton.Click += new System.EventHandler(this.cancelProductDetailsButton_Click);
            // 
            // editProductDetailsButton
            // 
            this.editProductDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductDetailsButton.Location = new System.Drawing.Point(416, 10);
            this.editProductDetailsButton.Name = "editProductDetailsButton";
            this.editProductDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.editProductDetailsButton.TabIndex = 0;
            this.editProductDetailsButton.Text = "Edit";
            this.editProductDetailsButton.UseVisualStyleBackColor = true;
            this.editProductDetailsButton.Click += new System.EventHandler(this.editProductDetailsButton_Click);
            // 
            // saveProductDetailsButton
            // 
            this.saveProductDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProductDetailsButton.Location = new System.Drawing.Point(422, 239);
            this.saveProductDetailsButton.Name = "saveProductDetailsButton";
            this.saveProductDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.saveProductDetailsButton.TabIndex = 2;
            this.saveProductDetailsButton.Text = "Save";
            this.saveProductDetailsButton.UseVisualStyleBackColor = true;
            this.saveProductDetailsButton.Click += new System.EventHandler(this.saveProductDetailsButton_Click);
            // 
            // addNewVendorProductDetailsButton
            // 
            this.addNewVendorProductDetailsButton.Location = new System.Drawing.Point(423, 207);
            this.addNewVendorProductDetailsButton.Name = "addNewVendorProductDetailsButton";
            this.addNewVendorProductDetailsButton.Size = new System.Drawing.Size(73, 23);
            this.addNewVendorProductDetailsButton.TabIndex = 40;
            this.addNewVendorProductDetailsButton.Text = "Add new";
            this.addNewVendorProductDetailsButton.UseVisualStyleBackColor = true;
            // 
            // productIdProductDetailsTextBox
            // 
            this.productIdProductDetailsTextBox.Location = new System.Drawing.Point(6, 74);
            this.productIdProductDetailsTextBox.Name = "productIdProductDetailsTextBox";
            this.productIdProductDetailsTextBox.Size = new System.Drawing.Size(157, 23);
            this.productIdProductDetailsTextBox.TabIndex = 4;
            // 
            // vendorProductDetailsComboBox
            // 
            this.vendorProductDetailsComboBox.FormattingEnabled = true;
            this.vendorProductDetailsComboBox.Location = new System.Drawing.Point(260, 207);
            this.vendorProductDetailsComboBox.Name = "vendorProductDetailsComboBox";
            this.vendorProductDetailsComboBox.Size = new System.Drawing.Size(157, 23);
            this.vendorProductDetailsComboBox.TabIndex = 39;
            // 
            // productIdProductDetailsLabel
            // 
            this.productIdProductDetailsLabel.AutoSize = true;
            this.productIdProductDetailsLabel.Location = new System.Drawing.Point(6, 56);
            this.productIdProductDetailsLabel.Name = "productIdProductDetailsLabel";
            this.productIdProductDetailsLabel.Size = new System.Drawing.Size(65, 15);
            this.productIdProductDetailsLabel.TabIndex = 3;
            this.productIdProductDetailsLabel.Text = "Product Id";
            // 
            // addNewProductTypeProductDetailsButton
            // 
            this.addNewProductTypeProductDetailsButton.Location = new System.Drawing.Point(169, 206);
            this.addNewProductTypeProductDetailsButton.Name = "addNewProductTypeProductDetailsButton";
            this.addNewProductTypeProductDetailsButton.Size = new System.Drawing.Size(73, 23);
            this.addNewProductTypeProductDetailsButton.TabIndex = 38;
            this.addNewProductTypeProductDetailsButton.Text = "Add new";
            this.addNewProductTypeProductDetailsButton.UseVisualStyleBackColor = true;
            // 
            // nameProductDetailsTextBox
            // 
            this.nameProductDetailsTextBox.Location = new System.Drawing.Point(181, 74);
            this.nameProductDetailsTextBox.Name = "nameProductDetailsTextBox";
            this.nameProductDetailsTextBox.Size = new System.Drawing.Size(157, 23);
            this.nameProductDetailsTextBox.TabIndex = 5;
            // 
            // nameProductDetailsLabel
            // 
            this.nameProductDetailsLabel.AutoSize = true;
            this.nameProductDetailsLabel.Location = new System.Drawing.Point(181, 56);
            this.nameProductDetailsLabel.Name = "nameProductDetailsLabel";
            this.nameProductDetailsLabel.Size = new System.Drawing.Size(40, 15);
            this.nameProductDetailsLabel.TabIndex = 6;
            this.nameProductDetailsLabel.Text = "Name";
            // 
            // titleProductDetailsLabel
            // 
            this.titleProductDetailsLabel.AutoSize = true;
            this.titleProductDetailsLabel.Location = new System.Drawing.Point(181, 100);
            this.titleProductDetailsLabel.Name = "titleProductDetailsLabel";
            this.titleProductDetailsLabel.Size = new System.Drawing.Size(32, 15);
            this.titleProductDetailsLabel.TabIndex = 7;
            this.titleProductDetailsLabel.Text = "Title";
            // 
            // titleProductDetailsTextBox
            // 
            this.titleProductDetailsTextBox.Location = new System.Drawing.Point(181, 118);
            this.titleProductDetailsTextBox.Name = "titleProductDetailsTextBox";
            this.titleProductDetailsTextBox.Size = new System.Drawing.Size(312, 23);
            this.titleProductDetailsTextBox.TabIndex = 8;
            // 
            // vendorProductDetailsLabel
            // 
            this.vendorProductDetailsLabel.AutoSize = true;
            this.vendorProductDetailsLabel.Location = new System.Drawing.Point(254, 188);
            this.vendorProductDetailsLabel.Name = "vendorProductDetailsLabel";
            this.vendorProductDetailsLabel.Size = new System.Drawing.Size(47, 15);
            this.vendorProductDetailsLabel.TabIndex = 22;
            this.vendorProductDetailsLabel.Text = "Vendor";
            // 
            // descriptionProductDetailsTextBox
            // 
            this.descriptionProductDetailsTextBox.Location = new System.Drawing.Point(181, 162);
            this.descriptionProductDetailsTextBox.Multiline = true;
            this.descriptionProductDetailsTextBox.Name = "descriptionProductDetailsTextBox";
            this.descriptionProductDetailsTextBox.Size = new System.Drawing.Size(312, 23);
            this.descriptionProductDetailsTextBox.TabIndex = 9;
            // 
            // productTypeProductDetailsLabel
            // 
            this.productTypeProductDetailsLabel.AutoSize = true;
            this.productTypeProductDetailsLabel.Location = new System.Drawing.Point(6, 188);
            this.productTypeProductDetailsLabel.Name = "productTypeProductDetailsLabel";
            this.productTypeProductDetailsLabel.Size = new System.Drawing.Size(80, 15);
            this.productTypeProductDetailsLabel.TabIndex = 21;
            this.productTypeProductDetailsLabel.Text = "Product Type";
            // 
            // descriptionProductDetailsLabel
            // 
            this.descriptionProductDetailsLabel.AutoSize = true;
            this.descriptionProductDetailsLabel.Location = new System.Drawing.Point(181, 144);
            this.descriptionProductDetailsLabel.Name = "descriptionProductDetailsLabel";
            this.descriptionProductDetailsLabel.Size = new System.Drawing.Size(71, 15);
            this.descriptionProductDetailsLabel.TabIndex = 10;
            this.descriptionProductDetailsLabel.Text = "Description";
            // 
            // productTypeProductDetailsComboBox
            // 
            this.productTypeProductDetailsComboBox.FormattingEnabled = true;
            this.productTypeProductDetailsComboBox.Location = new System.Drawing.Point(6, 206);
            this.productTypeProductDetailsComboBox.Name = "productTypeProductDetailsComboBox";
            this.productTypeProductDetailsComboBox.Size = new System.Drawing.Size(157, 23);
            this.productTypeProductDetailsComboBox.TabIndex = 19;
            // 
            // stockProductDetailsLabel
            // 
            this.stockProductDetailsLabel.AutoSize = true;
            this.stockProductDetailsLabel.Location = new System.Drawing.Point(6, 144);
            this.stockProductDetailsLabel.Name = "stockProductDetailsLabel";
            this.stockProductDetailsLabel.Size = new System.Drawing.Size(39, 15);
            this.stockProductDetailsLabel.TabIndex = 11;
            this.stockProductDetailsLabel.Text = "Stock";
            // 
            // currencyProductDetailsLabel
            // 
            this.currencyProductDetailsLabel.AutoSize = true;
            this.currencyProductDetailsLabel.Location = new System.Drawing.Point(344, 56);
            this.currencyProductDetailsLabel.Name = "currencyProductDetailsLabel";
            this.currencyProductDetailsLabel.Size = new System.Drawing.Size(57, 15);
            this.currencyProductDetailsLabel.TabIndex = 18;
            this.currencyProductDetailsLabel.Text = "Currency";
            // 
            // stockProductDetailsTextBox
            // 
            this.stockProductDetailsTextBox.Location = new System.Drawing.Point(6, 162);
            this.stockProductDetailsTextBox.Name = "stockProductDetailsTextBox";
            this.stockProductDetailsTextBox.Size = new System.Drawing.Size(157, 23);
            this.stockProductDetailsTextBox.TabIndex = 12;
            // 
            // priceProductDetailsTextBox
            // 
            this.priceProductDetailsTextBox.Location = new System.Drawing.Point(417, 74);
            this.priceProductDetailsTextBox.Name = "priceProductDetailsTextBox";
            this.priceProductDetailsTextBox.Size = new System.Drawing.Size(76, 23);
            this.priceProductDetailsTextBox.TabIndex = 17;
            // 
            // barcodeProductDetailsLabel
            // 
            this.barcodeProductDetailsLabel.AutoSize = true;
            this.barcodeProductDetailsLabel.Location = new System.Drawing.Point(6, 100);
            this.barcodeProductDetailsLabel.Name = "barcodeProductDetailsLabel";
            this.barcodeProductDetailsLabel.Size = new System.Drawing.Size(53, 15);
            this.barcodeProductDetailsLabel.TabIndex = 13;
            this.barcodeProductDetailsLabel.Text = "Barcode";
            // 
            // currencyProductDetailsTextBox
            // 
            this.currencyProductDetailsTextBox.Location = new System.Drawing.Point(344, 74);
            this.currencyProductDetailsTextBox.Name = "currencyProductDetailsTextBox";
            this.currencyProductDetailsTextBox.Size = new System.Drawing.Size(67, 23);
            this.currencyProductDetailsTextBox.TabIndex = 16;
            // 
            // barcodeProductDetailsTextBox
            // 
            this.barcodeProductDetailsTextBox.Location = new System.Drawing.Point(6, 118);
            this.barcodeProductDetailsTextBox.Name = "barcodeProductDetailsTextBox";
            this.barcodeProductDetailsTextBox.Size = new System.Drawing.Size(157, 23);
            this.barcodeProductDetailsTextBox.TabIndex = 14;
            // 
            // priceProductDetailsLabel
            // 
            this.priceProductDetailsLabel.AutoSize = true;
            this.priceProductDetailsLabel.Location = new System.Drawing.Point(417, 56);
            this.priceProductDetailsLabel.Name = "priceProductDetailsLabel";
            this.priceProductDetailsLabel.Size = new System.Drawing.Size(35, 15);
            this.priceProductDetailsLabel.TabIndex = 15;
            this.priceProductDetailsLabel.Text = "Price";
            // 
            // productTypePropertiesProductDetailsGroupBox
            // 
            this.productTypePropertiesProductDetailsGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.productTypePropertiesProductDetailsGroupBox.Controls.Add(this.productDescriptionProductDetailsTextBox);
            this.productTypePropertiesProductDetailsGroupBox.Controls.Add(this.productTypeNameProductDetailsTextBox);
            this.productTypePropertiesProductDetailsGroupBox.Controls.Add(this.productTypeIdProductDetailsLabel);
            this.productTypePropertiesProductDetailsGroupBox.Controls.Add(this.productTypeNameProductDetailsLabel);
            this.productTypePropertiesProductDetailsGroupBox.Controls.Add(this.productTypeIdProductDetailsTextBox);
            this.productTypePropertiesProductDetailsGroupBox.Controls.Add(this.productTypeDescriptionProductDetailsLabel);
            this.productTypePropertiesProductDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productTypePropertiesProductDetailsGroupBox.Location = new System.Drawing.Point(3, 274);
            this.productTypePropertiesProductDetailsGroupBox.Name = "productTypePropertiesProductDetailsGroupBox";
            this.productTypePropertiesProductDetailsGroupBox.Size = new System.Drawing.Size(248, 170);
            this.productTypePropertiesProductDetailsGroupBox.TabIndex = 36;
            this.productTypePropertiesProductDetailsGroupBox.TabStop = false;
            this.productTypePropertiesProductDetailsGroupBox.Text = "Product Type Properties";
            // 
            // productDescriptionProductDetailsTextBox
            // 
            this.productDescriptionProductDetailsTextBox.Location = new System.Drawing.Point(6, 134);
            this.productDescriptionProductDetailsTextBox.Name = "productDescriptionProductDetailsTextBox";
            this.productDescriptionProductDetailsTextBox.Size = new System.Drawing.Size(230, 23);
            this.productDescriptionProductDetailsTextBox.TabIndex = 26;
            // 
            // productTypeNameProductDetailsTextBox
            // 
            this.productTypeNameProductDetailsTextBox.Location = new System.Drawing.Point(6, 90);
            this.productTypeNameProductDetailsTextBox.Name = "productTypeNameProductDetailsTextBox";
            this.productTypeNameProductDetailsTextBox.Size = new System.Drawing.Size(230, 23);
            this.productTypeNameProductDetailsTextBox.TabIndex = 23;
            // 
            // productTypeIdProductDetailsLabel
            // 
            this.productTypeIdProductDetailsLabel.AutoSize = true;
            this.productTypeIdProductDetailsLabel.Location = new System.Drawing.Point(6, 28);
            this.productTypeIdProductDetailsLabel.Name = "productTypeIdProductDetailsLabel";
            this.productTypeIdProductDetailsLabel.Size = new System.Drawing.Size(94, 15);
            this.productTypeIdProductDetailsLabel.TabIndex = 33;
            this.productTypeIdProductDetailsLabel.Text = "Product Type Id";
            // 
            // productTypeNameProductDetailsLabel
            // 
            this.productTypeNameProductDetailsLabel.AutoSize = true;
            this.productTypeNameProductDetailsLabel.Location = new System.Drawing.Point(6, 72);
            this.productTypeNameProductDetailsLabel.Name = "productTypeNameProductDetailsLabel";
            this.productTypeNameProductDetailsLabel.Size = new System.Drawing.Size(40, 15);
            this.productTypeNameProductDetailsLabel.TabIndex = 24;
            this.productTypeNameProductDetailsLabel.Text = "Name";
            // 
            // productTypeIdProductDetailsTextBox
            // 
            this.productTypeIdProductDetailsTextBox.Location = new System.Drawing.Point(6, 46);
            this.productTypeIdProductDetailsTextBox.Name = "productTypeIdProductDetailsTextBox";
            this.productTypeIdProductDetailsTextBox.Size = new System.Drawing.Size(230, 23);
            this.productTypeIdProductDetailsTextBox.TabIndex = 32;
            // 
            // productTypeDescriptionProductDetailsLabel
            // 
            this.productTypeDescriptionProductDetailsLabel.AutoSize = true;
            this.productTypeDescriptionProductDetailsLabel.Location = new System.Drawing.Point(6, 116);
            this.productTypeDescriptionProductDetailsLabel.Name = "productTypeDescriptionProductDetailsLabel";
            this.productTypeDescriptionProductDetailsLabel.Size = new System.Drawing.Size(71, 15);
            this.productTypeDescriptionProductDetailsLabel.TabIndex = 25;
            this.productTypeDescriptionProductDetailsLabel.Text = "Description";
            // 
            // vendorPropertiesProductDetailsGroupBox
            // 
            this.vendorPropertiesProductDetailsGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vendorPropertiesProductDetailsGroupBox.Controls.Add(this.vendorNameProductDetailsTextBox);
            this.vendorPropertiesProductDetailsGroupBox.Controls.Add(this.vendorIdProductDetailsLabel);
            this.vendorPropertiesProductDetailsGroupBox.Controls.Add(this.vendorWebsiteProductDetailsTextBox);
            this.vendorPropertiesProductDetailsGroupBox.Controls.Add(this.vendorNameProductDetailsLabel);
            this.vendorPropertiesProductDetailsGroupBox.Controls.Add(this.vendorWebsiteProductDetailsLabel);
            this.vendorPropertiesProductDetailsGroupBox.Controls.Add(this.vendorIdProductDetailsTextBox);
            this.vendorPropertiesProductDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vendorPropertiesProductDetailsGroupBox.Location = new System.Drawing.Point(257, 274);
            this.vendorPropertiesProductDetailsGroupBox.Name = "vendorPropertiesProductDetailsGroupBox";
            this.vendorPropertiesProductDetailsGroupBox.Size = new System.Drawing.Size(245, 170);
            this.vendorPropertiesProductDetailsGroupBox.TabIndex = 35;
            this.vendorPropertiesProductDetailsGroupBox.TabStop = false;
            this.vendorPropertiesProductDetailsGroupBox.Text = "Vendor Properties";
            // 
            // vendorNameProductDetailsTextBox
            // 
            this.vendorNameProductDetailsTextBox.Location = new System.Drawing.Point(6, 88);
            this.vendorNameProductDetailsTextBox.Name = "vendorNameProductDetailsTextBox";
            this.vendorNameProductDetailsTextBox.Size = new System.Drawing.Size(233, 23);
            this.vendorNameProductDetailsTextBox.TabIndex = 27;
            // 
            // vendorIdProductDetailsLabel
            // 
            this.vendorIdProductDetailsLabel.AutoSize = true;
            this.vendorIdProductDetailsLabel.Location = new System.Drawing.Point(6, 26);
            this.vendorIdProductDetailsLabel.Name = "vendorIdProductDetailsLabel";
            this.vendorIdProductDetailsLabel.Size = new System.Drawing.Size(61, 15);
            this.vendorIdProductDetailsLabel.TabIndex = 34;
            this.vendorIdProductDetailsLabel.Text = "Vendor Id";
            // 
            // vendorWebsiteProductDetailsTextBox
            // 
            this.vendorWebsiteProductDetailsTextBox.Location = new System.Drawing.Point(6, 134);
            this.vendorWebsiteProductDetailsTextBox.Name = "vendorWebsiteProductDetailsTextBox";
            this.vendorWebsiteProductDetailsTextBox.Size = new System.Drawing.Size(233, 23);
            this.vendorWebsiteProductDetailsTextBox.TabIndex = 28;
            // 
            // vendorNameProductDetailsLabel
            // 
            this.vendorNameProductDetailsLabel.AutoSize = true;
            this.vendorNameProductDetailsLabel.Location = new System.Drawing.Point(6, 70);
            this.vendorNameProductDetailsLabel.Name = "vendorNameProductDetailsLabel";
            this.vendorNameProductDetailsLabel.Size = new System.Drawing.Size(40, 15);
            this.vendorNameProductDetailsLabel.TabIndex = 29;
            this.vendorNameProductDetailsLabel.Text = "Name";
            // 
            // vendorWebsiteProductDetailsLabel
            // 
            this.vendorWebsiteProductDetailsLabel.AutoSize = true;
            this.vendorWebsiteProductDetailsLabel.Location = new System.Drawing.Point(6, 114);
            this.vendorWebsiteProductDetailsLabel.Name = "vendorWebsiteProductDetailsLabel";
            this.vendorWebsiteProductDetailsLabel.Size = new System.Drawing.Size(53, 15);
            this.vendorWebsiteProductDetailsLabel.TabIndex = 30;
            this.vendorWebsiteProductDetailsLabel.Text = "Website";
            // 
            // vendorIdProductDetailsTextBox
            // 
            this.vendorIdProductDetailsTextBox.Location = new System.Drawing.Point(6, 44);
            this.vendorIdProductDetailsTextBox.Name = "vendorIdProductDetailsTextBox";
            this.vendorIdProductDetailsTextBox.Size = new System.Drawing.Size(233, 23);
            this.vendorIdProductDetailsTextBox.TabIndex = 31;
            // 
            // addProductTabPage
            // 
            this.addProductTabPage.Controls.Add(this.addNewProductDetailsButton);
            this.addProductTabPage.Controls.Add(this.CancelAddProductButton);
            this.addProductTabPage.Location = new System.Drawing.Point(4, 24);
            this.addProductTabPage.Name = "addProductTabPage";
            this.addProductTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addProductTabPage.Size = new System.Drawing.Size(644, 544);
            this.addProductTabPage.TabIndex = 2;
            this.addProductTabPage.Text = "Add Product";
            // 
            // addNewProductDetailsButton
            // 
            this.addNewProductDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewProductDetailsButton.Location = new System.Drawing.Point(618, 461);
            this.addNewProductDetailsButton.Name = "addNewProductDetailsButton";
            this.addNewProductDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.addNewProductDetailsButton.TabIndex = 3;
            this.addNewProductDetailsButton.Text = "Add";
            this.addNewProductDetailsButton.UseVisualStyleBackColor = true;
            this.addNewProductDetailsButton.Click += new System.EventHandler(this.addNewProductDetailsButton_Click);
            // 
            // CancelAddProductButton
            // 
            this.CancelAddProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelAddProductButton.Location = new System.Drawing.Point(6, 461);
            this.CancelAddProductButton.Name = "CancelAddProductButton";
            this.CancelAddProductButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddProductButton.TabIndex = 2;
            this.CancelAddProductButton.Text = "Cancel";
            this.CancelAddProductButton.UseVisualStyleBackColor = true;
            this.CancelAddProductButton.Click += new System.EventHandler(this.CancelAddProductButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 496);
            this.Controls.Add(this.ProductTabControl);
            this.MinimumSize = new System.Drawing.Size(550, 535);
            this.Name = "ProductListForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductResponseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPriceResponseBindingSource)).EndInit();
            this.productListPanel.ResumeLayout(false);
            this.productListPanel.PerformLayout();
            this.ProductTabControl.ResumeLayout(false);
            this.productsTabPage1.ResumeLayout(false);
            this.productDetailsTabPage.ResumeLayout(false);
            this.ProductDetailsGroupBox.ResumeLayout(false);
            this.ProductDetailsGroupBox.PerformLayout();
            this.productTypePropertiesProductDetailsGroupBox.ResumeLayout(false);
            this.productTypePropertiesProductDetailsGroupBox.PerformLayout();
            this.vendorPropertiesProductDetailsGroupBox.ResumeLayout(false);
            this.vendorPropertiesProductDetailsGroupBox.PerformLayout();
            this.addProductTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ListProducts;
        private DataGridView ProductGridView;
        private Button CancelAddProductButton;
        private TextBox searchBox;
        private BindingSource productsBindingSource;
        private Button DeleteProductButton;
        private PictureBox LoadingGif;
        private RichTextBox exceptionTextBox;
        private Button searchButton;
        private BindingSource getProductResponseBindingSource1;
        private BindingSource getProductResponseBindingSource;
        private BindingSource getPriceResponseBindingSource;
        private Button NewProductButton;
        private Panel productListPanel;
        private Label label1;
        private Label showLabel;
        private ComboBox comboBox1;
        private TabControl ProductTabControl;
        private TabPage productsTabPage1;
        private TabPage productDetailsTabPage;
        private TabPage addProductTabPage;
        private Button saveProductDetailsButton;
        private Button cancelProductDetailsButton;
        private Button editProductDetailsButton;
        private Button addNewProductDetailsButton;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridViewTextBoxColumn nameDQataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availableGridViewTextBoxColumn;
        private DataGridViewButtonColumn editProductButton;
        private TextBox stockProductDetailsTextBox;
        private Label stockProductDetailsLabel;
        private Label descriptionProductDetailsLabel;
        private TextBox descriptionProductDetailsTextBox;
        private TextBox titleProductDetailsTextBox;
        private Label titleProductDetailsLabel;
        private Label nameProductDetailsLabel;
        private TextBox nameProductDetailsTextBox;
        private TextBox productIdProductDetailsTextBox;
        private Label productIdProductDetailsLabel;
        private Label vendorIdProductDetailsLabel;
        private Label productTypeIdProductDetailsLabel;
        private TextBox productTypeIdProductDetailsTextBox;
        private TextBox vendorIdProductDetailsTextBox;
        private Label vendorWebsiteProductDetailsLabel;
        private Label vendorNameProductDetailsLabel;
        private TextBox vendorWebsiteProductDetailsTextBox;
        private TextBox vendorNameProductDetailsTextBox;
        private TextBox productDescriptionProductDetailsTextBox;
        private Label productTypeDescriptionProductDetailsLabel;
        private Label productTypeNameProductDetailsLabel;
        private TextBox productTypeNameProductDetailsTextBox;
        private Label vendorProductDetailsLabel;
        private Label productTypeProductDetailsLabel;
        private ComboBox productTypeProductDetailsComboBox;
        private Label currencyProductDetailsLabel;
        private TextBox priceProductDetailsTextBox;
        private TextBox currencyProductDetailsTextBox;
        private Label priceProductDetailsLabel;
        private TextBox barcodeProductDetailsTextBox;
        private Label barcodeProductDetailsLabel;
        private GroupBox ProductDetailsGroupBox;
        private GroupBox productTypePropertiesProductDetailsGroupBox;
        private GroupBox vendorPropertiesProductDetailsGroupBox;
        private Button addNewVendorProductDetailsButton;
        private ComboBox vendorProductDetailsComboBox;
        private Button addNewProductTypeProductDetailsButton;
    }
}