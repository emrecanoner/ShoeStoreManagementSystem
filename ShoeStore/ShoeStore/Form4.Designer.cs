namespace ShoeStore
{
    partial class Form4
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
            this.Products = new System.Windows.Forms.ListBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoestoreDataSet = new ShoeStore.shoestoreDataSet();
            this.btnlist = new System.Windows.Forms.Button();
            this.lblproducts = new System.Windows.Forms.Label();
            this.tboxsize = new System.Windows.Forms.TextBox();
            this.tboxpurpose = new System.Windows.Forms.TextBox();
            this.tboxsellprice = new System.Windows.Forms.TextBox();
            this.tboxsex = new System.Windows.Forms.TextBox();
            this.tboxbrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productTableAdapter = new ShoeStore.shoestoreDataSetTableAdapters.productTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxavailable = new System.Windows.Forms.TextBox();
            this.btnusersettings = new System.Windows.Forms.Button();
            this.btnloginpage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Black;
            this.Products.Font = new System.Drawing.Font("Gilroy Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.FormattingEnabled = true;
            this.Products.ItemHeight = 24;
            this.Products.Location = new System.Drawing.Point(33, 138);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(316, 196);
            this.Products.TabIndex = 0;
            this.Products.DoubleClick += new System.EventHandler(this.Products_DoubleClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // shoestoreDataSet
            // 
            this.shoestoreDataSet.DataSetName = "shoestoreDataSet";
            this.shoestoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.Black;
            this.btnlist.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlist.ForeColor = System.Drawing.Color.White;
            this.btnlist.Location = new System.Drawing.Point(33, 340);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(109, 37);
            this.btnlist.TabIndex = 1;
            this.btnlist.Text = "List";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // lblproducts
            // 
            this.lblproducts.AutoSize = true;
            this.lblproducts.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblproducts.ForeColor = System.Drawing.Color.White;
            this.lblproducts.Location = new System.Drawing.Point(25, 81);
            this.lblproducts.Name = "lblproducts";
            this.lblproducts.Size = new System.Drawing.Size(171, 43);
            this.lblproducts.TabIndex = 2;
            this.lblproducts.Text = "Products";
            // 
            // tboxsize
            // 
            this.tboxsize.Enabled = false;
            this.tboxsize.Location = new System.Drawing.Point(403, 143);
            this.tboxsize.Name = "tboxsize";
            this.tboxsize.ReadOnly = true;
            this.tboxsize.Size = new System.Drawing.Size(130, 20);
            this.tboxsize.TabIndex = 3;
            // 
            // tboxpurpose
            // 
            this.tboxpurpose.Enabled = false;
            this.tboxpurpose.Location = new System.Drawing.Point(403, 233);
            this.tboxpurpose.Name = "tboxpurpose";
            this.tboxpurpose.ReadOnly = true;
            this.tboxpurpose.Size = new System.Drawing.Size(130, 20);
            this.tboxpurpose.TabIndex = 5;
            // 
            // tboxsellprice
            // 
            this.tboxsellprice.Enabled = false;
            this.tboxsellprice.Location = new System.Drawing.Point(619, 233);
            this.tboxsellprice.Name = "tboxsellprice";
            this.tboxsellprice.ReadOnly = true;
            this.tboxsellprice.Size = new System.Drawing.Size(130, 20);
            this.tboxsellprice.TabIndex = 6;
            // 
            // tboxsex
            // 
            this.tboxsex.Enabled = false;
            this.tboxsex.Location = new System.Drawing.Point(403, 319);
            this.tboxsex.Name = "tboxsex";
            this.tboxsex.ReadOnly = true;
            this.tboxsex.Size = new System.Drawing.Size(130, 20);
            this.tboxsex.TabIndex = 7;
            this.tboxsex.TextChanged += new System.EventHandler(this.tboxsex_TextChanged);
            // 
            // tboxbrand
            // 
            this.tboxbrand.Enabled = false;
            this.tboxbrand.Location = new System.Drawing.Point(619, 319);
            this.tboxbrand.Name = "tboxbrand";
            this.tboxbrand.ReadOnly = true;
            this.tboxbrand.Size = new System.Drawing.Size(130, 20);
            this.tboxbrand.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Purpose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(616, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sell Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(616, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Brand";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(616, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Available";
            // 
            // tboxavailable
            // 
            this.tboxavailable.Enabled = false;
            this.tboxavailable.Location = new System.Drawing.Point(619, 143);
            this.tboxavailable.Name = "tboxavailable";
            this.tboxavailable.ReadOnly = true;
            this.tboxavailable.Size = new System.Drawing.Size(130, 20);
            this.tboxavailable.TabIndex = 17;
            // 
            // btnusersettings
            // 
            this.btnusersettings.BackColor = System.Drawing.Color.Black;
            this.btnusersettings.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnusersettings.ForeColor = System.Drawing.Color.White;
            this.btnusersettings.Location = new System.Drawing.Point(640, 384);
            this.btnusersettings.Name = "btnusersettings";
            this.btnusersettings.Size = new System.Drawing.Size(109, 37);
            this.btnusersettings.TabIndex = 19;
            this.btnusersettings.Text = "User Settings";
            this.btnusersettings.UseVisualStyleBackColor = false;
            this.btnusersettings.Click += new System.EventHandler(this.btnusersettings_Click);
            // 
            // btnloginpage
            // 
            this.btnloginpage.BackColor = System.Drawing.Color.Black;
            this.btnloginpage.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnloginpage.ForeColor = System.Drawing.Color.White;
            this.btnloginpage.Location = new System.Drawing.Point(525, 384);
            this.btnloginpage.Name = "btnloginpage";
            this.btnloginpage.Size = new System.Drawing.Size(109, 37);
            this.btnloginpage.TabIndex = 20;
            this.btnloginpage.Text = "Login Page";
            this.btnloginpage.UseVisualStyleBackColor = false;
            this.btnloginpage.Click += new System.EventHandler(this.btnloginpage_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.btnloginpage);
            this.Controls.Add(this.btnusersettings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxavailable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxbrand);
            this.Controls.Add(this.tboxsex);
            this.Controls.Add(this.tboxsellprice);
            this.Controls.Add(this.tboxpurpose);
            this.Controls.Add(this.tboxsize);
            this.Controls.Add(this.lblproducts);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.Products);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Label lblproducts;
        private System.Windows.Forms.TextBox tboxsize;
        private System.Windows.Forms.TextBox tboxpurpose;
        private System.Windows.Forms.TextBox tboxsellprice;
        private System.Windows.Forms.TextBox tboxsex;
        private System.Windows.Forms.TextBox tboxbrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private shoestoreDataSet shoestoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private shoestoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxavailable;
        private System.Windows.Forms.Button btnusersettings;
        private System.Windows.Forms.Button btnloginpage;
    }
}