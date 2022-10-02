using Model.Enums;
using System;

namespace View.UserControls
{
    partial class UCBusqueda
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
            this.cbCategories = new RJCodeAdvance.RJControls.RJComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategories
            // 
            this.cbCategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategories.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbCategories.BorderSize = 1;
            this.cbCategories.DataSource = Enum.GetValues(typeof(Categories));
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategories.ForeColor = System.Drawing.Color.DimGray;
            this.cbCategories.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbCategories.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbCategories.ListTextColor = System.Drawing.Color.DimGray;
            this.cbCategories.Location = new System.Drawing.Point(339, 75);
            this.cbCategories.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Padding = new System.Windows.Forms.Padding(1);
            this.cbCategories.Size = new System.Drawing.Size(200, 30);
            this.cbCategories.TabIndex = 0;
            this.cbCategories.Texts = "";
            this.cbCategories.OnSelectedIndexChanged += new System.EventHandler(this.cbCategories_OnSelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(571, 161);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione una categoria:";
            // 
            // UCBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCategories);
            this.Name = "UCBusqueda";
            this.Size = new System.Drawing.Size(632, 337);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJComboBox cbCategories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
