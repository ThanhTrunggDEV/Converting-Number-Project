namespace ConvertingNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputData = new System.Windows.Forms.TextBox();
            this.caculateButton = new System.Windows.Forms.Button();
            this.binaryOutPut = new System.Windows.Forms.TextBox();
            this.hexadecimalOutPut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(212, 157);
            this.inputData.Margin = new System.Windows.Forms.Padding(2);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(86, 20);
            this.inputData.TabIndex = 1;
            // 
            // caculateButton
            // 
            this.caculateButton.Location = new System.Drawing.Point(302, 158);
            this.caculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.caculateButton.Name = "caculateButton";
            this.caculateButton.Size = new System.Drawing.Size(62, 19);
            this.caculateButton.TabIndex = 0;
            this.caculateButton.Text = "Caculate";
            this.caculateButton.UseVisualStyleBackColor = true;
            this.caculateButton.Click += new System.EventHandler(this.CaculateButton_Click_Event_1);
            // 
            // binaryOutPut
            // 
            this.binaryOutPut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.binaryOutPut.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.binaryOutPut.Location = new System.Drawing.Point(212, 180);
            this.binaryOutPut.Margin = new System.Windows.Forms.Padding(2);
            this.binaryOutPut.Name = "binaryOutPut";
            this.binaryOutPut.Size = new System.Drawing.Size(209, 20);
            this.binaryOutPut.TabIndex = 2;
            // 
            // hexadecimalOutPut
            // 
            this.hexadecimalOutPut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hexadecimalOutPut.Location = new System.Drawing.Point(212, 206);
            this.hexadecimalOutPut.Name = "hexadecimalOutPut";
            this.hexadecimalOutPut.Size = new System.Drawing.Size(100, 20);
            this.hexadecimalOutPut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hexadecimalOutPut);
            this.Controls.Add(this.binaryOutPut);
            this.Controls.Add(this.caculateButton);
            this.Controls.Add(this.inputData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Number Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.Button caculateButton;
        private System.Windows.Forms.TextBox binaryOutPut;
        private System.Windows.Forms.TextBox hexadecimalOutPut;
    }
}

