namespace ResultFormApp
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
            btnRead = new Button();
            richTextBox1 = new RichTextBox();
            btnCounter = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(56, 27);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 0;
            btnRead.Text = "Oku";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(56, 86);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(191, 170);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btnCounter
            // 
            btnCounter.Location = new Point(304, 27);
            btnCounter.Name = "btnCounter";
            btnCounter.Size = new Size(75, 23);
            btnCounter.TabIndex = 2;
            btnCounter.Text = "Sayaç";
            btnCounter.UseVisualStyleBackColor = true;
            btnCounter.Click += btnCounter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCounter);
            Controls.Add(richTextBox1);
            Controls.Add(btnRead);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private RichTextBox richTextBox1;
        private Button btnCounter;
    }
}
