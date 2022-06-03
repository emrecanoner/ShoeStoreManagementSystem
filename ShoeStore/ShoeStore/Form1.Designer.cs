namespace ShoeStore
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tboxusername = new System.Windows.Forms.TextBox();
            this.tboxpassword = new System.Windows.Forms.TextBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.pboxshoe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxshoe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Gilroy Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(278, 76);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(223, 74);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "LOGIN";
            this.lbllogin.Click += new System.EventHandler(this.lbllogin_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Gilroy ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(232, 205);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(159, 33);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username :";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Gilroy ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpassword.ForeColor = System.Drawing.Color.White;
            this.lblpassword.Location = new System.Drawing.Point(242, 238);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(149, 33);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password :";
            // 
            // tboxusername
            // 
            this.tboxusername.Location = new System.Drawing.Point(399, 214);
            this.tboxusername.Name = "tboxusername";
            this.tboxusername.Size = new System.Drawing.Size(123, 20);
            this.tboxusername.TabIndex = 4;
            // 
            // tboxpassword
            // 
            this.tboxpassword.Location = new System.Drawing.Point(400, 247);
            this.tboxpassword.Name = "tboxpassword";
            this.tboxpassword.Size = new System.Drawing.Size(123, 20);
            this.tboxpassword.TabIndex = 5;
            // 
            // btnconnect
            // 
            this.btnconnect.BackColor = System.Drawing.Color.Black;
            this.btnconnect.Font = new System.Drawing.Font("Gilroy Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnect.ForeColor = System.Drawing.Color.White;
            this.btnconnect.Location = new System.Drawing.Point(399, 283);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(122, 36);
            this.btnconnect.TabIndex = 7;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = false;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // pboxshoe
            // 
            this.pboxshoe.Image = global::ShoeStore.Properties.Resources.shoe2;
            this.pboxshoe.Location = new System.Drawing.Point(-100, 170);
            this.pboxshoe.Name = "pboxshoe";
            this.pboxshoe.Size = new System.Drawing.Size(293, 381);
            this.pboxshoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxshoe.TabIndex = 8;
            this.pboxshoe.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.pboxshoe);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.tboxpassword);
            this.Controls.Add(this.tboxusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxshoe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tboxusername;
        private System.Windows.Forms.TextBox tboxpassword;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.PictureBox pboxshoe;
    }
}

