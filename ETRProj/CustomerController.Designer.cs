
namespace ETRProj
{
    partial class CustomerController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerController));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Custnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Custsex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Custage = new System.Windows.Forms.TextBox();
            this.CustDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.DeleteBtnCust = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditbtnCust = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtnCust = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Custname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Custnum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Custsex);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Custage);
            this.panel1.Controls.Add(this.CustDGV);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.DeleteBtnCust);
            this.panel1.Controls.Add(this.EditbtnCust);
            this.panel1.Controls.Add(this.AddBtnCust);
            this.panel1.Controls.Add(this.Custname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(22, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 739);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(932, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 50);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Custnum
            // 
            this.Custnum.Location = new System.Drawing.Point(667, 117);
            this.Custnum.Name = "Custnum";
            this.Custnum.Size = new System.Drawing.Size(189, 22);
            this.Custnum.TabIndex = 32;
            this.Custnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Custnum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(667, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F);
            this.label3.Location = new System.Drawing.Point(666, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sex";
            // 
            // Custsex
            // 
            this.Custsex.FormattingEnabled = true;
            this.Custsex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Custsex.Location = new System.Drawing.Point(665, 68);
            this.Custsex.Name = "Custsex";
            this.Custsex.Size = new System.Drawing.Size(189, 24);
            this.Custsex.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.Location = new System.Drawing.Point(377, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Age";
            // 
            // Custage
            // 
            this.Custage.Location = new System.Drawing.Point(375, 117);
            this.Custage.Name = "Custage";
            this.Custage.Size = new System.Drawing.Size(164, 22);
            this.Custage.TabIndex = 27;
            this.Custage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Custage_KeyPress);
            // 
            // CustDGV
            // 
            this.CustDGV.AllowUserToAddRows = false;
            this.CustDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CustDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CustDGV.ColumnHeadersHeight = 50;
            this.CustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.CustDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustDGV.Location = new System.Drawing.Point(100, 254);
            this.CustDGV.Name = "CustDGV";
            this.CustDGV.ReadOnly = true;
            this.CustDGV.RowHeadersVisible = false;
            this.CustDGV.RowHeadersWidth = 51;
            this.CustDGV.RowTemplate.Height = 24;
            this.CustDGV.Size = new System.Drawing.Size(1035, 458);
            this.CustDGV.TabIndex = 26;
            this.CustDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustDGV.ThemeStyle.HeaderStyle.Height = 50;
            this.CustDGV.ThemeStyle.ReadOnly = true;
            this.CustDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustDGV.ThemeStyle.RowsStyle.Height = 24;
            this.CustDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustDGV_CellContentClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(523, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(184, 26);
            this.label19.TabIndex = 25;
            this.label19.Text = "Customer List";
            // 
            // DeleteBtnCust
            // 
            this.DeleteBtnCust.ActiveBorderThickness = 1;
            this.DeleteBtnCust.ActiveCornerRadius = 20;
            this.DeleteBtnCust.ActiveFillColor = System.Drawing.Color.White;
            this.DeleteBtnCust.ActiveForecolor = System.Drawing.Color.Black;
            this.DeleteBtnCust.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtnCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.DeleteBtnCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtnCust.BackgroundImage")));
            this.DeleteBtnCust.ButtonText = "Delete";
            this.DeleteBtnCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtnCust.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtnCust.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtnCust.IdleBorderThickness = 1;
            this.DeleteBtnCust.IdleCornerRadius = 20;
            this.DeleteBtnCust.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.DeleteBtnCust.IdleForecolor = System.Drawing.Color.White;
            this.DeleteBtnCust.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteBtnCust.Location = new System.Drawing.Point(733, 156);
            this.DeleteBtnCust.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteBtnCust.Name = "DeleteBtnCust";
            this.DeleteBtnCust.Size = new System.Drawing.Size(181, 41);
            this.DeleteBtnCust.TabIndex = 24;
            this.DeleteBtnCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtnCust.Click += new System.EventHandler(this.DeleteBtnCust_Click);
            // 
            // EditbtnCust
            // 
            this.EditbtnCust.ActiveBorderThickness = 1;
            this.EditbtnCust.ActiveCornerRadius = 20;
            this.EditbtnCust.ActiveFillColor = System.Drawing.Color.White;
            this.EditbtnCust.ActiveForecolor = System.Drawing.Color.Black;
            this.EditbtnCust.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.EditbtnCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.EditbtnCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditbtnCust.BackgroundImage")));
            this.EditbtnCust.ButtonText = "Edit";
            this.EditbtnCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditbtnCust.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditbtnCust.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditbtnCust.IdleBorderThickness = 1;
            this.EditbtnCust.IdleCornerRadius = 20;
            this.EditbtnCust.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.EditbtnCust.IdleForecolor = System.Drawing.Color.White;
            this.EditbtnCust.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.EditbtnCust.Location = new System.Drawing.Point(516, 156);
            this.EditbtnCust.Margin = new System.Windows.Forms.Padding(5);
            this.EditbtnCust.Name = "EditbtnCust";
            this.EditbtnCust.Size = new System.Drawing.Size(181, 41);
            this.EditbtnCust.TabIndex = 23;
            this.EditbtnCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditbtnCust.Click += new System.EventHandler(this.EditbtnCust_Click);
            // 
            // AddBtnCust
            // 
            this.AddBtnCust.ActiveBorderThickness = 1;
            this.AddBtnCust.ActiveCornerRadius = 20;
            this.AddBtnCust.ActiveFillColor = System.Drawing.Color.White;
            this.AddBtnCust.ActiveForecolor = System.Drawing.Color.Black;
            this.AddBtnCust.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AddBtnCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.AddBtnCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtnCust.BackgroundImage")));
            this.AddBtnCust.ButtonText = "Add";
            this.AddBtnCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtnCust.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtnCust.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddBtnCust.IdleBorderThickness = 1;
            this.AddBtnCust.IdleCornerRadius = 20;
            this.AddBtnCust.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.AddBtnCust.IdleForecolor = System.Drawing.Color.White;
            this.AddBtnCust.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtnCust.Location = new System.Drawing.Point(283, 156);
            this.AddBtnCust.Margin = new System.Windows.Forms.Padding(5);
            this.AddBtnCust.Name = "AddBtnCust";
            this.AddBtnCust.Size = new System.Drawing.Size(181, 41);
            this.AddBtnCust.TabIndex = 22;
            this.AddBtnCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtnCust.Click += new System.EventHandler(this.AddBtnCust_Click);
            // 
            // Custname
            // 
            this.Custname.Location = new System.Drawing.Point(375, 68);
            this.Custname.Name = "Custname";
            this.Custname.Size = new System.Drawing.Size(164, 22);
            this.Custname.TabIndex = 6;
            this.Custname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Custname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(375, 44);
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
            this.label5.Size = new System.Drawing.Size(239, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customers Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(554, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 34);
            this.label8.TabIndex = 18;
            this.label8.Text = "Customers";
            // 
            // CustomerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Name = "CustomerController";
            this.Size = new System.Drawing.Size(1335, 889);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView CustDGV;
        private System.Windows.Forms.Label label19;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtnCust;
        private Bunifu.Framework.UI.BunifuThinButton2 EditbtnCust;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtnCust;
        private System.Windows.Forms.TextBox Custname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Custnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Custsex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Custage;
        private System.Windows.Forms.Button button1;
    }
}
