/*
 * Created by SharpDevelop.
 * User: User
 * Date: 10/06/2022
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UTS_PV
{
	partial class DetailPembelian
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
			this.label2 = new System.Windows.Forms.Label();
			this.cmbBarang = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnBersihkan = new System.Windows.Forms.Button();
			this.btnHapus = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSimpan = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdPembelian = new System.Windows.Forms.TextBox();
			this.btnCari = new System.Windows.Forms.Button();
			this.kuantitas = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTotalHarga = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kuantitas)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(140, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 138;
			this.label2.Text = "BARANG : ";
			// 
			// cmbBarang
			// 
			this.cmbBarang.FormattingEnabled = true;
			this.cmbBarang.Location = new System.Drawing.Point(222, 94);
			this.cmbBarang.Name = "cmbBarang";
			this.cmbBarang.Size = new System.Drawing.Size(503, 21);
			this.cmbBarang.TabIndex = 137;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(42, 273);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(280, 29);
			this.label3.TabIndex = 136;
			this.label3.Text = "DB : Toko Pak Budi, Table : Detail_Pembelian";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnBersihkan
			// 
			this.btnBersihkan.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnBersihkan.Location = new System.Drawing.Point(605, 184);
			this.btnBersihkan.Name = "btnBersihkan";
			this.btnBersihkan.Size = new System.Drawing.Size(75, 29);
			this.btnBersihkan.TabIndex = 134;
			this.btnBersihkan.Text = "Bersihkan";
			this.btnBersihkan.UseVisualStyleBackColor = false;
			this.btnBersihkan.Click += new System.EventHandler(this.BtnBersihkanClick);
			// 
			// btnHapus
			// 
			this.btnHapus.BackColor = System.Drawing.Color.LightCoral;
			this.btnHapus.Enabled = false;
			this.btnHapus.Location = new System.Drawing.Point(462, 184);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(75, 29);
			this.btnHapus.TabIndex = 133;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = false;
			this.btnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Gold;
			this.btnEdit.Enabled = false;
			this.btnEdit.Location = new System.Drawing.Point(319, 184);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 29);
			this.btnEdit.TabIndex = 132;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnSimpan
			// 
			this.btnSimpan.BackColor = System.Drawing.Color.SpringGreen;
			this.btnSimpan.Location = new System.Drawing.Point(176, 184);
			this.btnSimpan.Name = "btnSimpan";
			this.btnSimpan.Size = new System.Drawing.Size(75, 29);
			this.btnSimpan.TabIndex = 131;
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
			this.dataGridView1.Location = new System.Drawing.Point(42, 310);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(751, 163);
			this.dataGridView1.TabIndex = 130;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(100, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 16);
			this.label1.TabIndex = 129;
			this.label1.Text = "ID PEMBELIAN : ";
			// 
			// txtIdPembelian
			// 
			this.txtIdPembelian.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdPembelian.Location = new System.Drawing.Point(222, 54);
			this.txtIdPembelian.Name = "txtIdPembelian";
			this.txtIdPembelian.Size = new System.Drawing.Size(400, 20);
			this.txtIdPembelian.TabIndex = 128;
			// 
			// btnCari
			// 
			this.btnCari.Location = new System.Drawing.Point(649, 50);
			this.btnCari.Name = "btnCari";
			this.btnCari.Size = new System.Drawing.Size(75, 23);
			this.btnCari.TabIndex = 139;
			this.btnCari.Text = "Cari";
			this.btnCari.UseVisualStyleBackColor = true;
			this.btnCari.Click += new System.EventHandler(this.BtnCariClick);
			// 
			// kuantitas
			// 
			this.kuantitas.Location = new System.Drawing.Point(222, 135);
			this.kuantitas.Name = "kuantitas";
			this.kuantitas.Size = new System.Drawing.Size(502, 20);
			this.kuantitas.TabIndex = 140;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(117, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 16);
			this.label4.TabIndex = 141;
			this.label4.Text = "KUANTITAS : ";
			// 
			// txtTotalHarga
			// 
			this.txtTotalHarga.BackColor = System.Drawing.SystemColors.Window;
			this.txtTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTotalHarga.Enabled = false;
			this.txtTotalHarga.Location = new System.Drawing.Point(649, 278);
			this.txtTotalHarga.Name = "txtTotalHarga";
			this.txtTotalHarga.Size = new System.Drawing.Size(144, 20);
			this.txtTotalHarga.TabIndex = 142;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(568, 273);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 29);
			this.label5.TabIndex = 143;
			this.label5.Text = "Total Harga";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DetailPembelian
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(835, 526);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTotalHarga);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.kuantitas);
			this.Controls.Add(this.btnCari);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbBarang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnBersihkan);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSimpan);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIdPembelian);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DetailPembelian";
			this.Text = "DetailPembelian";
			this.Load += new System.EventHandler(this.DetailPembelianLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kuantitas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTotalHarga;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown kuantitas;
		private System.Windows.Forms.Button btnCari;
		private System.Windows.Forms.TextBox txtIdPembelian;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSimpan;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnBersihkan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbBarang;
		private System.Windows.Forms.Label label2;
	}
}
