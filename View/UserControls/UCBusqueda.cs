using Controller.Controller;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.UserControls
{
    public partial class UCBusqueda : UserControl
    {
        protected ProductController controller;

        public UCBusqueda()
        {
            InitializeComponent();
            
        }
        public void LoadController(ProductController controller)
        {
            this.controller = controller;

        }

        private void cbCategories_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<Product> product = controller.GetProducts().Where(x => x.Category == cbCategories.SelectedItem.ToString());
            dataGridView1.DataSource = product.ToList();
        }
    }
}
