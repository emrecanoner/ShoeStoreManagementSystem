﻿namespace ShoeStore
{
    partial class Form5
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
            this.btnuser = new System.Windows.Forms.Button();
            this.btncreditcard = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnaddress = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pboxshoe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxshoe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproducts
            // 
            this.lblproducts.AutoSize = true;
            this.lblproducts.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblproducts.ForeColor = System.Drawing.Color.White;
            this.lblproducts.Location = new System.Drawing.Point(277, 9);
            this.lblproducts.Name = "lblproducts";
            this.lblproducts.Size = new System.Drawing.Size(244, 43);
            this.lblproducts.TabIndex = 55;
            this.lblproducts.Text = "User Settings";
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.Black;
            this.btnuser.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.Color.White;
            this.btnuser.Location = new System.Drawing.Point(234, 133);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(133, 115);
            this.btnuser.TabIndex = 56;
            this.btnuser.Text = "User\r\nInformations";
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btncreditcard
            // 
            this.btncreditcard.BackColor = System.Drawing.Color.Black;
            this.btncreditcard.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreditcard.ForeColor = System.Drawing.Color.White;
            this.btncreditcard.Location = new System.Drawing.Point(434, 133);
            this.btncreditcard.Name = "btncreditcard";
            this.btncreditcard.Size = new System.Drawing.Size(133, 115);
            this.btncreditcard.TabIndex = 57;
            this.btncreditcard.Text = "Credit Card\r\nInformations";
            this.btncreditcard.UseVisualStyleBackColor = false;
            this.btncreditcard.Click += new System.EventHandler(this.btnaddress_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(25, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 18);
            this.label20.TabIndex = 60;
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnaddress
            // 
            this.btnaddress.BackColor = System.Drawing.Color.Black;
            this.btnaddress.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddress.ForeColor = System.Drawing.Color.White;
            this.btnaddress.Location = new System.Drawing.Point(335, 277);
            this.btnaddress.Name = "btnaddress";
            this.btnaddress.Size = new System.Drawing.Size(133, 115);
            this.btnaddress.TabIndex = 62;
            this.btnaddress.Text = "Address\r\nInformations";
            this.btnaddress.UseVisualStyleBackColor = false;
            this.btnaddress.Click += new System.EventHandler(this.btncreditcard_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnback.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Image = global::ShoeStore.Properties.Resources.back__1_;
            this.btnback.Location = new System.Drawing.Point(732, 412);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(55, 37);
            this.btnback.TabIndex = 64;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pboxshoe
            // 
            this.pboxshoe.Image = global::ShoeStore.Properties.Resources.shoe;
            this.pboxshoe.Location = new System.Drawing.Point(-133, 173);
            this.pboxshoe.Name = "pboxshoe";
            this.pboxshoe.Size = new System.Drawing.Size(335, 326);
            this.pboxshoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxshoe.TabIndex = 63;
            this.pboxshoe.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pboxshoe);
            this.Controls.Add(this.btnaddress);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btncreditcard);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.lblproducts);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxshoe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblproducts;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btncreditcard;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnaddress;
        private System.Windows.Forms.PictureBox pboxshoe;
        private System.Windows.Forms.Button btnback;
    }
}