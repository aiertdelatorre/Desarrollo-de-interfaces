namespace Esaldiak
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
            textBoxa = new RichTextBox();
            Esaldi1 = new Button();
            Esaldi2 = new Button();
            Esaldi3 = new Button();
            Esaldi4 = new Button();
            Esaldi5 = new Button();
            Lotu = new Button();
            Ezabatu = new Button();
            Itxi = new Button();

            Esaldi2.Enabled = false;
            Esaldi3.Enabled = false;
            Esaldi4.Enabled = false;
            Esaldi5.Enabled = false;
            Lotu.Enabled = false;

            SuspendLayout();
            // 
            // textBoxa
            // 
            textBoxa.Location = new Point(224, 39);
            textBoxa.Name = "textBoxa";
            textBoxa.Size = new Size(672, 210);
            textBoxa.TabIndex = 0;
            textBoxa.Text = "";
            // 
            // Esaldi1
            // 
            Esaldi1.Location = new Point(146, 308);
            Esaldi1.Name = "Esaldi1";
            Esaldi1.Size = new Size(204, 67);
            Esaldi1.TabIndex = 1;
            Esaldi1.Text = "Esaldi1";
            Esaldi1.UseVisualStyleBackColor = true;
            Esaldi1.Click += Esaldi1_Click;
            // 
            // Esaldi2
            // 
            Esaldi2.Location = new Point(489, 308);
            Esaldi2.Name = "Esaldi2";
            Esaldi2.Size = new Size(204, 67);
            Esaldi2.TabIndex = 2;
            Esaldi2.Text = "Esaldi2";
            Esaldi2.UseVisualStyleBackColor = true;
            Esaldi2.Click += Esaldi2_Click;
            // 
            // Esaldi3
            // 
            Esaldi3.Location = new Point(792, 308);
            Esaldi3.Name = "Esaldi3";
            Esaldi3.Size = new Size(204, 67);
            Esaldi3.TabIndex = 3;
            Esaldi3.Text = "Esaldi3";
            Esaldi3.UseVisualStyleBackColor = true;
            Esaldi3.Click += Esaldi3_Click;
            // 
            // Esaldi4
            // 
            Esaldi4.Location = new Point(146, 414);
            Esaldi4.Name = "Esaldi4";
            Esaldi4.Size = new Size(204, 67);
            Esaldi4.TabIndex = 4;
            Esaldi4.Text = "Esaldi4";
            Esaldi4.UseVisualStyleBackColor = true;
            Esaldi4.Click += Esaldi4_Click;
            // 
            // Esaldi5
            // 
            Esaldi5.Location = new Point(489, 414);
            Esaldi5.Name = "Esaldi5";
            Esaldi5.Size = new Size(204, 67);
            Esaldi5.TabIndex = 5;
            Esaldi5.Text = "Esaldi5";
            Esaldi5.UseVisualStyleBackColor = true;
            Esaldi5.Click += Esaldi5_Click;
            // 
            // Lotu
            // 
            Lotu.Location = new Point(792, 414);
            Lotu.Name = "Lotu";
            Lotu.Size = new Size(204, 67);
            Lotu.TabIndex = 6;
            Lotu.Text = "Lotu";
            Lotu.UseVisualStyleBackColor = true;
            Lotu.Click += Lotu_Click;
            // 
            // Ezabatu
            // 
            Ezabatu.Location = new Point(300, 525);
            Ezabatu.Name = "Ezabatu";
            Ezabatu.Size = new Size(204, 67);
            Ezabatu.TabIndex = 7;
            Ezabatu.Text = "Ezabatu";
            Ezabatu.UseVisualStyleBackColor = true;
            Ezabatu.Click += Ezabatu_Click;
            // 
            // Itxi
            // 
            Itxi.Location = new Point(645, 525);
            Itxi.Name = "Itxi";
            Itxi.Size = new Size(204, 67);
            Itxi.TabIndex = 8;
            Itxi.Text = "Itxi";
            Itxi.UseVisualStyleBackColor = true;
            Itxi.Click += Itxi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 625);
            Controls.Add(Itxi);
            Controls.Add(Ezabatu);
            Controls.Add(Lotu);
            Controls.Add(Esaldi5);
            Controls.Add(Esaldi4);
            Controls.Add(Esaldi3);
            Controls.Add(Esaldi2);
            Controls.Add(Esaldi1);
            Controls.Add(textBoxa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox textBoxa;
        private Button Esaldi1;
        private Button Esaldi2;
        private Button Esaldi3;
        private Button Esaldi4;
        private Button Esaldi5;
        private Button Lotu;
        private Button Ezabatu;
        private Button Itxi;
    }
}