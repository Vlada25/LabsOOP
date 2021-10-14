
namespace WinFormsAppTheater
{
    partial class CoutnOfPlaysForm
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
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenresDataTable = new System.Windows.Forms.DataGridView();
            this.EnterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GenresDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(127, 61);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(250, 27);
            this.StartDatePicker.TabIndex = 0;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(127, 121);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(250, 27);
            this.EndDatePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(191, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Промежуток";
            // 
            // GenresDataTable
            // 
            this.GenresDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GenresDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenresDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenresDataTable.Location = new System.Drawing.Point(12, 239);
            this.GenresDataTable.Name = "GenresDataTable";
            this.GenresDataTable.RowHeadersWidth = 51;
            this.GenresDataTable.RowTemplate.Height = 29;
            this.GenresDataTable.Size = new System.Drawing.Size(471, 249);
            this.GenresDataTable.TabIndex = 5;
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EnterBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterBtn.Location = new System.Drawing.Point(202, 170);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(94, 38);
            this.EnterBtn.TabIndex = 6;
            this.EnterBtn.Text = "Ввод";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // CoutnOfPlaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(495, 500);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.GenresDataTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Name = "CoutnOfPlaysForm";
            this.Text = "Количество спектаклей по жанрам";
            ((System.ComponentModel.ISupportInitialize)(this.GenresDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GenresDataTable;
        private System.Windows.Forms.Button EnterBtn;
    }
}