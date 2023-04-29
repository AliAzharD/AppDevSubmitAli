namespace THA_W7_Ali_Azhar_D
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
            this.label_cinemaxxi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_cinemaxxi
            // 
            this.label_cinemaxxi.AutoSize = true;
            this.label_cinemaxxi.Font = new System.Drawing.Font("Old English Text MT", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cinemaxxi.Location = new System.Drawing.Point(3, 9);
            this.label_cinemaxxi.Name = "label_cinemaxxi";
            this.label_cinemaxxi.Size = new System.Drawing.Size(286, 56);
            this.label_cinemaxxi.TabIndex = 0;
            this.label_cinemaxxi.Text = "Cinema XXI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "2023 © Ali Azhar D All right reserved.";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(22, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 456);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1296, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_cinemaxxi);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cinemaxxi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

