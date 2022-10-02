using Model.Enums;
using System;

namespace View.UserControls
{
    partial class UCProductos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExitAndSave = new RJCodeAdvance.RJControls.RJButton();
            this.btDelete = new RJCodeAdvance.RJControls.RJButton();
            this.btSave = new RJCodeAdvance.RJControls.RJButton();
            this.btModifi = new RJCodeAdvance.RJControls.RJButton();
            this.btOpen = new RJCodeAdvance.RJControls.RJButton();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCategorias = new RJCodeAdvance.RJControls.RJComboBox();
            this.lbExtention = new System.Windows.Forms.Label();
            this.lbLenght = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btStatus = new System.Windows.Forms.PictureBox();
            this.LbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.inventario;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.btExitAndSave);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btModifi);
            this.panel1.Controls.Add(this.btOpen);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 578);
            this.panel1.TabIndex = 1;
            // 
            // btExitAndSave
            // 
            this.btExitAndSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btExitAndSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btExitAndSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btExitAndSave.BorderRadius = 0;
            this.btExitAndSave.BorderSize = 0;
            this.btExitAndSave.FlatAppearance.BorderSize = 0;
            this.btExitAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExitAndSave.ForeColor = System.Drawing.Color.White;
            this.btExitAndSave.Location = new System.Drawing.Point(34, 506);
            this.btExitAndSave.Name = "btExitAndSave";
            this.btExitAndSave.Size = new System.Drawing.Size(150, 40);
            this.btExitAndSave.TabIndex = 6;
            this.btExitAndSave.Text = "Guardar archivo";
            this.btExitAndSave.TextColor = System.Drawing.Color.White;
            this.btExitAndSave.UseVisualStyleBackColor = false;
            this.btExitAndSave.Click += new System.EventHandler(this.btExitAndSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDelete.BorderRadius = 0;
            this.btDelete.BorderSize = 0;
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(34, 320);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(150, 40);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Borrar";
            this.btDelete.TextColor = System.Drawing.Color.White;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSave.BorderRadius = 0;
            this.btSave.BorderSize = 0;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(34, 378);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(150, 40);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Guardar";
            this.btSave.TextColor = System.Drawing.Color.White;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btModifi
            // 
            this.btModifi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btModifi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btModifi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btModifi.BorderRadius = 0;
            this.btModifi.BorderSize = 0;
            this.btModifi.FlatAppearance.BorderSize = 0;
            this.btModifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModifi.ForeColor = System.Drawing.Color.White;
            this.btModifi.Location = new System.Drawing.Point(34, 261);
            this.btModifi.Name = "btModifi";
            this.btModifi.Size = new System.Drawing.Size(150, 40);
            this.btModifi.TabIndex = 3;
            this.btModifi.Text = "Actualizar";
            this.btModifi.TextColor = System.Drawing.Color.White;
            this.btModifi.UseVisualStyleBackColor = false;
            this.btModifi.Click += new System.EventHandler(this.btModifi_Click);
            // 
            // btOpen
            // 
            this.btOpen.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btOpen.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btOpen.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btOpen.BorderRadius = 0;
            this.btOpen.BorderSize = 0;
            this.btOpen.FlatAppearance.BorderSize = 0;
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.ForeColor = System.Drawing.Color.White;
            this.btOpen.Location = new System.Drawing.Point(34, 205);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(150, 40);
            this.btOpen.TabIndex = 2;
            this.btOpen.Text = "Abrir";
            this.btOpen.TextColor = System.Drawing.Color.White;
            this.btOpen.UseVisualStyleBackColor = false;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(247, 285);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(642, 269);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(744, 43);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 21);
            this.lblCategory.TabIndex = 31;
            this.lblCategory.Text = "Categoria:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(354, 229);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 21);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "Precio:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(335, 160);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(75, 21);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Cantidad:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(247, 98);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(186, 21);
            this.lblDescription.TabIndex = 28;
            this.lblDescription.Text = "Descripción del Producto:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(247, 43);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(163, 21);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Nombre del Producto:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(445, 155);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "Cantidad";
            this.txtStock.Size = new System.Drawing.Size(211, 26);
            this.txtStock.TabIndex = 25;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(445, 231);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Precio";
            this.txtPrice.Size = new System.Drawing.Size(211, 26);
            this.txtPrice.TabIndex = 24;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(445, 98);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Descripción";
            this.txtDescription.Size = new System.Drawing.Size(211, 42);
            this.txtDescription.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(445, 45);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Nombre";
            this.txtName.Size = new System.Drawing.Size(211, 26);
            this.txtName.TabIndex = 22;
            // 
            // cbCategorias
            // 
            this.cbCategorias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategorias.BorderColor = System.Drawing.Color.Black;
            this.cbCategorias.BorderSize = 1;
            this.cbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCategorias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategorias.ForeColor = System.Drawing.Color.DimGray;
            this.cbCategorias.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbCategorias.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbCategorias.ListTextColor = System.Drawing.Color.DimGray;
            this.cbCategorias.Location = new System.Drawing.Point(701, 98);
            this.cbCategorias.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Padding = new System.Windows.Forms.Padding(1);
            this.cbCategorias.Size = new System.Drawing.Size(200, 30);
            this.cbCategorias.TabIndex = 32;
            this.cbCategorias.Texts = "";
            // 
            // lbExtention
            // 
            this.lbExtention.AutoSize = true;
            this.lbExtention.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbExtention.Location = new System.Drawing.Point(875, 567);
            this.lbExtention.Name = "lbExtention";
            this.lbExtention.Size = new System.Drawing.Size(35, 13);
            this.lbExtention.TabIndex = 40;
            this.lbExtention.Text = "-------";
            // 
            // lbLenght
            // 
            this.lbLenght.AutoSize = true;
            this.lbLenght.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLenght.Location = new System.Drawing.Point(710, 567);
            this.lbLenght.Name = "lbLenght";
            this.lbLenght.Size = new System.Drawing.Size(35, 13);
            this.lbLenght.TabIndex = 39;
            this.lbLenght.Text = "-------";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPath.Location = new System.Drawing.Point(549, 567);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(35, 13);
            this.lbPath.TabIndex = 38;
            this.lbPath.Text = "-------";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(357, 567);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 37;
            this.lbName.Text = "-------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(789, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Extension:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(444, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Directorio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(628, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tamaño:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre del archivo:";
            // 
            // btStatus
            // 
            this.btStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStatus.Location = new System.Drawing.Point(762, 184);
            this.btStatus.Name = "btStatus";
            this.btStatus.Size = new System.Drawing.Size(62, 56);
            this.btStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btStatus.TabIndex = 7;
            this.btStatus.TabStop = false;
            this.btStatus.Click += new System.EventHandler(this.btStatus_Click);
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Location = new System.Drawing.Point(762, 254);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(0, 15);
            this.LbStatus.TabIndex = 41;
            // 
            // UCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.btStatus);
            this.Controls.Add(this.lbExtention);
            this.Controls.Add(this.lbLenght);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Name = "UCProductos";
            this.Size = new System.Drawing.Size(936, 602);
            this.Load += new System.EventHandler(this.UCProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btOpen;
        private RJCodeAdvance.RJControls.RJButton btDelete;
        private RJCodeAdvance.RJControls.RJButton btSave;
        private RJCodeAdvance.RJControls.RJButton btModifi;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private RJCodeAdvance.RJControls.RJComboBox cbCategorias;
        private System.Windows.Forms.Label lbExtention;
        private System.Windows.Forms.Label lbLenght;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton btExitAndSave;
        private System.Windows.Forms.PictureBox btStatus;
        private System.Windows.Forms.Label LbStatus;
    }
}
