namespace Duoi_Hinh_Bat_Chu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flptemp = new System.Windows.Forms.FlowLayoutPanel();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnGoiy = new System.Windows.Forms.Button();
            this.pbnext = new System.Windows.Forms.PictureBox();
            this.pbvolume = new System.Windows.Forms.PictureBox();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbnext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // flptemp
            // 
            this.flptemp.AutoSize = true;
            this.flptemp.CausesValidation = false;
            this.flptemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.flptemp.Location = new System.Drawing.Point(24, 354);
            this.flptemp.Name = "flptemp";
            this.flptemp.Size = new System.Drawing.Size(356, 32);
            this.flptemp.TabIndex = 4;
            // 
            // flp2
            // 
            this.flp2.Location = new System.Drawing.Point(398, 77);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(82, 261);
            this.flp2.TabIndex = 5;
            // 
            // btnLevel
            // 
            this.btnLevel.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLevel.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLevel.Location = new System.Drawing.Point(74, 12);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(93, 48);
            this.btnLevel.TabIndex = 6;
            this.btnLevel.Text = "Level: 0";
            this.btnLevel.UseVisualStyleBackColor = false;
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnScore.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnScore.Location = new System.Drawing.Point(335, 12);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(93, 48);
            this.btnScore.TabIndex = 7;
            this.btnScore.Text = "Score: 0";
            this.btnScore.UseVisualStyleBackColor = false;
            // 
            // btnHD
            // 
            this.btnHD.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnHD.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHD.Location = new System.Drawing.Point(398, 348);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(82, 38);
            this.btnHD.TabIndex = 8;
            this.btnHD.Text = "Xin thua câu này";
            this.btnHD.UseVisualStyleBackColor = false;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnGoiy
            // 
            this.btnGoiy.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGoiy.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGoiy.Location = new System.Drawing.Point(212, 19);
            this.btnGoiy.Name = "btnGoiy";
            this.btnGoiy.Size = new System.Drawing.Size(72, 34);
            this.btnGoiy.TabIndex = 9;
            this.btnGoiy.Text = "Gợi ý";
            this.btnGoiy.UseVisualStyleBackColor = false;
            this.btnGoiy.Click += new System.EventHandler(this.btnGoiy_Click);
            // 
            // pbnext
            // 
            this.pbnext.BackgroundImage = global::Duoi_Hinh_Bat_Chu.Properties.Resources.icons8_end_64;
            this.pbnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbnext.Location = new System.Drawing.Point(466, 33);
            this.pbnext.Name = "pbnext";
            this.pbnext.Size = new System.Drawing.Size(38, 38);
            this.pbnext.TabIndex = 11;
            this.pbnext.TabStop = false;
            this.pbnext.Click += new System.EventHandler(this.pbnext_Click);
            // 
            // pbvolume
            // 
            this.pbvolume.BackgroundImage = global::Duoi_Hinh_Bat_Chu.Properties.Resources.on;
            this.pbvolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbvolume.Location = new System.Drawing.Point(475, 0);
            this.pbvolume.Name = "pbvolume";
            this.pbvolume.Size = new System.Drawing.Size(29, 27);
            this.pbvolume.TabIndex = 10;
            this.pbvolume.TabStop = false;
            this.pbvolume.Click += new System.EventHandler(this.pbvolume_Click);
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(24, 77);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(356, 261);
            this.pbAnh.TabIndex = 0;
            this.pbAnh.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(504, 403);
            this.Controls.Add(this.pbnext);
            this.Controls.Add(this.pbvolume);
            this.Controls.Add(this.btnGoiy);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnLevel);
            this.Controls.Add(this.flp2);
            this.Controls.Add(this.flptemp);
            this.Controls.Add(this.pbAnh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐUỔI HÌNH BẮT CHỮ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbnext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbvolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.FlowLayoutPanel flptemp;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Button btnGoiy;
        private System.Windows.Forms.PictureBox pbvolume;
        private System.Windows.Forms.PictureBox pbnext;
    }
}

