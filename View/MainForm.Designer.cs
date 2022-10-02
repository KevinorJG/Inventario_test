namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MnStrip = new System.Windows.Forms.MenuStrip();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erroreslogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnStrip
            // 
            this.MnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.ItemSearch,
            this.informaciónToolStripMenuItem});
            this.MnStrip.Location = new System.Drawing.Point(0, 0);
            this.MnStrip.Name = "MnStrip";
            this.MnStrip.Size = new System.Drawing.Size(629, 24);
            this.MnStrip.TabIndex = 1;
            this.MnStrip.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemProducts});
            this.catalogoToolStripMenuItem.Image = global::View.Properties.Resources.catalog;
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // ItemProducts
            // 
            this.ItemProducts.Image = global::View.Properties.Resources.box;
            this.ItemProducts.Name = "ItemProducts";
            this.ItemProducts.Size = new System.Drawing.Size(128, 22);
            this.ItemProducts.Text = "Productos";
            this.ItemProducts.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // ItemSearch
            // 
            this.ItemSearch.Image = global::View.Properties.Resources.seo;
            this.ItemSearch.Name = "ItemSearch";
            this.ItemSearch.Size = new System.Drawing.Size(87, 20);
            this.ItemSearch.Text = "Busqueda";
            this.ItemSearch.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erroreslogsToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // erroreslogsToolStripMenuItem
            // 
            this.erroreslogsToolStripMenuItem.Name = "erroreslogsToolStripMenuItem";
            this.erroreslogsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.erroreslogsToolStripMenuItem.Text = "Errores (logs)";
            this.erroreslogsToolStripMenuItem.Click += new System.EventHandler(this.erroreslogsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 347);
            this.Controls.Add(this.MnStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MnStrip.ResumeLayout(false);
            this.MnStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnStrip;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemProducts;
        private System.Windows.Forms.ToolStripMenuItem ItemSearch;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erroreslogsToolStripMenuItem;
    }
}