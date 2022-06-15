/*
 * Created by SharpDevelop.
 * User: User
 * Date: 07/06/2022
 * Time: 22:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UTS_PV
{
	partial class Pembelian
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBersihkan = new System.Windows.Forms.Button();
			this.btnHapus = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSimpan = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdPembelian = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbKasir = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tglPembelian = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(91, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 16);
			this.label4.TabIndex = 107;
			this.label4.Text = "TANGGAL BELI : ";
			// 
			// btnBersihkan
			// 
			this.btnBersihkan.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnBersihkan.Location = new System.Drawing.Point(597, 211);
			this.btnBersihkan.Name = "btnBersihkan";
			this.btnBersihkan.Size = new System.Drawing.Size(75, 29);
			this.btnBersihkan.TabIndex = 106;
			this.btnBersihkan.Text = "Bersihkan";
			this.btnBersihkan.UseVisualStyleBackColor = false;
			this.btnBersihkan.Click += new System.EventHandler(this.BtnBersihkanClick);
			// 
			// btnHapus
			// 
			this.btnHapus.BackColor = System.Drawing.Color.LightCoral;
			this.btnHapus.Enabled = false;
			this.btnHapus.Location = new System.Drawing.Point(454, 211);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(75, 29);
			this.btnHapus.TabIndex = 105;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = false;
			this.btnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Gold;
			this.btnEdit.Enabled = false;
			this.btnEdit.Location = new System.Drawing.Point(311, 211);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 29);
			this.btnEdit.TabIndex = 104;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnSimpan
			// 
			this.btnSimpan.BackColor = System.Drawing.Color.SpringGreen;
			this.btnSimpan.Location = new System.Drawing.Point(168, 211);
			this.btnSimpan.Name = "btnSimpan";
			this.btnSimpan.Size = new System.Drawing.Size(75, 29);
			this.btnSimpan.TabIndex = 103;
			this.btnSimpan.Text = "Simpan";
			this.btnSimpan.UseVisualStyleBackColor = false;
			this.btnSimpan.Click += new System.EventHandler(this.BtnSimpanClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(34, 337);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(751, 163);
			this.dataGridView1.TabIndex = 99;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(92, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 16);
			this.label1.TabIndex = 97;
			this.label1.Text = "ID PEMBELIAN : ";
			// 
			// txtIdPembelian
			// 
			this.txtIdPembelian.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdPembelian.Location = new System.Drawing.Point(214, 81);
			this.txtIdPembelian.Name = "txtIdPembelian";
			this.txtIdPembelian.Size = new System.Drawing.Size(503, 20);
			this.txtIdPembelian.TabIndex = 95;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 300);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 29);
			this.label3.TabIndex = 123;
			this.label3.Text = "DB : Toko Pak Budi, Table : Pembelian";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbKasir
			// 
			this.cmbKasir.FormattingEnabled = true;
			this.cmbKasir.Location = new System.Drawing.Point(214, 121);
			this.cmbKasir.Name = "cmbKasir";
			this.cmbKasir.Size = new System.Drawing.Size(503, 21);
			this.cmbKasir.TabIndex = 124;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(145, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 125;
			this.label2.Text = "KASIR : ";
			// 
			// tglPembelian
			// 
			this.tglPembelian.CustomFormat = "yyyy-MM-dd";
			this.tglPembelian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.tglPembelian.Location = new System.Drawing.Point(214, 165);
			this.tglPembelian.Name = "tglPembelian";
			this.tglPembelian.Size = new System.Drawing.Size(503, 20);
			this.tglPembelian.TabIndex = 127;
			this.tglPembelian.Value = new System.DateTime(2022, 5, 11, 0, 0, 0, 0);
			// 
			// Pembelian
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(822, 516);
			this.Controls.Add(this.tglPembelian);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbKasir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnBersihkan);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSimpan);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIdPembelian);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Pembelian";
			this.Text = "Pembelian";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker tglPembelian;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbKasir;
		private System.Windows.Forms.TextBox txtIdPembelian;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSimpan;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnBersihkan;
		private System.Windows.Forms.Label label4;
	}
}
