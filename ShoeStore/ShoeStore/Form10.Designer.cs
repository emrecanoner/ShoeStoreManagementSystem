namespace ShoeStore
{
    partial class Form10
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
            this.lblssm = new System.Windows.Forms.Label();
            this.lblproducts = new System.Windows.Forms.Label();
            this.dgridproducts = new System.Windows.Forms.DataGridView();
            this.shoestoreDataSet = new ShoeStore.shoestoreDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new ShoeStore.shoestoreDataSetTableAdapters.productTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxsize = new System.Windows.Forms.TextBox();
            this.tboxname = new System.Windows.Forms.TextBox();
            this.tboxpurpose = new System.Windows.Forms.TextBox();
            this.tboxbuyprice = new System.Windows.Forms.TextBox();
            this.tboxsex = new System.Windows.Forms.TextBox();
            this.tboxbrand = new System.Windows.Forms.TextBox();
            this.tboxsellprice = new System.Windows.Forms.TextBox();
            this.tboxavailable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.tboxsold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblssm
            // 
            this.lblssm.AutoSize = true;
            this.lblssm.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblssm.ForeColor = System.Drawing.Color.White;
            this.lblssm.Location = new System.Drawing.Point(219, 9);
            this.lblssm.Name = "lblssm";
            this.lblssm.Size = new System.Drawing.Size(449, 43);
            this.lblssm.TabIndex = 59;
            this.lblssm.Text = "Shoe Store Management";
            // 
            // lblproducts
            // 
            this.lblproducts.AutoSize = true;
            this.lblproducts.Font = new System.Drawing.Font("Gilroy Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducts.ForeColor = System.Drawing.Color.White;
            this.lblproducts.Location = new System.Drawing.Point(358, 107);
            this.lblproducts.Name = "lblproducts";
            this.lblproducts.Size = new System.Drawing.Size(122, 31);
            this.lblproducts.TabIndex = 68;
            this.lblproducts.Text = "Products";
            // 
            // dgridproducts
            // 
            this.dgridproducts.AllowUserToAddRows = false;
            this.dgridproducts.AllowUserToDeleteRows = false;
            this.dgridproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridproducts.Location = new System.Drawing.Point(21, 150);
            this.dgridproducts.Name = "dgridproducts";
            this.dgridproducts.Size = new System.Drawing.Size(839, 226);
            this.dgridproducts.TabIndex = 67;
            this.dgridproducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgridproducts_CellMouseDoubleClick);
            // 
            // shoestoreDataSet
            // 
            this.shoestoreDataSet.DataSetName = "shoestoreDataSet";
            this.shoestoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "Size :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(344, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(344, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "Brand :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(325, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "Sell Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(322, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 75;
            this.label5.Text = "Buy Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(329, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "Purpose :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(362, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 78;
            this.label8.Text = "Sex :";
            // 
            // tboxsize
            // 
            this.tboxsize.Enabled = false;
            this.tboxsize.Location = new System.Drawing.Point(409, 392);
            this.tboxsize.Name = "tboxsize";
            this.tboxsize.ReadOnly = true;
            this.tboxsize.Size = new System.Drawing.Size(127, 20);
            this.tboxsize.TabIndex = 79;
            // 
            // tboxname
            // 
            this.tboxname.Enabled = false;
            this.tboxname.Location = new System.Drawing.Point(409, 418);
            this.tboxname.Name = "tboxname";
            this.tboxname.ReadOnly = true;
            this.tboxname.Size = new System.Drawing.Size(127, 20);
            this.tboxname.TabIndex = 80;
            // 
            // tboxpurpose
            // 
            this.tboxpurpose.Enabled = false;
            this.tboxpurpose.Location = new System.Drawing.Point(409, 470);
            this.tboxpurpose.Name = "tboxpurpose";
            this.tboxpurpose.ReadOnly = true;
            this.tboxpurpose.Size = new System.Drawing.Size(127, 20);
            this.tboxpurpose.TabIndex = 81;
            // 
            // tboxbuyprice
            // 
            this.tboxbuyprice.Enabled = false;
            this.tboxbuyprice.Location = new System.Drawing.Point(409, 496);
            this.tboxbuyprice.Name = "tboxbuyprice";
            this.tboxbuyprice.ReadOnly = true;
            this.tboxbuyprice.Size = new System.Drawing.Size(127, 20);
            this.tboxbuyprice.TabIndex = 82;
            // 
            // tboxsex
            // 
            this.tboxsex.Enabled = false;
            this.tboxsex.Location = new System.Drawing.Point(409, 548);
            this.tboxsex.Name = "tboxsex";
            this.tboxsex.ReadOnly = true;
            this.tboxsex.Size = new System.Drawing.Size(127, 20);
            this.tboxsex.TabIndex = 83;
            // 
            // tboxbrand
            // 
            this.tboxbrand.Enabled = false;
            this.tboxbrand.Location = new System.Drawing.Point(409, 444);
            this.tboxbrand.Name = "tboxbrand";
            this.tboxbrand.Size = new System.Drawing.Size(127, 20);
            this.tboxbrand.TabIndex = 84;
            // 
            // tboxsellprice
            // 
            this.tboxsellprice.Enabled = false;
            this.tboxsellprice.Location = new System.Drawing.Point(409, 522);
            this.tboxsellprice.Name = "tboxsellprice";
            this.tboxsellprice.ReadOnly = true;
            this.tboxsellprice.Size = new System.Drawing.Size(127, 20);
            this.tboxsellprice.TabIndex = 85;
            // 
            // tboxavailable
            // 
            this.tboxavailable.Enabled = false;
            this.tboxavailable.Location = new System.Drawing.Point(409, 574);
            this.tboxavailable.Name = "tboxavailable";
            this.tboxavailable.ReadOnly = true;
            this.tboxavailable.Size = new System.Drawing.Size(127, 20);
            this.tboxavailable.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(322, 574);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 93;
            this.label7.Text = "Available :";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(395, 628);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(109, 37);
            this.btnupdate.TabIndex = 95;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoeStore.Properties.Resources.shoe4;
            this.pictureBox1.Location = new System.Drawing.Point(477, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnback.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Image = global::ShoeStore.Properties.Resources.back__1_;
            this.btnback.Location = new System.Drawing.Point(814, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(55, 37);
            this.btnback.TabIndex = 66;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tboxsold
            // 
            this.tboxsold.Enabled = false;
            this.tboxsold.Location = new System.Drawing.Point(409, 600);
            this.tboxsold.Name = "tboxsold";
            this.tboxsold.ReadOnly = true;
            this.tboxsold.Size = new System.Drawing.Size(127, 20);
            this.tboxsold.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(356, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 96;
            this.label9.Text = "Sold :";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(881, 674);
            this.Controls.Add(this.tboxsold);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.tboxavailable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxsellprice);
            this.Controls.Add(this.tboxbrand);
            this.Controls.Add(this.tboxsex);
            this.Controls.Add(this.tboxbuyprice);
            this.Controls.Add(this.tboxpurpose);
            this.Controls.Add(this.tboxname);
            this.Controls.Add(this.tboxsize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblproducts);
            this.Controls.Add(this.dgridproducts);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblssm);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form10_FormClosed);
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblssm;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblproducts;
        private System.Windows.Forms.DataGridView dgridproducts;
        private shoestoreDataSet shoestoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private shoestoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxsize;
        private System.Windows.Forms.TextBox tboxname;
        private System.Windows.Forms.TextBox tboxpurpose;
        private System.Windows.Forms.TextBox tboxbuyprice;
        private System.Windows.Forms.TextBox tboxsex;
        private System.Windows.Forms.TextBox tboxbrand;
        private System.Windows.Forms.TextBox tboxsellprice;
        private System.Windows.Forms.TextBox tboxavailable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox tboxsold;
        private System.Windows.Forms.Label label9;
    }
}