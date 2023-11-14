
namespace MRChecker
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.buttonAdd = new System.Windows.Forms.Button();
			this.textUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonListUpdate = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.MangaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsLatest = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UpdateButton = new System.Windows.Forms.DataGridViewButtonColumn();
			this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNum = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(456, 104);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(76, 23);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "追加";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// textUrl
			// 
			this.textUrl.Location = new System.Drawing.Point(46, 104);
			this.textUrl.Name = "textUrl";
			this.textUrl.Size = new System.Drawing.Size(404, 23);
			this.textUrl.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(12, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "URL: ";
			// 
			// buttonListUpdate
			// 
			this.buttonListUpdate.Location = new System.Drawing.Point(330, 143);
			this.buttonListUpdate.Name = "buttonListUpdate";
			this.buttonListUpdate.Size = new System.Drawing.Size(202, 29);
			this.buttonListUpdate.TabIndex = 3;
			this.buttonListUpdate.Text = "リストを更新";
			this.buttonListUpdate.UseVisualStyleBackColor = true;
			this.buttonListUpdate.Click += new System.EventHandler(this.buttonListUpdate_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MangaName,
            this.IsLatest,
            this.UpdateButton,
            this.DeleteButton});
			this.dataGridView.Location = new System.Drawing.Point(12, 178);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 25;
			this.dataGridView.Size = new System.Drawing.Size(520, 250);
			this.dataGridView.TabIndex = 6;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// MangaName
			// 
			this.MangaName.HeaderText = "漫画名";
			this.MangaName.Name = "MangaName";
			this.MangaName.Width = 260;
			// 
			// IsLatest
			// 
			this.IsLatest.HeaderText = "最新?";
			this.IsLatest.Name = "IsLatest";
			this.IsLatest.Width = 70;
			// 
			// UpdateButton
			// 
			this.UpdateButton.HeaderText = "更新";
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.UpdateButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.UpdateButton.Text = "読んだ!";
			this.UpdateButton.UseColumnTextForButtonValue = true;
			this.UpdateButton.Width = 60;
			// 
			// DeleteButton
			// 
			this.DeleteButton.HeaderText = "削除";
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DeleteButton.Text = "削除";
			this.DeleteButton.UseColumnTextForButtonValue = true;
			this.DeleteButton.Width = 60;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(544, 84);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(12, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "登録漫画数: ";
			// 
			// textBoxNum
			// 
			this.textBoxNum.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.textBoxNum.Font = new System.Drawing.Font("Yu Gothic UI", 14.10309F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxNum.ForeColor = System.Drawing.SystemColors.Control;
			this.textBoxNum.Location = new System.Drawing.Point(86, 139);
			this.textBoxNum.Name = "textBoxNum";
			this.textBoxNum.ReadOnly = true;
			this.textBoxNum.Size = new System.Drawing.Size(45, 33);
			this.textBoxNum.TabIndex = 9;
			this.textBoxNum.Text = "100";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(544, 441);
			this.Controls.Add(this.textBoxNum);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textUrl);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.buttonListUpdate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "MRChecker";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.TextBox textUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonListUpdate;
		private System.Windows.Forms.ColumnHeader UpdateCurrent;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MangaName;
		private System.Windows.Forms.DataGridViewTextBoxColumn IsLatest;
		private System.Windows.Forms.DataGridViewButtonColumn UpdateButton;
		private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNum;
	}
}

