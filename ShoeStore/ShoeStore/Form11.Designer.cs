namespace ShoeStore
{
    partial class Form11
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
            this.dgridusers = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoestoreDataSet = new ShoeStore.shoestoreDataSet();
            this.shoestoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new ShoeStore.shoestoreDataSetTableAdapters.userTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new ShoeStore.shoestoreDataSetTableAdapters.productTableAdapter();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lblusers = new System.Windows.Forms.Label();
            this.btnusersettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxsearch = new System.Windows.Forms.TextBox();
            this.btnaddadmin = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblssm
            // 
            this.lblssm.AutoSize = true;
            this.lblssm.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblssm.ForeColor = System.Drawing.Color.White;
            this.lblssm.Location = new System.Drawing.Point(224, 9);
            this.lblssm.Name = "lblssm";
            this.lblssm.Size = new System.Drawing.Size(449, 43);
            this.lblssm.TabIndex = 58;
            this.lblssm.Text = "Shoe Store Management";
            // 
            // dgridusers
            // 
            this.dgridusers.AllowUserToAddRows = false;
            this.dgridusers.AllowUserToDeleteRows = false;
            this.dgridusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridusers.Location = new System.Drawing.Point(21, 134);
            this.dgridusers.Name = "dgridusers";
            this.dgridusers.ReadOnly = true;
            this.dgridusers.Size = new System.Drawing.Size(842, 296);
            this.dgridusers.TabIndex = 59;
            this.dgridusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridusers_CellContentClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // shoestoreDataSet
            // 
            this.shoestoreDataSet.DataSetName = "shoestoreDataSet";
            this.shoestoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoestoreDataSetBindingSource
            // 
            this.shoestoreDataSetBindingSource.DataSource = this.shoestoreDataSet;
            this.shoestoreDataSetBindingSource.Position = 0;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
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
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.shoestoreDataSetBindingSource;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "product";
            this.productBindingSource2.DataSource = this.shoestoreDataSetBindingSource;
            // 
            // lblusers
            // 
            this.lblusers.AutoSize = true;
            this.lblusers.Font = new System.Drawing.Font("Gilroy Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusers.ForeColor = System.Drawing.Color.White;
            this.lblusers.Location = new System.Drawing.Point(393, 88);
            this.lblusers.Name = "lblusers";
            this.lblusers.Size = new System.Drawing.Size(80, 31);
            this.lblusers.TabIndex = 60;
            this.lblusers.Text = "Users";
            this.lblusers.Click += new System.EventHandler(this.lblusers_Click);
            // 
            // btnusersettings
            // 
            this.btnusersettings.BackColor = System.Drawing.Color.Black;
            this.btnusersettings.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusersettings.ForeColor = System.Drawing.Color.White;
            this.btnusersettings.Location = new System.Drawing.Point(280, 469);
            this.btnusersettings.Name = "btnusersettings";
            this.btnusersettings.Size = new System.Drawing.Size(133, 115);
            this.btnusersettings.TabIndex = 71;
            this.btnusersettings.Text = "User\r\nSettings";
            this.btnusersettings.UseVisualStyleBackColor = false;
            this.btnusersettings.Click += new System.EventHandler(this.btnusersettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Search By Name";
            // 
            // tboxsearch
            // 
            this.tboxsearch.Location = new System.Drawing.Point(20, 104);
            this.tboxsearch.Name = "tboxsearch";
            this.tboxsearch.Size = new System.Drawing.Size(133, 20);
            this.tboxsearch.TabIndex = 73;
            this.tboxsearch.TextChanged += new System.EventHandler(this.tboxsearch_TextChanged);
            this.tboxsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxsearch_KeyPress);
            // 
            // btnaddadmin
            // 
            this.btnaddadmin.BackColor = System.Drawing.Color.Black;
            this.btnaddadmin.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddadmin.ForeColor = System.Drawing.Color.White;
            this.btnaddadmin.Location = new System.Drawing.Point(476, 469);
            this.btnaddadmin.Name = "btnaddadmin";
            this.btnaddadmin.Size = new System.Drawing.Size(133, 115);
            this.btnaddadmin.TabIndex = 75;
            this.btnaddadmin.Text = "Admin\r\nSettings";
            this.btnaddadmin.UseVisualStyleBackColor = false;
            this.btnaddadmin.Click += new System.EventHandler(this.btnaddadmin_Click);
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
            this.btnback.TabIndex = 65;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoeStore.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(468, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 623);
            this.Controls.Add(this.btnaddadmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxsearch);
            this.Controls.Add(this.btnusersettings);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblusers);
            this.Controls.Add(this.dgridusers);
            this.Controls.Add(this.lblssm);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form11_FormClosed);
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblssm;
        private System.Windows.Forms.DataGridView dgridusers;
        private System.Windows.Forms.BindingSource shoestoreDataSetBindingSource;
        private shoestoreDataSet shoestoreDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private shoestoreDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private shoestoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.Label lblusers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnusersettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxsearch;
        private System.Windows.Forms.Button btnaddadmin;
    }
}