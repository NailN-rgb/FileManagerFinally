namespace FIleManager
{
    partial class ForCopyAndOtherForm
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
            this.newPathTextBox = new System.Windows.Forms.TextBox();
            this.process = new System.Windows.Forms.Label();
            this.newPath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPathTextBox
            // 
            this.newPathTextBox.Location = new System.Drawing.Point(79, 45);
            this.newPathTextBox.Name = "newPathTextBox";
            this.newPathTextBox.Size = new System.Drawing.Size(265, 20);
            this.newPathTextBox.TabIndex = 1;
            // 
            // process
            // 
            this.process.AutoSize = true;
            this.process.Location = new System.Drawing.Point(129, 9);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(35, 13);
            this.process.TabIndex = 2;
            this.process.Text = "label1";
            // 
            // newPath
            // 
            this.newPath.AutoSize = true;
            this.newPath.Location = new System.Drawing.Point(2, 48);
            this.newPath.Name = "newPath";
            this.newPath.Size = new System.Drawing.Size(69, 13);
            this.newPath.TabIndex = 4;
            this.newPath.Text = "Новый путь:";
            this.newPath.Click += new System.EventHandler(this.newPath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ок!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ForCopyAndOtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 117);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newPath);
            this.Controls.Add(this.process);
            this.Controls.Add(this.newPathTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForCopyAndOtherForm";
            this.Text = "ForCopyAndOtherForm";
            this.Load += new System.EventHandler(this.ForCopyAndOtherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label process;
        private System.Windows.Forms.Label newPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox newPathTextBox;
    }
}