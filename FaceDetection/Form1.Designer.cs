
namespace FaceDetection
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
            this.idButton = new System.Windows.Forms.Button();
            this.faceButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.successCount = new System.Windows.Forms.Label();
            this.failCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // idButton
            // 
            this.idButton.Location = new System.Drawing.Point(12, 7);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(162, 186);
            this.idButton.TabIndex = 0;
            this.idButton.Text = "ID Detection Mode";
            this.idButton.UseVisualStyleBackColor = true;
            this.idButton.Click += new System.EventHandler(this.idButton_Click);
            // 
            // faceButton
            // 
            this.faceButton.Location = new System.Drawing.Point(12, 205);
            this.faceButton.Name = "faceButton";
            this.faceButton.Size = new System.Drawing.Size(162, 186);
            this.faceButton.TabIndex = 1;
            this.faceButton.Text = "Face Detection Mode";
            this.faceButton.UseVisualStyleBackColor = true;
            this.faceButton.Click += new System.EventHandler(this.faceButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(12, 415);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(110, 23);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "Select Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // folderBox
            // 
            this.folderBox.Enabled = false;
            this.folderBox.Location = new System.Drawing.Point(128, 418);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(498, 20);
            this.folderBox.TabIndex = 3;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(180, 7);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(446, 384);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Success:";
            // 
            // successCount
            // 
            this.successCount.AutoSize = true;
            this.successCount.Location = new System.Drawing.Point(497, 398);
            this.successCount.Name = "successCount";
            this.successCount.Size = new System.Drawing.Size(13, 13);
            this.successCount.TabIndex = 6;
            this.successCount.Text = "0";
            // 
            // failCount
            // 
            this.failCount.AutoSize = true;
            this.failCount.Location = new System.Drawing.Point(566, 398);
            this.failCount.Name = "failCount";
            this.failCount.Size = new System.Drawing.Size(13, 13);
            this.failCount.TabIndex = 8;
            this.failCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fail:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 448);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(110, 30);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(653, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 384);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 490);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.failCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.successCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.folderBox);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.faceButton);
            this.Controls.Add(this.idButton);
            this.Name = "Form1";
            this.Text = "Jarvis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button idButton;
        private System.Windows.Forms.Button faceButton;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label successCount;
        private System.Windows.Forms.Label failCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

