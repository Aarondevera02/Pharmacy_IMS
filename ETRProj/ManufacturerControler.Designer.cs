
namespace ETRProj
{
    partial class ManufacturerControler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufacturerControler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.ManufacturerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ManufListDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ManufListEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveButtonManuf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MedManAdd = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MedManPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MedManName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.ManufacturerDGV);
            this.panel1.Controls.Add(this.ManufListDelete);
            this.panel1.Controls.Add(this.ManufListEdit);
            this.panel1.Controls.Add(this.SaveButtonManuf);
            this.panel1.Controls.Add(this.MedManAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MedManPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MedManName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(22, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 739);
            this.panel1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(957, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 50);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(538, 288);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(233, 26);
            this.label19.TabIndex = 32;
            this.label19.Text = "Manufacturer List";
            // 
            // ManufacturerDGV
            // 
            this.ManufacturerDGV.AllowUserToAddRows = false;
            this.ManufacturerDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ManufacturerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ManufacturerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ManufacturerDGV.ColumnHeadersHeight = 50;
            this.ManufacturerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ManufacturerDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ManufacturerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ManufacturerDGV.Location = new System.Drawing.Point(181, 339);
            this.ManufacturerDGV.Name = "ManufacturerDGV";
            this.ManufacturerDGV.ReadOnly = true;
            this.ManufacturerDGV.RowHeadersVisible = false;
            this.ManufacturerDGV.RowHeadersWidth = 51;
            this.ManufacturerDGV.RowTemplate.Height = 24;
            this.ManufacturerDGV.Size = new System.Drawing.Size(869, 366);
            this.ManufacturerDGV.TabIndex = 31;
            this.ManufacturerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ManufacturerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ManufacturerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ManufacturerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ManufacturerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ManufacturerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ManufacturerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ManufacturerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ManufacturerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ManufacturerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ManufacturerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ManufacturerDGV.ThemeStyle.HeaderStyle.Height = 50;
            this.ManufacturerDGV.ThemeStyle.ReadOnly = true;
            this.ManufacturerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ManufacturerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ManufacturerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ManufacturerDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ManufacturerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ManufacturerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ManufacturerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManufacturerDGV_CellContentClick);
            // 
            // ManufListDelete
            // 
            this.ManufListDelete.ActiveBorderThickness = 1;
            this.ManufListDelete.ActiveCornerRadius = 20;
            this.ManufListDelete.ActiveFillColor = System.Drawing.Color.White;
            this.ManufListDelete.ActiveForecolor = System.Drawing.Color.Black;
            this.ManufListDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ManufListDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.ManufListDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManufListDelete.BackgroundImage")));
            this.ManufListDelete.ButtonText = "Delete";
            this.ManufListDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManufListDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufListDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.ManufListDelete.IdleBorderThickness = 1;
            this.ManufListDelete.IdleCornerRadius = 20;
            this.ManufListDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.ManufListDelete.IdleForecolor = System.Drawing.Color.White;
            this.ManufListDelete.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.ManufListDelete.Location = new System.Drawing.Point(762, 192);
            this.ManufListDelete.Margin = new System.Windows.Forms.Padding(5);
            this.ManufListDelete.Name = "ManufListDelete";
            this.ManufListDelete.Size = new System.Drawing.Size(181, 41);
            this.ManufListDelete.TabIndex = 30;
            this.ManufListDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManufListDelete.Click += new System.EventHandler(this.ManufListDelete_Click);
            // 
            // ManufListEdit
            // 
            this.ManufListEdit.ActiveBorderThickness = 1;
            this.ManufListEdit.ActiveCornerRadius = 20;
            this.ManufListEdit.ActiveFillColor = System.Drawing.Color.White;
            this.ManufListEdit.ActiveForecolor = System.Drawing.Color.Black;
            this.ManufListEdit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ManufListEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.ManufListEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManufListEdit.BackgroundImage")));
            this.ManufListEdit.ButtonText = "Edit";
            this.ManufListEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManufListEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufListEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.ManufListEdit.IdleBorderThickness = 1;
            this.ManufListEdit.IdleCornerRadius = 20;
            this.ManufListEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.ManufListEdit.IdleForecolor = System.Drawing.Color.White;
            this.ManufListEdit.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.ManufListEdit.Location = new System.Drawing.Point(523, 192);
            this.ManufListEdit.Margin = new System.Windows.Forms.Padding(5);
            this.ManufListEdit.Name = "ManufListEdit";
            this.ManufListEdit.Size = new System.Drawing.Size(181, 41);
            this.ManufListEdit.TabIndex = 29;
            this.ManufListEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManufListEdit.Click += new System.EventHandler(this.ManufListEdit_Click);
            // 
            // SaveButtonManuf
            // 
            this.SaveButtonManuf.ActiveBorderThickness = 1;
            this.SaveButtonManuf.ActiveCornerRadius = 20;
            this.SaveButtonManuf.ActiveFillColor = System.Drawing.Color.White;
            this.SaveButtonManuf.ActiveForecolor = System.Drawing.Color.Black;
            this.SaveButtonManuf.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SaveButtonManuf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.SaveButtonManuf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButtonManuf.BackgroundImage")));
            this.SaveButtonManuf.ButtonText = "Add";
            this.SaveButtonManuf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButtonManuf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonManuf.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveButtonManuf.IdleBorderThickness = 1;
            this.SaveButtonManuf.IdleCornerRadius = 20;
            this.SaveButtonManuf.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(93)))), ((int)(((byte)(213)))));
            this.SaveButtonManuf.IdleForecolor = System.Drawing.Color.White;
            this.SaveButtonManuf.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButtonManuf.Location = new System.Drawing.Point(287, 192);
            this.SaveButtonManuf.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButtonManuf.Name = "SaveButtonManuf";
            this.SaveButtonManuf.Size = new System.Drawing.Size(181, 41);
            this.SaveButtonManuf.TabIndex = 28;
            this.SaveButtonManuf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButtonManuf.Click += new System.EventHandler(this.SaveButtonManuf_Click);
            // 
            // MedManAdd
            // 
            this.MedManAdd.Location = new System.Drawing.Point(593, 70);
            this.MedManAdd.Name = "MedManAdd";
            this.MedManAdd.Size = new System.Drawing.Size(194, 96);
            this.MedManAdd.TabIndex = 27;
            this.MedManAdd.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F);
            this.label4.Location = new System.Drawing.Point(593, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Address";
            // 
            // MedManPhone
            // 
            this.MedManPhone.Location = new System.Drawing.Point(343, 137);
            this.MedManPhone.Name = "MedManPhone";
            this.MedManPhone.Size = new System.Drawing.Size(190, 22);
            this.MedManPhone.TabIndex = 16;
            this.MedManPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedManPhone_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.Location = new System.Drawing.Point(344, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone";
            // 
            // MedManName
            // 
            this.MedManName.Location = new System.Drawing.Point(343, 79);
            this.MedManName.Name = "MedManName";
            this.MedManName.Size = new System.Drawing.Size(190, 22);
            this.MedManName.TabIndex = 7;
            this.MedManName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedManName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(344, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manufacturer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manufacturer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(467, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 34);
            this.label8.TabIndex = 19;
            this.label8.Text = "Add Manufacturer";
            // 
            // ManufacturerControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "ManufacturerControler";
            this.Size = new System.Drawing.Size(1335, 889);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView ManufacturerDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 ManufListDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 ManufListEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveButtonManuf;
        private System.Windows.Forms.RichTextBox MedManAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MedManPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MedManName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
    }
}
