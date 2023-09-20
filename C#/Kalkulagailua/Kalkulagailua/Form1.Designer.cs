namespace Kalkulagailua
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
            txtzbk1 = new TextBox();
            txtzbk2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtzbk1
            // 
            txtzbk1.Location = new Point(35, 99);
            txtzbk1.Name = "txtzbk1";
            txtzbk1.Size = new Size(202, 27);
            txtzbk1.TabIndex = 0;
            // 
            // txtzbk2
            // 
            txtzbk2.Location = new Point(545, 99);
            txtzbk2.Name = "txtzbk2";
            txtzbk2.Size = new Size(202, 27);
            txtzbk2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(428, 169);
            button1.Name = "button1";
            button1.Size = new Size(94, 66);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGehitu_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(258, 169);
            button2.Name = "button2";
            button2.Size = new Size(94, 66);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnKendu_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(258, 286);
            button3.Name = "button3";
            button3.Size = new Size(94, 64);
            button3.TabIndex = 4;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnBiderkatu_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(428, 286);
            button4.Name = "button4";
            button4.Size = new Size(94, 64);
            button4.TabIndex = 5;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnZatitu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(559, 56);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 6;
            label1.Text = "Zenbakia 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 56);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 7;
            label2.Text = "Zenbakia 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtzbk2);
            Controls.Add(txtzbk1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtzbk1;
        private TextBox txtzbk2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}