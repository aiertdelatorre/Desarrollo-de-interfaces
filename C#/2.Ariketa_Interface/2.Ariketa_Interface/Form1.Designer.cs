namespace _2.Ariketa_Interface
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
            label1 = new Label();
            textBox1 = new TextBox();
            Garbitu = new Button();
            Hurrengoa = new Button();
            Irten = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 141);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "1.Zenbakia";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(612, 27);
            textBox1.TabIndex = 1;
            // 
            // Garbitu
            // 
            Garbitu.Location = new Point(427, 237);
            Garbitu.Name = "Garbitu";
            Garbitu.Size = new Size(94, 29);
            Garbitu.TabIndex = 2;
            Garbitu.Text = "Garbitu";
            Garbitu.UseVisualStyleBackColor = true;
            Garbitu.Click += Garbitu_OnClick;
            // 
            // Hurrengoa
            // 
            Hurrengoa.Location = new Point(173, 237);
            Hurrengoa.Name = "Hurrengoa";
            Hurrengoa.Size = new Size(94, 29);
            Hurrengoa.TabIndex = 3;
            Hurrengoa.Text = "Hurrengoa";
            Hurrengoa.UseVisualStyleBackColor = true;
            Hurrengoa.Click += Hurrengoa_OnClick;

            // 
            // Irten
            // 
            Irten.Location = new Point(691, 237);
            Irten.Name = "Irten";
            Irten.Size = new Size(94, 29);
            Irten.TabIndex = 4;
            Irten.Text = "Irten";
            Irten.UseVisualStyleBackColor = true;
            Irten.Click += Irten_OnClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 333);
            Controls.Add(Irten);
            Controls.Add(Hurrengoa);
            Controls.Add(Garbitu);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button Garbitu;
        private Button Hurrengoa;
        private Button Irten;
    }
}