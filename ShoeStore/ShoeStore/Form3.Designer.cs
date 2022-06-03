namespace ShoeStore
{
    partial class Form3
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
            this.lblssm = new System.Windows.Forms.Label();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btnusers = new System.Windows.Forms.Button();
            this.btnloginpage = new System.Windows.Forms.Button();
            this.btnshoppings = new System.Windows.Forms.Button();
            this.pboxshoe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxshoe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblssm
            // 
            this.lblssm.AutoSize = true;
            this.lblssm.Font = new System.Drawing.Font("Gilroy Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblssm.ForeColor = System.Drawing.Color.White;
            this.lblssm.Location = new System.Drawing.Point(181, 9);
            this.lblssm.Name = "lblssm";
            this.lblssm.Size = new System.Drawing.Size(449, 43);
            this.lblssm.TabIndex = 56;
            this.lblssm.Text = "Shoe Store Management";
            this.lblssm.Click += new System.EventHandler(this.lblssm_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.BackColor = System.Drawing.Color.Black;
            this.btnproducts.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducts.ForeColor = System.Drawing.Color.White;
            this.btnproducts.Location = new System.Drawing.Point(237, 131);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(133, 115);
            this.btnproducts.TabIndex = 58;
            this.btnproducts.Text = "Products";
            this.btnproducts.UseVisualStyleBackColor = false;
            this.btnproducts.Click += new System.EventHandler(this.btnproducts_Click);
            // 
            // btnusers
            // 
            this.btnusers.BackColor = System.Drawing.Color.Black;
            this.btnusers.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusers.ForeColor = System.Drawing.Color.White;
            this.btnusers.Location = new System.Drawing.Point(432, 131);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(133, 115);
            this.btnusers.TabIndex = 65;
            this.btnusers.Text = "Users";
            this.btnusers.UseVisualStyleBackColor = false;
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // btnloginpage
            // 
            this.btnloginpage.BackColor = System.Drawing.Color.Black;
            this.btnloginpage.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnloginpage.ForeColor = System.Drawing.Color.White;
            this.btnloginpage.Location = new System.Drawing.Point(679, 409);
            this.btnloginpage.Name = "btnloginpage";
            this.btnloginpage.Size = new System.Drawing.Size(109, 37);
            this.btnloginpage.TabIndex = 66;
            this.btnloginpage.Text = "Login Page";
            this.btnloginpage.UseVisualStyleBackColor = false;
            this.btnloginpage.Click += new System.EventHandler(this.btnloginpage_Click);
            // 
            // btnshoppings
            // 
            this.btnshoppings.BackColor = System.Drawing.Color.Black;
            this.btnshoppings.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoppings.ForeColor = System.Drawing.Color.White;
            this.btnshoppings.Location = new System.Drawing.Point(337, 281);
            this.btnshoppings.Name = "btnshoppings";
            this.btnshoppings.Size = new System.Drawing.Size(133, 115);
            this.btnshoppings.TabIndex = 67;
            this.btnshoppings.Text = "Shoppings";
            this.btnshoppings.UseVisualStyleBackColor = false;
            this.btnshoppings.Click += new System.EventHandler(this.btnshoppings_Click);
            // 
            // pboxshoe
            // 
            this.pboxshoe.Image = global::ShoeStore.Properties.Resources.shoe;
            this.pboxshoe.Location = new System.Drawing.Point(-133, 173);
            this.pboxshoe.Name = "pboxshoe";
            this.pboxshoe.Size = new System.Drawing.Size(335, 326);
            this.pboxshoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxshoe.TabIndex = 64;
            this.pboxshoe.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.btnshoppings);
            this.Controls.Add(this.btnloginpage);
            this.Controls.Add(this.btnusers);
            this.Controls.Add(this.pboxshoe);
            this.Controls.Add(this.btnproducts);
            this.Controls.Add(this.lblssm);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoe Store Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxshoe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblssm;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.PictureBox pboxshoe;
        private System.Windows.Forms.Button btnusers;
        private System.Windows.Forms.Button btnloginpage;
        private System.Windows.Forms.Button btnshoppings;
    }
}