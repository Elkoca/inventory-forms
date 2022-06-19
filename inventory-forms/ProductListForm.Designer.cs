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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            this.ProductGridView = new System.Windows.Forms.DataGridView();
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
            this.nameDQataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editProductButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductResponseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPriceResponseBindingSource)).BeginInit();
            this.productListPanel.SuspendLayout();
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
            this.ProductGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProductGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDQataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.articleNoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.availableGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.editProductButton});
            this.ProductGridView.DataSource = this.getProductResponseBindingSource1;
            this.ProductGridView.Location = new System.Drawing.Point(-2, 33);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowHeadersVisible = false;
            this.ProductGridView.RowTemplate.Height = 25;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(869, 422);
            this.ProductGridView.TabIndex = 1;
            this.ProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            this.ProductGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellDoubleClick);
            this.ProductGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductGridView_CellFormatting);
            this.ProductGridView.Sorted += new System.EventHandler(this.productGridView_SortedChange);
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
            this.ListProducts.Location = new System.Drawing.Point(378, 460);
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
            this.searchButton.Location = new System.Drawing.Point(795, 4);
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
            this.searchBox.Location = new System.Drawing.Point(642, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(147, 23);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.Location = new System.Drawing.Point(711, 461);
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
            this.LoadingGif.Location = new System.Drawing.Point(380, 205);
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
            this.exceptionTextBox.Location = new System.Drawing.Point(194, 205);
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
            this.NewProductButton.Location = new System.Drawing.Point(3, 461);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(163, 23);
            this.NewProductButton.TabIndex = 8;
            this.NewProductButton.Text = "Add new product";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // productListPanel
            // 
            this.productListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.productListPanel.Location = new System.Drawing.Point(12, 12);
            this.productListPanel.MinimumSize = new System.Drawing.Size(500, 200);
            this.productListPanel.Name = "productListPanel";
            this.productListPanel.Size = new System.Drawing.Size(869, 491);
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
            // availableGridViewTextBoxColumn
            // 
            this.availableGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.availableGridViewTextBoxColumn.HeaderText = "Available";
            this.availableGridViewTextBoxColumn.Name = "availableGridViewTextBoxColumn";
            this.availableGridViewTextBoxColumn.ReadOnly = true;
            this.availableGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.availableGridViewTextBoxColumn.Width = 75;
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
            // editProductButton
            // 
            this.editProductButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editProductButton.FillWeight = 1F;
            this.editProductButton.HeaderText = "Details/Edit";
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.ReadOnly = true;
            this.editProductButton.Width = 75;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 515);
            this.Controls.Add(this.productListPanel);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Button ListProducts;
        private DataGridView ProductGridView;
        private Button button1;
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
    }
}