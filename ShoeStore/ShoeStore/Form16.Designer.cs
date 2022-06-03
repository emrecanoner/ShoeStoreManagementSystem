namespace ShoeStore
{
    partial class Form16
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
            this.lblusers = new System.Windows.Forms.Label();
            this.dgridusers = new System.Windows.Forms.DataGridView();
            this.lblssm = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxcvc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxccnum = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxnameoncard = new System.Windows.Forms.TextBox();
            this.pboxsettings = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.mtboxexpirationdate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxsettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusers
            // 
            this.lblusers.AutoSize = true;
            this.lblusers.Font = new System.Drawing.Font("Gilroy Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusers.ForeColor = System.Drawing.Color.White;
            this.lblusers.Location = new System.Drawing.Point(385, 97);
            this.lblusers.Name = "lblusers";
            this.lblusers.Size = new System.Drawing.Size(80, 31);
            this.lblusers.TabIndex = 81;
            this.lblusers.Text = "Users";
            // 
            // dgridusers
            // 
            this.dgridusers.AllowUserToAddRows = false;
            this.dgridusers.AllowUserToDeleteRows = false;
            this.dgridusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridusers.Location = new System.Drawing.Point(124, 139);
            this.dgridusers.Name = "dgridusers";
            this.dgridusers.Size = new System.Drawing.Size(633, 296);
            this.dgridusers.TabIndex = 80;
            this.dgridusers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgridusers_CellMouseDoubleClick);
            // 
            // lblssm
            // 
            this.lblssm.AutoSize = true;
            this.lblssm.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblssm.ForeColor = System.Drawing.Color.White;
            this.lblssm.Location = new System.Drawing.Point(226, 9);
            this.lblssm.Name = "lblssm";
            this.lblssm.Size = new System.Drawing.Size(447, 43);
            this.lblssm.TabIndex = 78;
            this.lblssm.Text = "Credit Card Informations";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(308, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 18);
            this.label11.TabIndex = 88;
            this.label11.Text = "Expiration Date :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(388, 541);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 86;
            this.label12.Text = "CVC :";
            // 
            // tboxcvc
            // 
            this.tboxcvc.Enabled = false;
            this.tboxcvc.Location = new System.Drawing.Point(443, 541);
            this.tboxcvc.Name = "tboxcvc";
            this.tboxcvc.ReadOnly = true;
            this.tboxcvc.Size = new System.Drawing.Size(130, 20);
            this.tboxcvc.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(274, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "Credit Card Number :";
            // 
            // tboxccnum
            // 
            this.tboxccnum.Enabled = false;
            this.tboxccnum.Location = new System.Drawing.Point(443, 489);
            this.tboxccnum.Name = "tboxccnum";
            this.tboxccnum.ReadOnly = true;
            this.tboxccnum.Size = new System.Drawing.Size(130, 20);
            this.tboxccnum.TabIndex = 84;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(394, 572);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(109, 37);
            this.btnupdate.TabIndex = 102;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 104;
            this.label1.Text = "Name On Card :";
            // 
            // tboxnameoncard
            // 
            this.tboxnameoncard.Enabled = false;
            this.tboxnameoncard.Location = new System.Drawing.Point(443, 463);
            this.tboxnameoncard.Name = "tboxnameoncard";
            this.tboxnameoncard.ReadOnly = true;
            this.tboxnameoncard.Size = new System.Drawing.Size(130, 20);
            this.tboxnameoncard.TabIndex = 103;
            // 
            // pboxsettings
            // 
            this.pboxsettings.Image = global::ShoeStore.Properties.Resources.settings;
            this.pboxsettings.Location = new System.Drawing.Point(579, 477);
            this.pboxsettings.Name = "pboxsettings";
            this.pboxsettings.Size = new System.Drawing.Size(62, 67);
            this.pboxsettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxsettings.TabIndex = 105;
            this.pboxsettings.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShoeStore.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(460, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnback.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Image = global::ShoeStore.Properties.Resources.back__1_;
            this.btnback.Location = new System.Drawing.Point(805, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(55, 37);
            this.btnback.TabIndex = 79;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // mtboxexpirationdate
            // 
            this.mtboxexpirationdate.Enabled = false;
            this.mtboxexpirationdate.Location = new System.Drawing.Point(443, 515);
            this.mtboxexpirationdate.Mask = "00/00/0000";
            this.mtboxexpirationdate.Name = "mtboxexpirationdate";
            this.mtboxexpirationdate.ReadOnly = true;
            this.mtboxexpirationdate.Size = new System.Drawing.Size(130, 20);
            this.mtboxexpirationdate.TabIndex = 106;
            this.mtboxexpirationdate.ValidatingType = typeof(System.DateTime);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(872, 623);
            this.Controls.Add(this.mtboxexpirationdate);
            this.Controls.Add(this.pboxsettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxnameoncard);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tboxcvc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxccnum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblusers);
            this.Controls.Add(this.dgridusers);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblssm);
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card Informations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form16_FormClosed);
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxsettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblusers;
        private System.Windows.Forms.DataGridView dgridusers;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblssm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tboxcvc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxccnum;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxnameoncard;
        private System.Windows.Forms.PictureBox pboxsettings;
        private System.Windows.Forms.MaskedTextBox mtboxexpirationdate;
    }
}