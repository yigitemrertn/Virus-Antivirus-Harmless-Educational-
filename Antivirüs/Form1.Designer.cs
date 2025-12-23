namespace Antivirüs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnTara = new Button();
            lblDurum = new Label();
            tmrKoruma = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnTara
            // 
            btnTara.Location = new Point(31, 119);
            btnTara.Name = "btnTara";
            btnTara.Size = new Size(326, 23);
            btnTara.TabIndex = 0;
            btnTara.Text = "TARA";
            btnTara.UseVisualStyleBackColor = true;
            btnTara.Click += btnTara_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(21, 21);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(22, 15);
            lblDurum.TabIndex = 1;
            lblDurum.Text = "sss";
            // 
            // tmrKoruma
            // 
            tmrKoruma.Interval = 1000;
            tmrKoruma.Tick += tmrKoruma_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 167);
            Controls.Add(lblDurum);
            Controls.Add(btnTara);
            Name = "Form1";
            Text = "ANTIVIRUS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTara;
        private Label lblDurum;
        private System.Windows.Forms.Timer tmrKoruma;
    }
}
