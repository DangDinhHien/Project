namespace Duoi_Hinh_Bat_Chu
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnhuongdan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Chocolate;
            this.btnPlay.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(69, 152);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(177, 60);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY GAME";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnhuongdan
            // 
            this.btnhuongdan.BackColor = System.Drawing.Color.Chocolate;
            this.btnhuongdan.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuongdan.Location = new System.Drawing.Point(69, 218);
            this.btnhuongdan.Name = "btnhuongdan";
            this.btnhuongdan.Size = new System.Drawing.Size(177, 59);
            this.btnhuongdan.TabIndex = 2;
            this.btnhuongdan.Text = "HƯỚNG DẪN";
            this.btnhuongdan.UseVisualStyleBackColor = false;
            this.btnhuongdan.Click += new System.EventHandler(this.btnhuongdan_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 92);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐUỔI HÌNH BẮT CHỮ";
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(313, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhuongdan);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đuổi hình bắt chữ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnhuongdan;
        private System.Windows.Forms.Label label1;
    }
}