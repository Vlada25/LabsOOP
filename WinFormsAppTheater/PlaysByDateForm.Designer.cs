
namespace WinFormsAppTheater
{
    partial class PlaysByDateForm
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
            this.SelectDateBtn = new System.Windows.Forms.Button();
            this.SelectedDataTable = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.enterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDateBtn
            // 
            this.SelectDateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SelectDateBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectDateBtn.Location = new System.Drawing.Point(422, 36);
            this.SelectDateBtn.Name = "SelectDateBtn";
            this.SelectDateBtn.Size = new System.Drawing.Size(94, 30);
            this.SelectDateBtn.TabIndex = 0;
            this.SelectDateBtn.Text = "Ввод";
            this.SelectDateBtn.UseVisualStyleBackColor = false;
            this.SelectDateBtn.Click += new System.EventHandler(this.SelectDateBtn_Click);
            // 
            // SelectedDataTable
            // 
            this.SelectedDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SelectedDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedDataTable.Location = new System.Drawing.Point(12, 109);
            this.SelectedDataTable.Name = "SelectedDataTable";
            this.SelectedDataTable.RowHeadersWidth = 51;
            this.SelectedDataTable.RowTemplate.Height = 29;
            this.SelectedDataTable.Size = new System.Drawing.Size(973, 329);
            this.SelectedDataTable.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterLabel.Location = new System.Drawing.Point(12, 36);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(131, 25);
            this.enterLabel.TabIndex = 3;
            this.enterLabel.Text = "Выберите дату";
            // 
            // PlaysByDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SelectedDataTable);
            this.Controls.Add(this.SelectDateBtn);
            this.Name = "PlaysByDateForm";
            this.Text = "Вывод спектаклей в выбранную дату";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectDateBtn;
        private System.Windows.Forms.DataGridView SelectedDataTable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label enterLabel;
    }
}