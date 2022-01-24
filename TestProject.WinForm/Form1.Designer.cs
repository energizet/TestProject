namespace TestProject.WinForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.bAdd = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dtbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtbDeveloper = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dbGenres = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.bAdd, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// bAdd
			// 
			this.bAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bAdd.Location = new System.Drawing.Point(3, 424);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(447, 23);
			this.bAdd.TabIndex = 0;
			this.bAdd.Text = "Add";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtbId,
            this.dtbName,
            this.dtbDeveloper,
            this.dbGenres});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(447, 415);
			this.dataGridView1.TabIndex = 1;
			// 
			// dtbId
			// 
			this.dtbId.HeaderText = "Id";
			this.dtbId.Name = "dtbId";
			this.dtbId.ReadOnly = true;
			// 
			// dtbName
			// 
			this.dtbName.HeaderText = "Name";
			this.dtbName.Name = "dtbName";
			// 
			// dtbDeveloper
			// 
			this.dtbDeveloper.HeaderText = "Developer";
			this.dtbDeveloper.Name = "dtbDeveloper";
			this.dtbDeveloper.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dtbDeveloper.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dbGenres
			// 
			this.dbGenres.HeaderText = "Genres";
			this.dbGenres.Name = "dbGenres";
			this.dbGenres.Text = "Genres";
			this.dbGenres.UseColumnTextForButtonValue = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbId;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dtbDeveloper;
		private System.Windows.Forms.DataGridViewButtonColumn dbGenres;
	}
}
