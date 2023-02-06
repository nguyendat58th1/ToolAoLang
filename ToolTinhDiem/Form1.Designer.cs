namespace ToolTinhDiem
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtScore1 = new System.Windows.Forms.TextBox();
			this.txtScore2 = new System.Windows.Forms.TextBox();
			this.cbPlayer1 = new System.Windows.Forms.ComboBox();
			this.cbPlayer2 = new System.Windows.Forms.ComboBox();
			this.btnUpdateScore = new System.Windows.Forms.Button();
			this.btnImportData = new System.Windows.Forms.Button();
			this.btnDeleteAllFile = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 105);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(828, 127);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Người chơi 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(246, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Người chơi 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(146, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tỉ số";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(156, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "-";
			// 
			// txtScore1
			// 
			this.txtScore1.Location = new System.Drawing.Point(110, 37);
			this.txtScore1.Name = "txtScore1";
			this.txtScore1.Size = new System.Drawing.Size(40, 20);
			this.txtScore1.TabIndex = 7;
			this.txtScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtScore2
			// 
			this.txtScore2.Location = new System.Drawing.Point(172, 37);
			this.txtScore2.Name = "txtScore2";
			this.txtScore2.Size = new System.Drawing.Size(39, 20);
			this.txtScore2.TabIndex = 8;
			this.txtScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbPlayer1
			// 
			this.cbPlayer1.FormattingEnabled = true;
			this.cbPlayer1.Location = new System.Drawing.Point(3, 36);
			this.cbPlayer1.Name = "cbPlayer1";
			this.cbPlayer1.Size = new System.Drawing.Size(92, 21);
			this.cbPlayer1.TabIndex = 9;
			this.cbPlayer1.SelectedIndexChanged += new System.EventHandler(this.cbPlayer1_SelectedIndexChanged);
			// 
			// cbPlayer2
			// 
			this.cbPlayer2.FormattingEnabled = true;
			this.cbPlayer2.Location = new System.Drawing.Point(225, 36);
			this.cbPlayer2.Name = "cbPlayer2";
			this.cbPlayer2.Size = new System.Drawing.Size(88, 21);
			this.cbPlayer2.TabIndex = 10;
			this.cbPlayer2.SelectedIndexChanged += new System.EventHandler(this.cbPlayer2_SelectedIndexChanged);
			// 
			// btnUpdateScore
			// 
			this.btnUpdateScore.Location = new System.Drawing.Point(2, 67);
			this.btnUpdateScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnUpdateScore.Name = "btnUpdateScore";
			this.btnUpdateScore.Size = new System.Drawing.Size(100, 19);
			this.btnUpdateScore.TabIndex = 11;
			this.btnUpdateScore.Text = "Cập nhật kết quả";
			this.btnUpdateScore.UseVisualStyleBackColor = true;
			this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
			// 
			// btnImportData
			// 
			this.btnImportData.Location = new System.Drawing.Point(225, 67);
			this.btnImportData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnImportData.Name = "btnImportData";
			this.btnImportData.Size = new System.Drawing.Size(87, 19);
			this.btnImportData.TabIndex = 12;
			this.btnImportData.Text = "Import dữ liệu";
			this.btnImportData.UseVisualStyleBackColor = true;
			this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
			// 
			// btnDeleteAllFile
			// 
			this.btnDeleteAllFile.Location = new System.Drawing.Point(110, 67);
			this.btnDeleteAllFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDeleteAllFile.Name = "btnDeleteAllFile";
			this.btnDeleteAllFile.Size = new System.Drawing.Size(100, 19);
			this.btnDeleteAllFile.TabIndex = 13;
			this.btnDeleteAllFile.Text = "Xóa tất cả file backup";
			this.btnDeleteAllFile.UseVisualStyleBackColor = true;
			this.btnDeleteAllFile.Click += new System.EventHandler(this.btnDeleteAllFile_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 232);
			this.Controls.Add(this.btnDeleteAllFile);
			this.Controls.Add(this.btnImportData);
			this.Controls.Add(this.btnUpdateScore);
			this.Controls.Add(this.cbPlayer2);
			this.Controls.Add(this.cbPlayer1);
			this.Controls.Add(this.txtScore2);
			this.Controls.Add(this.txtScore1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtScore1;
		private System.Windows.Forms.TextBox txtScore2;
		private System.Windows.Forms.ComboBox cbPlayer1;
		private System.Windows.Forms.ComboBox cbPlayer2;
		private System.Windows.Forms.Button btnUpdateScore;
		private System.Windows.Forms.Button btnImportData;
		private System.Windows.Forms.Button btnDeleteAllFile;
	}
}

