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
            this.saveProductDetailsButton = new System.Windows.Forms.Button();
            this.cancelProductDetailsButton = new System.Windows.Forms.Button();
            this.editProductDetailsButton = new System.Windows.Forms.Button();
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
            this.ProductGridView.Size = new System.Drawing.Size(693, 414);
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
            this.createdDataGridViewTextBoxColumn.HeaderText = "Release Date";
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
            this.ListProducts.Location = new System.Drawing.Point(290, 453);
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
            this.searchButton.Location = new System.Drawing.Point(619, 4);
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
            this.searchBox.Location = new System.Drawing.Point(466, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(147, 23);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.Location = new System.Drawing.Point(535, 454);
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
            this.LoadingGif.Location = new System.Drawing.Point(292, 202);
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
            this.exceptionTextBox.Location = new System.Drawing.Point(106, 202);
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
            this.NewProductButton.Location = new System.Drawing.Point(3, 454);
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
            this.productListPanel.Size = new System.Drawing.Size(693, 484);
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
            this.ProductTabControl.Size = new System.Drawing.Size(707, 518);
            this.ProductTabControl.TabIndex = 10;
            // 
            // productsTabPage1
            // 
            this.productsTabPage1.Controls.Add(this.productListPanel);
            this.productsTabPage1.Location = new System.Drawing.Point(4, 24);
            this.productsTabPage1.Name = "productsTabPage1";
            this.productsTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage1.Size = new System.Drawing.Size(699, 490);
            this.productsTabPage1.TabIndex = 0;
            this.productsTabPage1.Text = "Stock list";
            // 
            // productDetailsTabPage
            // 
            this.productDetailsTabPage.Controls.Add(this.saveProductDetailsButton);
            this.productDetailsTabPage.Controls.Add(this.cancelProductDetailsButton);
            this.productDetailsTabPage.Controls.Add(this.editProductDetailsButton);
            this.productDetailsTabPage.Location = new System.Drawing.Point(4, 24);
            this.productDetailsTabPage.Name = "productDetailsTabPage";
            this.productDetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productDetailsTabPage.Size = new System.Drawing.Size(699, 490);
            this.productDetailsTabPage.TabIndex = 1;
            this.productDetailsTabPage.Text = "Product details";
            // 
            // saveProductDetailsButton
            // 
            this.saveProductDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProductDetailsButton.Location = new System.Drawing.Point(618, 461);
            this.saveProductDetailsButton.Name = "saveProductDetailsButton";
            this.saveProductDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.saveProductDetailsButton.TabIndex = 2;
            this.saveProductDetailsButton.Text = "Save";
            this.saveProductDetailsButton.UseVisualStyleBackColor = true;
            this.saveProductDetailsButton.Click += new System.EventHandler(this.saveProductDetailsButton_Click);
            // 
            // cancelProductDetailsButton
            // 
            this.cancelProductDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelProductDetailsButton.Location = new System.Drawing.Point(6, 461);
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
            this.editProductDetailsButton.Location = new System.Drawing.Point(618, 6);
            this.editProductDetailsButton.Name = "editProductDetailsButton";
            this.editProductDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.editProductDetailsButton.TabIndex = 0;
            this.editProductDetailsButton.Text = "Edit";
            this.editProductDetailsButton.UseVisualStyleBackColor = true;
            this.editProductDetailsButton.Click += new System.EventHandler(this.editProductDetailsButton_Click);
            // 
            // addProductTabPage
            // 
            this.addProductTabPage.Controls.Add(this.addNewProductDetailsButton);
            this.addProductTabPage.Controls.Add(this.CancelAddProductButton);
            this.addProductTabPage.Location = new System.Drawing.Point(4, 24);
            this.addProductTabPage.Name = "addProductTabPage";
            this.addProductTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addProductTabPage.Size = new System.Drawing.Size(699, 490);
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
            this.ClientSize = new System.Drawing.Size(707, 518);
            this.Controls.Add(this.ProductTabControl);
            this.MinimumSize = new System.Drawing.Size(550, 300);
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
        private DataGridViewTextBoxColumn nameDQataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availableGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn editProductButton;
        private TabControl ProductTabControl;
        private TabPage productsTabPage1;
        private TabPage productDetailsTabPage;
        private TabPage addProductTabPage;
        private Button saveProductDetailsButton;
        private Button cancelProductDetailsButton;
        private Button editProductDetailsButton;
        private Button addNewProductDetailsButton;
        private ContextMenuStrip contextMenuStrip1;
    }
}