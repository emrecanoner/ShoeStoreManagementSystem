namespace ShoeStore
{
    partial class Form18
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
            this.dgridshoppings = new System.Windows.Forms.DataGridView();
            this.lblproducts = new System.Windows.Forms.Label();
            this.lblssm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxsearch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tboxtproductname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxsellprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxlastname = new System.Windows.Forms.TextBox();
            this.tboxname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxsold = new System.Windows.Forms.TextBox();
            this.mtboxdate = new System.Windows.Forms.MaskedTextBox();
            this.btnqueries = new System.Windows.Forms.Button();
            this.pboxsettings = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridshoppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxsettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridshoppings
            // 
            this.dgridshoppings.AllowUserToAddRows = false;
            this.dgridshoppings.AllowUserToDeleteRows = false;
            this.dgridshoppings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridshoppings.Location = new System.Drawing.Point(61, 126);
            this.dgridshoppings.Name = "dgridshoppings";
            this.dgridshoppings.ReadOnly = true;
            this.dgridshoppings.Size = new System.Drawing.Size(764, 246);
            this.dgridshoppings.TabIndex = 76;
            this.dgridshoppings.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgridshoppings_CellMouseDoubleClick);
            // 
            // lblproducts
            // 
            this.lblproducts.AutoSize = true;
            this.lblproducts.Font = new System.Drawing.Font("Gilroy Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducts.ForeColor = System.Drawing.Color.White;
            this.lblproducts.Location = new System.Drawing.Point(341, 83);
            this.lblproducts.Name = "lblproducts";
            this.lblproducts.Size = new System.Drawing.Size(144, 31);
            this.lblproducts.TabIndex = 73;
            this.lblproducts.Text = "Shoppings";
            // 
            // lblssm
            // 
            this.lblssm.AutoSize = true;
            this.lblssm.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblssm.ForeColor = System.Drawing.Color.White;
            this.lblssm.Location = new System.Drawing.Point(217, 9);
            this.lblssm.Name = "lblssm";
            this.lblssm.Size = new System.Drawing.Size(449, 43);
            this.lblssm.TabIndex = 72;
            this.lblssm.Text = "Shoe Store Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 78;
            this.label1.Text = "Search By\r\nProduct Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tboxsearch
            // 
            this.tboxsearch.Location = new System.Drawing.Point(61, 94);
            this.tboxsearch.Name = "tboxsearch";
            this.tboxsearch.Size = new System.Drawing.Size(133, 20);
            this.tboxsearch.TabIndex = 77;
            this.tboxsearch.TextChanged += new System.EventHandler(this.tboxsearch_TextChanged);
            this.tboxsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxsearch_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(283, 436);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 18);
            this.label16.TabIndex = 110;
            this.label16.Text = "Product Name :";
            // 
            // tboxtproductname
            // 
            this.tboxtproductname.Enabled = false;
            this.tboxtproductname.Location = new System.Drawing.Point(410, 436);
            this.tboxtproductname.Name = "tboxtproductname";
            this.tboxtproductname.ReadOnly = true;
            this.tboxtproductname.Size = new System.Drawing.Size(130, 20);
            this.tboxtproductname.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(354, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 109;
            this.label4.Text = "Price :";
            // 
            // tboxsellprice
            // 
            this.tboxsellprice.Enabled = false;
            this.tboxsellprice.Location = new System.Drawing.Point(410, 462);
            this.tboxsellprice.Name = "tboxsellprice";
            this.tboxsellprice.ReadOnly = true;
            this.tboxsellprice.Size = new System.Drawing.Size(130, 20);
            this.tboxsellprice.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(310, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 108;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Name :";
            // 
            // tboxlastname
            // 
            this.tboxlastname.Enabled = false;
            this.tboxlastname.Location = new System.Drawing.Point(410, 410);
            this.tboxlastname.Name = "tboxlastname";
            this.tboxlastname.ReadOnly = true;
            this.tboxlastname.Size = new System.Drawing.Size(130, 20);
            this.tboxlastname.TabIndex = 104;
            // 
            // tboxname
            // 
            this.tboxname.Enabled = false;
            this.tboxname.Location = new System.Drawing.Point(410, 384);
            this.tboxname.Name = "tboxname";
            this.tboxname.ReadOnly = true;
            this.tboxname.Size = new System.Drawing.Size(130, 20);
            this.tboxname.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(354, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 117;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(359, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 119;
            this.label6.Text = "Sold :";
            // 
            // tboxsold
            // 
            this.tboxsold.Enabled = false;
            this.tboxsold.Location = new System.Drawing.Point(410, 514);
            this.tboxsold.Name = "tboxsold";
            this.tboxsold.ReadOnly = true;
            this.tboxsold.Size = new System.Drawing.Size(130, 20);
            this.tboxsold.TabIndex = 118;
            // 
            // mtboxdate
            // 
            this.mtboxdate.Enabled = false;
            this.mtboxdate.Location = new System.Drawing.Point(410, 488);
            this.mtboxdate.Mask = "00/00/0000";
            this.mtboxdate.Name = "mtboxdate";
            this.mtboxdate.ReadOnly = true;
            this.mtboxdate.Size = new System.Drawing.Size(130, 20);
            this.mtboxdate.TabIndex = 120;
            this.mtboxdate.ValidatingType = typeof(System.DateTime);
            // 
            // btnqueries
            // 
            this.btnqueries.BackColor = System.Drawing.Color.Black;
            this.btnqueries.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqueries.ForeColor = System.Drawing.Color.White;
            this.btnqueries.Location = new System.Drawing.Point(745, 495);
            this.btnqueries.Name = "btnqueries";
            this.btnqueries.Size = new System.Drawing.Size(122, 36);
            this.btnqueries.TabIndex = 121;
            this.btnqueries.Text = "Queries";
            this.btnqueries.UseVisualStyleBackColor = false;
            this.btnqueries.Click += new System.EventHandler(this.btnqueries_Click);
            // 
            // pboxsettings
            // 
            this.pboxsettings.Image = global::ShoeStore.Properties.Resources.shopping2;
            this.pboxsettings.Location = new System.Drawing.Point(544, 426);
            this.pboxsettings.Name = "pboxsettings";
            this.pboxsettings.Size = new System.Drawing.Size(62, 67);
            this.pboxsettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxsettings.TabIndex = 115;
            this.pboxsettings.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnback.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Image = global::ShoeStore.Properties.Resources.back__1_;
            this.btnback.Location = new System.Drawing.Point(812, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(55, 37);
            this.btnback.TabIndex = 75;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoeStore.Properties.Resources.shopping2;
            this.pictureBox1.Location = new System.Drawing.Point(478, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 543);
            this.Controls.Add(this.btnqueries);
            this.Controls.Add(this.mtboxdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxsold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pboxsettings);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tboxtproductname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxsellprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxlastname);
            this.Controls.Add(this.tboxname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxsearch);
            this.Controls.Add(this.dgridshoppings);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblproducts);
            this.Controls.Add(this.lblssm);
            this.Name = "Form18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoppings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form18_FormClosed);
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridshoppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxsettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridshoppings;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblproducts;
        private System.Windows.Forms.Label lblssm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxsearch;
        private System.Windows.Forms.PictureBox pboxsettings;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tboxtproductname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxsellprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxlastname;
        private System.Windows.Forms.TextBox tboxname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxsold;
        private System.Windows.Forms.MaskedTextBox mtboxdate;
        private System.Windows.Forms.Button btnqueries;
    }
}