namespace Mega645
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
            btnMega645 = new Button();
            lblMega1 = new Label();
            btnPower655 = new Button();
            labelPower1 = new Label();
            lblMega2 = new Label();
            lblMega3 = new Label();
            labelPower2 = new Label();
            labelPower3 = new Label();
            SuspendLayout();
            // 
            // btnMega645
            // 
            btnMega645.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMega645.ForeColor = SystemColors.MenuHighlight;
            btnMega645.Location = new Point(317, 54);
            btnMega645.Name = "btnMega645";
            btnMega645.Size = new Size(145, 45);
            btnMega645.TabIndex = 0;
            btnMega645.Text = "MeGa 645";
            btnMega645.UseVisualStyleBackColor = true;
            btnMega645.Click += btnMega645_Click;
            // 
            // lblMega1
            // 
            lblMega1.AutoSize = true;
            lblMega1.Location = new Point(42, 41);
            lblMega1.Name = "lblMega1";
            lblMega1.Size = new Size(50, 20);
            lblMega1.TabIndex = 1;
            lblMega1.Text = "label1";
            // 
            // btnPower655
            // 
            btnPower655.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPower655.ForeColor = SystemColors.MenuHighlight;
            btnPower655.Location = new Point(317, 163);
            btnPower655.Name = "btnPower655";
            btnPower655.Size = new Size(145, 45);
            btnPower655.TabIndex = 0;
            btnPower655.Text = "Power 655";
            btnPower655.UseVisualStyleBackColor = true;
            btnPower655.Click += btnPower655_Click;
            // 
            // labelPower1
            // 
            labelPower1.AutoSize = true;
            labelPower1.Location = new Point(42, 144);
            labelPower1.Name = "labelPower1";
            labelPower1.Size = new Size(50, 20);
            labelPower1.TabIndex = 1;
            labelPower1.Text = "label1";
            // 
            // lblMega2
            // 
            lblMega2.AutoSize = true;
            lblMega2.Location = new Point(42, 74);
            lblMega2.Name = "lblMega2";
            lblMega2.Size = new Size(50, 20);
            lblMega2.TabIndex = 1;
            lblMega2.Text = "label1";
            // 
            // lblMega3
            // 
            lblMega3.AutoSize = true;
            lblMega3.Location = new Point(42, 106);
            lblMega3.Name = "lblMega3";
            lblMega3.Size = new Size(50, 20);
            lblMega3.TabIndex = 1;
            lblMega3.Text = "label1";
            // 
            // labelPower2
            // 
            labelPower2.AutoSize = true;
            labelPower2.Location = new Point(42, 178);
            labelPower2.Name = "labelPower2";
            labelPower2.Size = new Size(50, 20);
            labelPower2.TabIndex = 1;
            labelPower2.Text = "label1";
            // 
            // labelPower3
            // 
            labelPower3.AutoSize = true;
            labelPower3.Location = new Point(42, 213);
            labelPower3.Name = "labelPower3";
            labelPower3.Size = new Size(50, 20);
            labelPower3.TabIndex = 1;
            labelPower3.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 277);
            Controls.Add(labelPower3);
            Controls.Add(labelPower2);
            Controls.Add(labelPower1);
            Controls.Add(lblMega3);
            Controls.Add(lblMega2);
            Controls.Add(lblMega1);
            Controls.Add(btnPower655);
            Controls.Add(btnMega645);
            Name = "Form1";
            Text = "Power-Mega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMega645;
        private Label lblMega1;
        private Button btnPower655;
        private Label labelPower1;
        private Label lblMega2;
        private Label lblMega3;
        private Label labelPower2;
        private Label labelPower3;
    }
}
