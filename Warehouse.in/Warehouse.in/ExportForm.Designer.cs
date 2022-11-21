namespace Warehouse.@in
{
    partial class ExportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbCategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tbCategory = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Controls.Add(this.tbCategory);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.tbQuantity);
            this.panel1.Controls.Add(this.kryptonLabel3);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 853);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Location = new System.Drawing.Point(955, 142);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.btnFilter.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.btnFilter.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFilter.OverrideDefault.Border.Rounding = 10;
            this.btnFilter.Size = new System.Drawing.Size(172, 33);
            this.btnFilter.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.btnFilter.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.btnFilter.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFilter.StateCommon.Border.Rounding = 10;
            this.btnFilter.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnFilter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.btnFilter.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.btnFilter.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.btnFilter.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.btnFilter.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFilter.StateTracking.Border.Rounding = 10;
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Values.Text = "FILTER";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownWidth = 296;
            this.cbCategory.Items.AddRange(new object[] {
            "food",
            "beverages",
            "furniture"});
            this.cbCategory.Location = new System.Drawing.Point(570, 142);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(377, 31);
            this.cbCategory.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbCategory.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbCategory.TabIndex = 16;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 98);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1519, 12);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.kryptonPanel1.TabIndex = 15;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(206, 271);
            this.tbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(332, 33);
            this.tbCategory.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCategory.StateCommon.Border.Rounding = 10;
            this.tbCategory.TabIndex = 14;
            this.tbCategory.TextChanged += new System.EventHandler(this.tbCategory_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(206, 199);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(332, 33);
            this.tbName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbName.StateCommon.Border.Rounding = 10;
            this.tbName.TabIndex = 13;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(43, 433);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.btnExport.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.btnExport.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.OverrideDefault.Border.Rounding = 10;
            this.btnExport.Size = new System.Drawing.Size(495, 46);
            this.btnExport.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.btnExport.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.btnExport.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.StateCommon.Border.Rounding = 10;
            this.btnExport.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.btnExport.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.btnExport.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.btnExport.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.btnExport.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.StateTracking.Border.Rounding = 10;
            this.btnExport.TabIndex = 10;
            this.btnExport.Values.Text = "EXPORT";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(206, 343);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(332, 33);
            this.tbQuantity.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbQuantity.StateCommon.Border.Rounding = 10;
            this.tbQuantity.TabIndex = 8;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(16, 34);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(206, 57);
            this.kryptonLabel3.StateCommon.LongText.Color1 = System.Drawing.Color.Transparent;
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "EXPORT";
            this.kryptonLabel3.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel3_Paint);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(43, 343);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(145, 32);
            this.kryptonLabel2.StateCommon.LongText.Color1 = System.Drawing.Color.Transparent;
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Quantity     :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(43, 271);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(146, 32);
            this.kryptonLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Transparent;
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Category    :";
            // 
            // lblName
            // 
            this.lblName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblName.Location = new System.Drawing.Point(43, 199);
            this.lblName.Margin = new System.Windows.Forms.Padding(4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 32);
            this.lblName.StateCommon.LongText.Color1 = System.Drawing.Color.Transparent;
            this.lblName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.TabIndex = 2;
            this.lblName.Values.Text = "Name         :";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(570, 196);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(557, 583);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 853);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.Shown += new System.EventHandler(this.ExportForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
    private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbQuantity;
    private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
    private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
    private System.Windows.Forms.DataGridView dgvData;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCategory;
    }
}