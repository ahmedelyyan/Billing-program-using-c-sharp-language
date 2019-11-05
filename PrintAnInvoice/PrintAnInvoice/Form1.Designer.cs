namespace PrintAnInvoice
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiseNumber = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtPrise = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuntety = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvInvioseIteam = new System.Windows.Forms.DataGridView();
            this.colteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvioseIteam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(354, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "شاشة الفاتوره - برمجة احمد الظواهره";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PrintAnInvoice.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(35, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(374, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "www.facebook.com/ahmad.althwaherh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(971, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "رقم الفاتوره :";
            // 
            // txtInvoiseNumber
            // 
            this.txtInvoiseNumber.ForeColor = System.Drawing.Color.Maroon;
            this.txtInvoiseNumber.Location = new System.Drawing.Point(683, 98);
            this.txtInvoiseNumber.Name = "txtInvoiseNumber";
            this.txtInvoiseNumber.Size = new System.Drawing.Size(264, 27);
            this.txtInvoiseNumber.TabIndex = 4;
            this.txtInvoiseNumber.Text = "1";
            this.txtInvoiseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvoiseNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiseNumber_KeyDown);
            // 
            // txtDate
            // 
            this.txtDate.ForeColor = System.Drawing.Color.Maroon;
            this.txtDate.Location = new System.Drawing.Point(253, 98);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(264, 27);
            this.txtDate.TabIndex = 6;
            this.txtDate.Text = "00000";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDate_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "التايخ:";
            // 
            // txtUserName
            // 
            this.txtUserName.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtUserName.Location = new System.Drawing.Point(253, 131);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(694, 27);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.Text = "الاسم";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(971, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم الزبون :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(2, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1071, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "_________________________________________________________________________________" +
    "________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(971, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "الصنف :";
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(558, 192);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(389, 27);
            this.comboBoxType.TabIndex = 11;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            this.comboBoxType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxType_KeyDown);
            // 
            // txtPrise
            // 
            this.txtPrise.ForeColor = System.Drawing.Color.Maroon;
            this.txtPrise.Location = new System.Drawing.Point(802, 225);
            this.txtPrise.Name = "txtPrise";
            this.txtPrise.Size = new System.Drawing.Size(145, 27);
            this.txtPrise.TabIndex = 13;
            this.txtPrise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrise.TextChanged += new System.EventHandler(this.txtPrise_TextChanged);
            this.txtPrise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrise_KeyDown);
            this.txtPrise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrise_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(971, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "السعر :";
            // 
            // txtQuntety
            // 
            this.txtQuntety.ForeColor = System.Drawing.Color.Maroon;
            this.txtQuntety.Location = new System.Drawing.Point(558, 225);
            this.txtQuntety.Name = "txtQuntety";
            this.txtQuntety.Size = new System.Drawing.Size(142, 27);
            this.txtQuntety.TabIndex = 15;
            this.txtQuntety.Text = "1";
            this.txtQuntety.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuntety.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuntety_KeyDown);
            this.txtQuntety.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuntety_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(712, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "الكميه :";
            // 
            // dgvInvioseIteam
            // 
            this.dgvInvioseIteam.AllowUserToAddRows = false;
            this.dgvInvioseIteam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvioseIteam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvioseIteam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvioseIteam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colteam,
            this.colQtt,
            this.colPrice,
            this.colSupTotal});
            this.dgvInvioseIteam.Location = new System.Drawing.Point(35, 269);
            this.dgvInvioseIteam.Name = "dgvInvioseIteam";
            this.dgvInvioseIteam.Size = new System.Drawing.Size(1000, 453);
            this.dgvInvioseIteam.TabIndex = 16;
            this.dgvInvioseIteam.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvioseIteam_CellEndEdit);
            // 
            // colteam
            // 
            this.colteam.HeaderText = "الصنف";
            this.colteam.Name = "colteam";
            this.colteam.ReadOnly = true;
            // 
            // colQtt
            // 
            this.colQtt.HeaderText = "الكميه";
            this.colQtt.Name = "colQtt";
            this.colQtt.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "سعر الوحدة";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colSupTotal
            // 
            this.colSupTotal.HeaderText = "الجمالي الفرعي";
            this.colSupTotal.Name = "colSupTotal";
            this.colSupTotal.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.BlueViolet;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.ForeColor = System.Drawing.Color.Gold;
            this.txtTotal.Location = new System.Drawing.Point(374, 225);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(130, 27);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "الاجمال";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Location = new System.Drawing.Point(35, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 60);
            this.panel1.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Olive;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(107, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "اظافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Olive;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Location = new System.Drawing.Point(16, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 39);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvInvioseIteam);
            this.Controls.Add(this.txtQuntety);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvoiseNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الفاتوره - برمجة احمد الظواهره";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvioseIteam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiseNumber;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txtPrise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuntety;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvInvioseIteam;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colteam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupTotal;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

