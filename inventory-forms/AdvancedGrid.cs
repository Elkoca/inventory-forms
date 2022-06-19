using inventory_api_wrapper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_forms
{
    public partial class AdvancedGrid : Form
    {
        public AdvancedGrid(List<Products> products)
        {
            InitializeComponent();
            advancedDataGridView1.DataSource = products;
            //advancedDataGridViewSearchToolBar1.
            //advancedDataGridView1.filter
        }

        private void advancedDataGridViewSearchToolBar1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
