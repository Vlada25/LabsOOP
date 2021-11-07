
namespace ArrayWinFormsApp
{
    partial class SumForm
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
            this.labelArr1 = new System.Windows.Forms.Label();
            this.labelArr2 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelArr1
            // 
            this.labelArr1.AutoSize = true;
            this.labelArr1.Location = new System.Drawing.Point(34, 60);
            this.labelArr1.Name = "labelArr1";
            this.labelArr1.Size = new System.Drawing.Size(50, 20);
            this.labelArr1.TabIndex = 0;
            this.labelArr1.Text = "label1";
            // 
            // labelArr2
            // 
            this.labelArr2.AutoSize = true;
            this.labelArr2.Location = new System.Drawing.Point(34, 133);
            this.labelArr2.Name = "labelArr2";
            this.labelArr2.Size = new System.Drawing.Size(50, 20);
            this.labelArr2.TabIndex = 1;
            this.labelArr2.Text = "label2";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(34, 210);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(50, 20);
            this.labelSum.TabIndex = 2;
            this.labelSum.Text = "label3";
            // 
            // SumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelArr2);
            this.Controls.Add(this.labelArr1);
            this.Name = "SumForm";
            this.Text = "Сумма массивов";
            this.Load += new System.EventHandler(this.SumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelArr1;
        private System.Windows.Forms.Label labelArr2;
        private System.Windows.Forms.Label labelSum;
    }
}