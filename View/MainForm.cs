using Controller.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.UserControls;
using System.IO;

namespace View
{
    public partial class MainForm : Form
    {
        protected UCBusqueda controlSearch = new UCBusqueda();
        protected UCProductos controlProducts = new UCProductos();
        protected ProductController controller = new ProductController();
        public MainForm()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }
        private void OnClick(object sender, EventArgs e)
        {
            var bt = (ToolStripItem)sender;

            switch (bt.Name)
            {
                case "ItemProducts":
                    this.Controls.Remove(controlSearch);
                    this.Controls.Add(controlProducts);
                    controlProducts.LoadController(controller);
                    this.ClientSize = new Size(controlProducts.Width, controlProducts.Height);
                    this.StartPosition = FormStartPosition.CenterParent;
                    controlProducts.Show();
                    break;

                case "ItemSearch":
                    this.Controls.Remove(controlProducts);
                    controlSearch.LoadController(controller);
                    this.Controls.Add(controlSearch);
                    this.StartPosition = FormStartPosition.CenterParent;
                    this.ClientSize = new System.Drawing.Size(controlSearch.Width, controlSearch.Height);
                    controlSearch.Show();
                    break;
            }
        }

        private void erroreslogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //cambiar el campo Release a Debug o Debug a Release segun sea el caso de ejecucion
                var ruta = Path.GetFullPath(Environment.CurrentDirectory)+ @"\Logs.txt";
                Process.Start("explorer.exe", ruta);

            }
            catch (Exception ex)
            {

            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var st = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
        }
    }
}
