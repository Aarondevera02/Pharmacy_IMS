
namespace ETRProj
{
    partial class CategoryController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryController));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CatDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.DeleteBtnInventory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditbtnInventory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtnInventory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ProdNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(418, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(390, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "Add Product Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.DeleteBtnInventory);
            this.panel1.Controls.Add(this.EditbtnInventory);
            this.panel1.Controls.Add(this.AddBtnInventory);
            this.panel1.Controls.Add(this.ProdNametxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(25, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 739);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(976, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 50);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatDGV
            // 
            this.CatDGV.AllowUserToAddRows = false;
            this.CatDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CatDGV.ColumnHeadersHeight = 50;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CatDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.CatDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.Location = new System.Drawing.Point(100, 254);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.ReadOnly = true;
            this.CatDGV.RowHeadersVisible = false;
            this.CatDGV.RowHeadersWidth = 51;
            this.CatDGV.RowTemplate.Height = 24;
            this.CatDGV.Size = new System.Drawing.Size(1035, 458);
            this.CatDGV.TabIndex = 26;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CatDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CatDGV.ThemeStyle.HeaderStyle.Height = 50;
            this.CatDGV.ThemeStyle.ReadOnly = true;
            this.CatDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.ThemeStyle.RowsStyle.Height = 24;
            this.CatDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(521, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 26);
            this.label19.TabIndex = 25;
            this.label19.Text = "Category List";
            // 
            // DeleteBtnInventory
            // 
            this.DeleteBtnInventory.ActiveBorderThickness = 1;
            this.DeleteBtnInventory.ActiveCornerRadius = 20;
            this.DeleteBtnInventory.ActiveFillColor = System.Drawing.Color.White;
            this.DeleteBtnInventory.ActiveForecolor = System.Drawing.Color.Black;
            this.DeleteBtnInventory.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.DeleteBtnInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtnInventory.BackgroundImage")));
            this.DeleteBtnInventory.ButtonText = "Delete";
            this.DeleteBtnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtnInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtnInventory.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtnInventory.IdleBorderThickness = 1;
            this.DeleteBtnInventory.IdleCornerRadius = 20;
            this.DeleteBtnInventory.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.DeleteBtnInventory.IdleForecolor = System.Drawing.Color.White;
            this.DeleteBtnInventory.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteBtnInventory.Location = new System.Drawing.Point(778, 139);
            this.DeleteBtnInventory.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtnInventory.Name = "DeleteBtnInventory";
            this.DeleteBtnInventory.Size = new System.Drawing.Size(181, 41);
            this.DeleteBtnInventory.TabIndex = 24;
            this.DeleteBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtnInventory.Click += new System.EventHandler(this.DeleteBtnInventory_Click);
            // 
            // EditbtnInventory
            // 
            this.EditbtnInventory.ActiveBorderThickness = 1;
            this.EditbtnInventory.ActiveCornerRadius = 20;
            this.EditbtnInventory.ActiveFillColor = System.Drawing.Color.White;
            this.EditbtnInventory.ActiveForecolor = System.Drawing.Color.Black;
            this.EditbtnInventory.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.EditbtnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.EditbtnInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditbtnInventory.BackgroundImage")));
            this.EditbtnInventory.ButtonText = "Edit";
            this.EditbtnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditbtnInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditbtnInventory.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditbtnInventory.IdleBorderThickness = 1;
            this.EditbtnInventory.IdleCornerRadius = 20;
            this.EditbtnInventory.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.EditbtnInventory.IdleForecolor = System.Drawing.Color.White;
            this.EditbtnInventory.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.EditbtnInventory.Location = new System.Drawing.Point(516, 139);
            this.EditbtnInventory.Margin = new System.Windows.Forms.Padding(5);
            this.EditbtnInventory.Name = "EditbtnInventory";
            this.EditbtnInventory.Size = new System.Drawing.Size(181, 41);
            this.EditbtnInventory.TabIndex = 23;
            this.EditbtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditbtnInventory.Click += new System.EventHandler(this.EditbtnInventory_Click);
            // 
            // AddBtnInventory
            // 
            this.AddBtnInventory.ActiveBorderThickness = 1;
            this.AddBtnInventory.ActiveCornerRadius = 20;
            this.AddBtnInventory.ActiveFillColor = System.Drawing.Color.White;
            this.AddBtnInventory.ActiveForecolor = System.Drawing.Color.Black;
            this.AddBtnInventory.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AddBtnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.AddBtnInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtnInventory.BackgroundImage")));
            this.AddBtnInventory.ButtonText = "Add";
            this.AddBtnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtnInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtnInventory.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddBtnInventory.IdleBorderThickness = 1;
            this.AddBtnInventory.IdleCornerRadius = 20;
            this.AddBtnInventory.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.AddBtnInventory.IdleForecolor = System.Drawing.Color.White;
            this.AddBtnInventory.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtnInventory.Location = new System.Drawing.Point(243, 139);
            this.AddBtnInventory.Margin = new System.Windows.Forms.Padding(5);
            this.AddBtnInventory.Name = "AddBtnInventory";
            this.AddBtnInventory.Size = new System.Drawing.Size(181, 41);
            this.AddBtnInventory.TabIndex = 22;
            this.AddBtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtnInventory.Click += new System.EventHandler(this.AddBtnInventory_Click);
            // 
            // ProdNametxt
            // 
            this.ProdNametxt.Location = new System.Drawing.Point(494, 87);
            this.ProdNametxt.Name = "ProdNametxt";
            this.ProdNametxt.Size = new System.Drawing.Size(251, 22);
            this.ProdNametxt.TabIndex = 6;
            this.ProdNametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdNametxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(490, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Categories";
            // 
            // CategoryController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Name = "CategoryController";
            this.Size = new System.Drawing.Size(1335, 889);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView CatDGV;
        private System.Windows.Forms.Label label19;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtnInventory;
        private Bunifu.Framework.UI.BunifuThinButton2 EditbtnInventory;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtnInventory;
        private System.Windows.Forms.TextBox ProdNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
