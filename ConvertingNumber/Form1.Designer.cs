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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(283, 193);
            this.inputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(277, 22);
            this.inputData.TabIndex = 1;
            this.inputData.Text = "Enter Number";
            this.inputData.Click += new System.EventHandler(this.inputTextBoxClickEvent);
            // 
            // caculateButton
            // 
            this.caculateButton.Location = new System.Drawing.Point(566, 193);
            this.caculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caculateButton.Name = "caculateButton";
            this.caculateButton.Size = new System.Drawing.Size(83, 23);
            this.caculateButton.TabIndex = 0;
            this.caculateButton.Text = "Caculate";
            this.caculateButton.UseVisualStyleBackColor = true;
            this.caculateButton.Click += new System.EventHandler(this.CaculateButton_Click_Event_1);
            // 
            // binaryOutPut
            // 
            this.binaryOutPut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.binaryOutPut.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.binaryOutPut.Location = new System.Drawing.Point(283, 222);
            this.binaryOutPut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.binaryOutPut.Name = "binaryOutPut";
            this.binaryOutPut.ReadOnly = true;
            this.binaryOutPut.Size = new System.Drawing.Size(277, 22);
            this.binaryOutPut.TabIndex = 2;
            // 
            // hexadecimalOutPut
            // 
            this.hexadecimalOutPut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hexadecimalOutPut.Location = new System.Drawing.Point(283, 254);
            this.hexadecimalOutPut.Margin = new System.Windows.Forms.Padding(4);
            this.hexadecimalOutPut.Name = "hexadecimalOutPut";
            this.hexadecimalOutPut.ReadOnly = true;
            this.hexadecimalOutPut.Size = new System.Drawing.Size(277, 22);
            this.hexadecimalOutPut.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Binary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hexa  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hexadecimalOutPut);
            this.Controls.Add(this.binaryOutPut);
            this.Controls.Add(this.caculateButton);
            this.Controls.Add(this.inputData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

