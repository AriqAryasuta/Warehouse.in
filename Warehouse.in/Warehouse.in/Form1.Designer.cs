namespace Warehouse.@in
{
    partial class Homepage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.buttonProducts);
            this.panelMenu.Controls.Add(this.buttonRequest);
            this.panelMenu.Controls.Add(this.buttonStock);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(195, 681);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 162);
            this.panel1.TabIndex = 2;
            // 
            // buttonProducts
            // 
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.Image = global::Warehouse.@in.Properties.Resources.icons8_open_box_32;
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.Location = new System.Drawing.Point(0, 333);
            this.buttonProducts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(195, 57);
            this.buttonProducts.TabIndex = 5;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequest.Image = global::Warehouse.@in.Properties.Resources.icons8_unpacking_32;
            this.buttonRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequest.Location = new System.Drawing.Point(0, 276);
            this.buttonRequest.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(195, 57);
            this.buttonRequest.TabIndex = 4;
            this.buttonRequest.Text = "Request";
            this.buttonRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.Image = global::Warehouse.@in.Properties.Resources.icons8_shipping_product_32;
            this.buttonStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStock.Location = new System.Drawing.Point(0, 219);
            this.buttonStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(195, 57);
            this.buttonStock.TabIndex = 3;
            this.buttonStock.Text = "Stock";
            this.buttonStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = global::Warehouse.@in.Properties.Resources.icons8_home_page_32;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 162);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(195, 57);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Warehouse.@in.Properties.Resources.Screenshot_2022_11_01_214456;
            this.pictureBox2.Location = new System.Drawing.Point(22, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(195, 0);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1069, 681);
            this.panelDesktopPanel.TabIndex = 1;
            // 
            // Homepage
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Homepage";
            this.Text = "Warehouse.in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}

