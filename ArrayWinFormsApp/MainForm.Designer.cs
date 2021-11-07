
namespace ArrayWinFormsApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.arrayLenInput = new System.Windows.Forms.TextBox();
            this.arrayLabel = new System.Windows.Forms.Label();
            this.ArrayLenBtn = new System.Windows.Forms.Button();
            this.SumBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.multiplyInput = new System.Windows.Forms.TextBox();
            this.divideInput = new System.Windows.Forms.TextBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество элементов массива";
            // 
            // arrayLenInput
            // 
            this.arrayLenInput.Location = new System.Drawing.Point(364, 32);
            this.arrayLenInput.Name = "arrayLenInput";
            this.arrayLenInput.Size = new System.Drawing.Size(49, 27);
            this.arrayLenInput.TabIndex = 1;
            // 
            // arrayLabel
            // 
            this.arrayLabel.AutoSize = true;
            this.arrayLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrayLabel.Location = new System.Drawing.Point(24, 79);
            this.arrayLabel.Name = "arrayLabel";
            this.arrayLabel.Size = new System.Drawing.Size(73, 23);
            this.arrayLabel.TabIndex = 2;
            this.arrayLabel.Text = "Массив:";
            // 
            // ArrayLenBtn
            // 
            this.ArrayLenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ArrayLenBtn.Location = new System.Drawing.Point(441, 31);
            this.ArrayLenBtn.Name = "ArrayLenBtn";
            this.ArrayLenBtn.Size = new System.Drawing.Size(94, 29);
            this.ArrayLenBtn.TabIndex = 3;
            this.ArrayLenBtn.Text = "Ввод";
            this.ArrayLenBtn.UseVisualStyleBackColor = false;
            this.ArrayLenBtn.Click += new System.EventHandler(this.ArrayLenBtn_Click);
            // 
            // SumBtn
            // 
            this.SumBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SumBtn.Location = new System.Drawing.Point(24, 150);
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Size = new System.Drawing.Size(216, 29);
            this.SumBtn.TabIndex = 4;
            this.SumBtn.Text = "Сложить массивы";
            this.SumBtn.UseVisualStyleBackColor = false;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MultiplyBtn.Location = new System.Drawing.Point(24, 197);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(216, 29);
            this.MultiplyBtn.TabIndex = 5;
            this.MultiplyBtn.Text = "Умножить на число";
            this.MultiplyBtn.UseVisualStyleBackColor = false;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DivideBtn.Location = new System.Drawing.Point(24, 243);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(216, 29);
            this.DivideBtn.TabIndex = 6;
            this.DivideBtn.Text = "Разделить на число";
            this.DivideBtn.UseVisualStyleBackColor = false;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // multiplyInput
            // 
            this.multiplyInput.Location = new System.Drawing.Point(259, 198);
            this.multiplyInput.Name = "multiplyInput";
            this.multiplyInput.Size = new System.Drawing.Size(46, 27);
            this.multiplyInput.TabIndex = 7;
            // 
            // divideInput
            // 
            this.divideInput.Location = new System.Drawing.Point(259, 244);
            this.divideInput.Name = "divideInput";
            this.divideInput.Size = new System.Drawing.Size(46, 27);
            this.divideInput.TabIndex = 8;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(340, 211);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(189, 40);
            this.labelInstruction.TabIndex = 9;
            this.labelInstruction.Text = "(сначала ввести число,\r\n потом нажать на кнопку)\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(574, 320);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.divideInput);
            this.Controls.Add(this.multiplyInput);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.ArrayLenBtn);
            this.Controls.Add(this.arrayLabel);
            this.Controls.Add(this.arrayLenInput);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arrayLenInput;
        private System.Windows.Forms.Label arrayLabel;
        private System.Windows.Forms.Button ArrayLenBtn;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.TextBox multiplyInput;
        private System.Windows.Forms.TextBox divideInput;
        private System.Windows.Forms.Label labelInstruction;
    }
}

