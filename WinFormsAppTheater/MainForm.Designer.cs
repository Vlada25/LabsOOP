
namespace WinFormsAppTheater
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
            this.viewBtn = new System.Windows.Forms.Button();
            this.DataTablePlays = new System.Windows.Forms.DataGridView();
            this.ViewVisits = new System.Windows.Forms.Button();
            this.CountVisits = new System.Windows.Forms.Button();
            this.FindMostPopularGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTablePlays)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewBtn.Location = new System.Drawing.Point(703, 549);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(198, 38);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "Вывести репертуар";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // DataTablePlays
            // 
            this.DataTablePlays.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataTablePlays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTablePlays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTablePlays.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataTablePlays.Location = new System.Drawing.Point(12, 12);
            this.DataTablePlays.Name = "DataTablePlays";
            this.DataTablePlays.RowHeadersWidth = 51;
            this.DataTablePlays.RowTemplate.Height = 29;
            this.DataTablePlays.Size = new System.Drawing.Size(980, 461);
            this.DataTablePlays.TabIndex = 3;
            // 
            // ViewVisits
            // 
            this.ViewVisits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ViewVisits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewVisits.Location = new System.Drawing.Point(12, 495);
            this.ViewVisits.Name = "ViewVisits";
            this.ViewVisits.Size = new System.Drawing.Size(523, 38);
            this.ViewVisits.TabIndex = 4;
            this.ViewVisits.Text = "Вывести все спектакли за указанную дату";
            this.ViewVisits.UseVisualStyleBackColor = false;
            this.ViewVisits.Click += new System.EventHandler(this.ViewVisits_Click);
            // 
            // CountVisits
            // 
            this.CountVisits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CountVisits.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountVisits.Location = new System.Drawing.Point(12, 549);
            this.CountVisits.Name = "CountVisits";
            this.CountVisits.Size = new System.Drawing.Size(523, 38);
            this.CountVisits.TabIndex = 5;
            this.CountVisits.Text = "Подстчитать среднее кол-во спектаклей за указанный период";
            this.CountVisits.UseVisualStyleBackColor = false;
            this.CountVisits.Click += new System.EventHandler(this.CountVisits_Click);
            // 
            // FindMostPopularGenre
            // 
            this.FindMostPopularGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FindMostPopularGenre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindMostPopularGenre.Location = new System.Drawing.Point(12, 603);
            this.FindMostPopularGenre.Name = "FindMostPopularGenre";
            this.FindMostPopularGenre.Size = new System.Drawing.Size(523, 38);
            this.FindMostPopularGenre.TabIndex = 6;
            this.FindMostPopularGenre.Text = "Найти самый популярный жанр за указанный период\r\n";
            this.FindMostPopularGenre.UseVisualStyleBackColor = false;
            this.FindMostPopularGenre.Click += new System.EventHandler(this.FindMostPopularGenre_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.FindMostPopularGenre);
            this.Controls.Add(this.CountVisits);
            this.Controls.Add(this.ViewVisits);
            this.Controls.Add(this.DataTablePlays);
            this.Controls.Add(this.viewBtn);
            this.Name = "MainForm";
            this.Text = "Репертуар театра";
            ((System.ComponentModel.ISupportInitialize)(this.DataTablePlays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView DataTablePlays;
        private System.Windows.Forms.Button ViewVisits;
        private System.Windows.Forms.Button CountVisits;
        private System.Windows.Forms.Button FindMostPopularGenre;
    }
}

