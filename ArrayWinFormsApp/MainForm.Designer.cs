
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
            this.arrayLenInput.Size = new System.Drawing.Size(66, 27);
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
            this.ArrayLenBtn.Location = new System.Drawing.Point(453, 32);
            this.ArrayLenBtn.Name = "ArrayLenBtn";
            this.ArrayLenBtn.Size = new System.Drawing.Size(94, 29);
            this.ArrayLenBtn.TabIndex = 3;
            this.ArrayLenBtn.Text = "Ввод";
            this.ArrayLenBtn.UseVisualStyleBackColor = true;
            this.ArrayLenBtn.Click += new System.EventHandler(this.ArrayLenBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 506);
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
    }
}

