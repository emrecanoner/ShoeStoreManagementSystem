namespace ShoeStore
{
    partial class Form12
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
            this.lblproducts = new System.Windows.Forms.Label();
            this.lblssm = new System.Windows.Forms.Label();
            this.dgridproducts = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.tboxavailable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxsellprice = new System.Windows.Forms.TextBox();
            this.tboxbuyprice = new System.Windows.Forms.TextBox();
            this.tboxname = new System.Windows.Forms.TextBox();
            this.tboxsize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.cboxsex = new System.Windows.Forms.ComboBox();
            this.cboxbrand = new System.Windows.Forms.ComboBox();
            this.cboxpurpose = new System.Windows.Forms.ComboBox();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tboxsold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproducts
            // 
            this.lblproducts.AutoSize = true;
            this.lblproducts.Font = new System.Drawing.Font("Gilroy Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducts.ForeColor = System.Drawing.Color.White;
            this.lblproducts.Location = new System.Drawing.Point(359, 83);
            this.lblproducts.Name = "lblproducts";
            this.lblproducts.Size = new System.Drawing.Size(122, 31);
            this.lblproducts.TabIndex = 68;
            this.lblproducts.Text = "Products";
            // 
            // lblssm
            // 
            this.lblssm.AutoSize = true;
            this.lblssm.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblssm.ForeColor = System.Drawing.Color.White;
            this.lblssm.Location = new System.Drawing.Point(220, 9);
            this.lblssm.Name = "lblssm";
            this.lblssm.Size = new System.Drawing.Size(449, 43);
            this.lblssm.TabIndex = 67;
            this.lblssm.Text = "Shoe Store Management";
            // 
            // dgridproducts
            // 
            this.dgridproducts.AllowUserToAddRows = false;
            this.dgridproducts.AllowUserToDeleteRows = false;
            this.dgridproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridproducts.Location = new System.Drawing.Point(22, 126);
            this.dgridproducts.Name = "dgridproducts";
            this.dgridproducts.ReadOnly = true;
            this.dgridproducts.Size = new System.Drawing.Size(839, 310);
            this.dgridproducts.TabIndex = 71;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Black;
            this.btnadd.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(335, 614);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 37);
            this.btnadd.TabIndex = 112;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tboxavailable
            // 
            this.tboxavailable.Location = new System.Drawing.Point(538, 519);
            this.tboxavailable.Name = "tboxavailable";
            this.tboxavailable.Size = new System.Drawing.Size(127, 20);
            this.tboxavailable.TabIndex = 111;
            this.tboxavailable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxavailable_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(451, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 110;
            this.label7.Text = "Available :";
            // 
            // tboxsellprice
            // 
            this.tboxsellprice.Location = new System.Drawing.Point(317, 584);
            this.tboxsellprice.Name = "tboxsellprice";
            this.tboxsellprice.Size = new System.Drawing.Size(127, 20);
            this.tboxsellprice.TabIndex = 109;
            this.tboxsellprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxsellprice_KeyPress);
            // 
            // tboxbuyprice
            // 
            this.tboxbuyprice.Location = new System.Drawing.Point(317, 558);
            this.tboxbuyprice.Name = "tboxbuyprice";
            this.tboxbuyprice.Size = new System.Drawing.Size(127, 20);
            this.tboxbuyprice.TabIndex = 106;
            this.tboxbuyprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxbuyprice_KeyPress);
            // 
            // tboxname
            // 
            this.tboxname.Location = new System.Drawing.Point(317, 480);
            this.tboxname.Name = "tboxname";
            this.tboxname.Size = new System.Drawing.Size(127, 20);
            this.tboxname.TabIndex = 104;
            // 
            // tboxsize
            // 
            this.tboxsize.Location = new System.Drawing.Point(317, 454);
            this.tboxsize.Name = "tboxsize";
            this.tboxsize.Size = new System.Drawing.Size(127, 20);
            this.tboxsize.TabIndex = 103;
            this.tboxsize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxsize_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(491, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 102;
            this.label8.Text = "Sex :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(233, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 101;
            this.label4.Text = "Sell Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(230, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 100;
            this.label5.Text = "Buy Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(237, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 99;
            this.label6.Text = "Purpose :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(252, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 98;
            this.label3.Text = "Brand :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 97;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 96;
            this.label1.Text = "Size :";
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Black;
            this.btnremove.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(460, 614);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(109, 37);
            this.btnremove.TabIndex = 113;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // cboxsex
            // 
            this.cboxsex.FormattingEnabled = true;
            this.cboxsex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cboxsex.Location = new System.Drawing.Point(538, 492);
            this.cboxsex.Name = "cboxsex";
            this.cboxsex.Size = new System.Drawing.Size(127, 21);
            this.cboxsex.TabIndex = 114;
            // 
            // cboxbrand
            // 
            this.cboxbrand.FormattingEnabled = true;
            this.cboxbrand.Items.AddRange(new object[] {
            "Nike",
            "Adidas",
            "Puma"});
            this.cboxbrand.Location = new System.Drawing.Point(317, 506);
            this.cboxbrand.Name = "cboxbrand";
            this.cboxbrand.Size = new System.Drawing.Size(127, 21);
            this.cboxbrand.TabIndex = 115;
            // 
            // cboxpurpose
            // 
            this.cboxpurpose.FormattingEnabled = true;
            this.cboxpurpose.Items.AddRange(new object[] {
            "Running",
            "Sports",
            "Daily "});
            this.cboxpurpose.Location = new System.Drawing.Point(317, 532);
            this.cboxpurpose.Name = "cboxpurpose";
            this.cboxpurpose.Size = new System.Drawing.Size(127, 21);
            this.cboxpurpose.TabIndex = 116;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnback.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Image = global::ShoeStore.Properties.Resources.back__1_;
            this.btnback.Location = new System.Drawing.Point(815, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(55, 37);
            this.btnback.TabIndex = 70;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoeStore.Properties.Resources.shoe4;
            this.pictureBox1.Location = new System.Drawing.Point(478, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // tboxsold
            // 
            this.tboxsold.Location = new System.Drawing.Point(538, 545);
            this.tboxsold.Name = "tboxsold";
            this.tboxsold.Size = new System.Drawing.Size(127, 20);
            this.tboxsold.TabIndex = 118;
            this.tboxsold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxsold_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(485, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 117;
            this.label9.Text = "Sold :";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 660);
            this.Controls.Add(this.tboxsold);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboxpurpose);
            this.Controls.Add(this.cboxbrand);
            this.Controls.Add(this.cboxsex);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tboxavailable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxsellprice);
            this.Controls.Add(this.tboxbuyprice);
            this.Controls.Add(this.tboxname);
            this.Controls.Add(this.tboxsize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgridproducts);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblproducts);
            this.Controls.Add(this.lblssm);
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Add/Remove";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form12_FormClosed);
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblproducts;
        private System.Windows.Forms.Label lblssm;
        private System.Windows.Forms.DataGridView dgridproducts;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox tboxavailable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxsellprice;
        private System.Windows.Forms.TextBox tboxbuyprice;
        private System.Windows.Forms.TextBox tboxname;
        private System.Windows.Forms.TextBox tboxsize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.ComboBox cboxsex;
        private System.Windows.Forms.ComboBox cboxbrand;
        private System.Windows.Forms.ComboBox cboxpurpose;
        private System.Windows.Forms.TextBox tboxsold;
        private System.Windows.Forms.Label label9;
    }
}