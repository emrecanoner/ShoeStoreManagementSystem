namespace ShoeStore
{
    partial class Form9
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
            this.dgridproducts = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoestoreDataSet = new ShoeStore.shoestoreDataSet();
            this.productTableAdapter = new ShoeStore.shoestoreDataSetTableAdapters.productTableAdapter();
            this.lblproducts = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnaddremove = new System.Windows.Forms.Button();
            this.tboxsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblssm
            // 
            this.lblssm.AutoSize = true;
            this.lblssm.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblssm.ForeColor = System.Drawing.Color.White;
            this.lblssm.Location = new System.Drawing.Point(217, 9);
            this.lblssm.Name = "lblssm";
            this.lblssm.Size = new System.Drawing.Size(449, 43);
            this.lblssm.TabIndex = 57;
            this.lblssm.Text = "Shoe Store Management";
            // 
            // dgridproducts
            // 
            this.dgridproducts.AllowUserToAddRows = false;
            this.dgridproducts.AllowUserToDeleteRows = false;
            this.dgridproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridproducts.Location = new System.Drawing.Point(20, 126);
            this.dgridproducts.Name = "dgridproducts";
            this.dgridproducts.ReadOnly = true;
            this.dgridproducts.Size = new System.Drawing.Size(839, 310);
            this.dgridproducts.TabIndex = 58;
            this.dgridproducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridproducts_CellContentClick);
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
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // lblproducts
            // 
            this.lblproducts.AutoSize = true;
            this.lblproducts.Font = new System.Drawing.Font("Gilroy Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducts.ForeColor = System.Drawing.Color.White;
            this.lblproducts.Location = new System.Drawing.Point(357, 83);
            this.lblproducts.Name = "lblproducts";
            this.lblproducts.Size = new System.Drawing.Size(122, 31);
            this.lblproducts.TabIndex = 62;
            this.lblproducts.Text = "Products";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(272, 471);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(133, 115);
            this.btnupdate.TabIndex = 67;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnaddremove
            // 
            this.btnaddremove.BackColor = System.Drawing.Color.Black;
            this.btnaddremove.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddremove.ForeColor = System.Drawing.Color.White;
            this.btnaddremove.Location = new System.Drawing.Point(471, 471);
            this.btnaddremove.Name = "btnaddremove";
            this.btnaddremove.Size = new System.Drawing.Size(133, 115);
            this.btnaddremove.TabIndex = 68;
            this.btnaddremove.Text = "Add\r\nRemove";
            this.btnaddremove.UseVisualStyleBackColor = false;
            this.btnaddremove.Click += new System.EventHandler(this.btnaddremove_Click);
            // 
            // tboxsearch
            // 
            this.tboxsearch.Location = new System.Drawing.Point(20, 94);
            this.tboxsearch.Name = "tboxsearch";
            this.tboxsearch.Size = new System.Drawing.Size(133, 20);
            this.tboxsearch.TabIndex = 69;
            this.tboxsearch.TextChanged += new System.EventHandler(this.tboxsearch_TextChanged);
            this.tboxsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxsearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Search By Name";
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
            this.btnback.TabIndex = 66;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoeStore.Properties.Resources.shoe4;
            this.pictureBox1.Location = new System.Drawing.Point(476, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxsearch);
            this.Controls.Add(this.btnaddremove);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblproducts);
            this.Controls.Add(this.dgridproducts);
            this.Controls.Add(this.lblssm);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form9_FormClosed);
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblssm;
        private System.Windows.Forms.DataGridView dgridproducts;
        private shoestoreDataSet shoestoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private shoestoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblproducts;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnaddremove;
        private System.Windows.Forms.TextBox tboxsearch;
        private System.Windows.Forms.Label label1;
    }
}