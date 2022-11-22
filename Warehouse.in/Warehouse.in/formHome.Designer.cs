namespace Warehouse.@in
{
    partial class formHome
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateNow = new System.Windows.Forms.Label();
            this.timeNow = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome back, Admin!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Let’s start your inventory journey with us";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warehouse.@in.Properties.Resources.g10;
            this.pictureBox1.Location = new System.Drawing.Point(178, 188);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(832, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dateNow
            // 
            this.dateNow.AutoSize = true;
            this.dateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNow.ForeColor = System.Drawing.Color.White;
            this.dateNow.Location = new System.Drawing.Point(740, 39);
            this.dateNow.Name = "dateNow";
            this.dateNow.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dateNow.Size = new System.Drawing.Size(77, 29);
            this.dateNow.TabIndex = 6;
            this.dateNow.Text = "Date";
            // 
            // timeNow
            // 
            this.timeNow.AutoSize = true;
            this.timeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNow.ForeColor = System.Drawing.Color.White;
            this.timeNow.Location = new System.Drawing.Point(740, 68);
            this.timeNow.Name = "timeNow";
            this.timeNow.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.timeNow.Size = new System.Drawing.Size(83, 20);
            this.timeNow.TabIndex = 7;
            this.timeNow.Text = "22:22:22";
            this.timeNow.Click += new System.EventHandler(this.timeNow_Click_1);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1162, 853);
            this.Controls.Add(this.timeNow);
            this.Controls.Add(this.dateNow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formHome";
            this.Text = "formHome";
            this.Load += new System.EventHandler(this.formHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dateNow;
        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Timer timer;
    }
}