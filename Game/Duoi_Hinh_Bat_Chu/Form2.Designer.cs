namespace Duoi_Hinh_Bat_Chu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbltemp = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltemp
            // 
            this.lbltemp.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp.Location = new System.Drawing.Point(12, 9);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(393, 181);
            this.lbltemp.TabIndex = 0;
            this.lbltemp.Text = "Cuộc sống chỉ mang đến cho bạn 10% cơ hội, 90% còn lại là cách mà bạn phản ứng vớ" +
    "i nó.";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnok.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnok.Location = new System.Drawing.Point(285, 167);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(107, 48);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "HIỂU RỒI";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(417, 227);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lbltemp);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Không được bỏ cuộc!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Button btnok;
    }
}