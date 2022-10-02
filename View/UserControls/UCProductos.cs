using Controller.Controller;
using Model.Entities;
using Model.Enums;
using Model.Logs;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.UserControls
{
    public partial class UCProductos : UserControl
    {
        protected ProductController controller = new ProductController();           
        protected string status = string.Empty;
      
        string pathFile = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Productos.txt";

        protected int i { get; set; }

        public UCProductos()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Optimize();
            CreateLogs.Exceptions = null;
            try
            {
                ProductViewModel model = new ProductViewModel()
                {
                    Id = controller.GenerarId(),
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    stock = Convert.ToInt32(txtStock.Text),
                    Category = cbCategorias.SelectedItem.ToString(),
                    Status = "Habilitado",
                };
                controller.Save(model);
                Clean();
                RefreshList();
                OnClick(sender, e);
            }
            catch(Exception ex)
            {
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex, MethodBase.GetCurrentMethod());

            }   
           
            
            if(CreateLogs.GetException() != null)
            {
                View.MessageBox.RJMessageBox.Show($"Ocurrio un error en el guardado {CreateLogs.GetException()}",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                View.MessageBox.RJMessageBox.Show($"Registro guardado exitosamente ",
                   "Accion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SaveFile()
        {

            if (!File.Exists(pathFile))
            {
                File.Create(pathFile);
            }
            controller.SaveInfo(pathFile);
            if(CreateLogs.GetException() != null)
            {
                View.MessageBox.RJMessageBox.Show($"Registros no se puediero guardar",
                  "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                View.MessageBox.RJMessageBox.Show($"Registros guardados exitosamente" +
                    $"Direccion del archivo: {pathFile}",
                   "Accion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var info = controller.Info(pathFile);
                lbName.Text = info[0];
                lbPath.Text = info[1];
                lbLenght.Text = info[2];
                lbExtention.Text = info[3];
            }
            


        }
        public void LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathFile = openFileDialog.FileName;
                var ls = controller.LoadProducts(openFileDialog.FileName);
                var info = controller.Info(openFileDialog.FileName);
                lbName.Text = info[0];
                lbPath.Text = info[1];
                lbLenght.Text = info[2];
                lbExtention.Text = info[3];
                dgvProducts.DataSource = ls;
            }
            
            if (CreateLogs.GetException() != null)
            {
                View.MessageBox.RJMessageBox.Show($"El archivo que intento abrir no es válido error {CreateLogs.GetException()}",
                    "Archivo Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void Clean()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtStock.Clear();
            txtPrice.Clear();
        }
        public void RefreshList()
        {
            dgvProducts.DataSource = null;
            var ls = controller.GetProducts();
            dgvProducts.DataSource = ls;
            dgvProducts.ClearSelection();
            if (ls.Count() != 0)
            {
                dgvProducts.Rows[dgvProducts.Rows.Count - 1].Selected = true;
            } 
                 
        }       

        private void btOpen_Click(object sender, EventArgs e)
        {
            Optimize();
            LoadFile();
        }
        public void LoadController(ProductController controller)
        {
            this.controller = controller;
           
        }

        private void btModifi_Click(object sender, EventArgs e)
        {
            Optimize();
            try
            {
                int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);
                var p = controller.GetProducts().First(x => x.Id == id);
                int index = controller.GetProducts().ToList().IndexOf(p);
                ProductViewModel model = new ProductViewModel()
                {
                    Id = id,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    stock = Convert.ToInt32(txtStock.Text),
                    Category = cbCategorias.SelectedItem.ToString(),
                    Status = LbStatus.Text,
                };
                controller.Update(model, index);
                RefreshList();
                OnClick(sender, e);
                Clean();
            }
            catch (Exception ex)
            {
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex, MethodBase.GetCurrentMethod());
            }
            
           
            if (CreateLogs.GetException() != null)
            {
                View.MessageBox.RJMessageBox.Show($"Ocurrio un error al actualizar {CreateLogs.GetException()}",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                View.MessageBox.RJMessageBox.Show($"Registro actualizado exitosamente",
                   "Accion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Optimize();
            try
            {
                int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);
                var p = controller.GetProducts().First(x => x.Id == id);
                controller.Delete<Product>(p);
                RefreshList();
                OnClick(sender, e);

                if (CreateLogs.GetException() != null)
                {
                    View.MessageBox.RJMessageBox.Show($"Ocurrio un error al borrar {CreateLogs.GetException()}",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    View.MessageBox.RJMessageBox.Show($"Registro elimando exitosamente",
                       "Accion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            catch(Exception ex)
            {
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex,MethodBase.GetCurrentMethod());
            }
                                 
            
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Optimize();
            try
            {
                int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);
                var items = controller.GetProducts().FirstOrDefault(x => x.Id == id);
                if (items != null)
                {
                    txtName.Text = items.Name;
                    txtDescription.Text = items.Description;
                    txtPrice.Text = items.Price.ToString();
                    txtStock.Text = items.stock.ToString();
                    LbStatus.Text = GetImageStatus(items);

                    foreach (var item in cbCategorias.Items)
                    {
                        if (item.ToString() == items.Category) { cbCategorias.SelectedItem = item; break; }
                    }
                    i = controller.GetProducts().ToList().IndexOf(items);
                }
            }
            catch(Exception ex)
            {
                CreateLogs.Exceptions = ex;
                CreateLogs.Create(ex, MethodBase.GetCurrentMethod());
            }
            
            
        }

        private void UCProductos_Load(object sender, EventArgs e)
        {
            this.cbCategorias.DataSource = Enum.GetValues(typeof(Categories));
            btExitAndSave.Enabled = false;
            cbCategorias.SelectedIndex = -1;
        }

        private void btExitAndSave_Click(object sender, EventArgs e)
        {
            SaveFile();
            
        }
        private void OnClick(object sender, EventArgs e)
        {
            var bt = (Button)sender;

            switch (bt.Name)
            {
                case "btModifi":
                    btExitAndSave.Enabled = true;     
                    break;  

                case "btDelete":
                    btExitAndSave.Enabled = true;
                    break;
                case "btSave":
                    btExitAndSave.Enabled = true;
                    break;
                
            }
        }
      
        private void btStatus_Click(object sender, EventArgs e)
        {
            Optimize();
            UpdateStatus(status);         
        }

        public string GetImageStatus(Product items)
        {
            if (items.Status == "Habilitado")
            {
                btStatus.Image = global::View.Properties.Resources.check;
                status = "Habilitado";
                return status;
            }
            else
            {
                btStatus.Image = global::View.Properties.Resources.Invalid_check;
                status = "Deshabilitado";
                return status;
            }
        }

        public void UpdateStatus(string statusImg)
        {
           
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);
            var item = controller.GetProducts().FirstOrDefault(x => x.Id == id);
            int index = controller.GetProducts().ToList().IndexOf(item);
            if (item != null && item.Status == "Habilitado")
            {
                btStatus.Image = global::View.Properties.Resources.Invalid_check;
                LbStatus.Text = "Deshabilitado";
                ProductViewModel model = new ProductViewModel()
                {
                    Id = id,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    stock = Convert.ToInt32(txtStock.Text),
                    Category = cbCategorias.SelectedItem.ToString(),
                    Status = "Deshabilitado",
                };
                controller.Update(model,index);
                RefreshList();
               
            }
            else
            {
                btStatus.Image = global::View.Properties.Resources.check;
                LbStatus.Text = "Habilitado";
                ProductViewModel model = new ProductViewModel()
                {
                    Id = id,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    stock = Convert.ToInt32(txtStock.Text),
                    Category = cbCategorias.SelectedItem.ToString(),
                    Status = "Habilitado",
                };
                controller.Update(model, index);
                RefreshList();

            }
        }

        public void Optimize()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
