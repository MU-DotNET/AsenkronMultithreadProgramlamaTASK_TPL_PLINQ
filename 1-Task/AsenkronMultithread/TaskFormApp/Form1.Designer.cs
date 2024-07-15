namespace TaskFormApp
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
            Button btnReadFile;
            Button btnCounter;
            richTextBoxFile = new RichTextBox();
            txtCounter = new TextBox();
            richTextBoxProcess = new RichTextBox();
            btnReadFile = new Button();
            btnCounter = new Button();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(12, 12);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(75, 23);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "Dosya Oku";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnCounter
            // 
            btnCounter.Location = new Point(320, 12);
            btnCounter.Name = "btnCounter";
            btnCounter.Size = new Size(75, 23);
            btnCounter.TabIndex = 2;
            btnCounter.Text = "Sayaç Arttır";
            btnCounter.UseVisualStyleBackColor = true;
            btnCounter.Click += btnCounter_Click;
            // 
            // richTextBoxFile
            // 
            richTextBoxFile.Location = new Point(12, 60);
            richTextBoxFile.Name = "richTextBoxFile";
            richTextBoxFile.Size = new Size(176, 161);
            richTextBoxFile.TabIndex = 1;
            richTextBoxFile.Text = "";
            // 
            // txtCounter
            // 
            txtCounter.Location = new Point(311, 60);
            txtCounter.Name = "txtCounter";
            txtCounter.Size = new Size(144, 23);
            txtCounter.TabIndex = 3;
            // 
            // richTextBoxProcess
            // 
            richTextBoxProcess.Location = new Point(556, 60);
            richTextBoxProcess.Name = "richTextBoxProcess";
            richTextBoxProcess.Size = new Size(176, 161);
            richTextBoxProcess.TabIndex = 4;
            richTextBoxProcess.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxProcess);
            Controls.Add(txtCounter);
            Controls.Add(btnCounter);
            Controls.Add(richTextBoxFile);
            Controls.Add(btnReadFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadFile;
        private RichTextBox richTextBoxFile;
        private TextBox txtCounter;
        private RichTextBox richTextBoxProcess;
    }
}
