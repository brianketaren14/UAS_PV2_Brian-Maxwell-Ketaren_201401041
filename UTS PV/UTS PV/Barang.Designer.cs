/*
 * Created by SharpDevelop.
 * User: User
 * Date: 07/06/2022
 * Time: 23:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UTS_PV
{
	partial class Barang
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
			this.label9 = new System.Windows.Forms.Label();
			this.txtHarga = new System.Windows.Forms.TextBox();
			this.btnBersihkan = new System.Windows.Forms.Button();
			this.btnHapus = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSimpan = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNamaBarang = new System.Windows.Forms.TextBox();
			this.txtIdBarang = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(156, 126);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 16);
			this.label9.TabIndex = 156;
			this.label9.Text = "HARGA : ";
			// 
			// txtHarga
			// 
			this.txtHarga.Location = new System.Drawing.Point(230, 126);
			this.txtHarga.Name = "txtHarga";
			this.txtHarga.Size = new System.Drawing.Size(503, 20);
			this.txtHarga.TabIndex = 155;
			// 
			// btnBersihkan
			// 
			this.btnBersihkan.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnBersihkan.Location = new System.Drawing.Point(597, 174);
			this.btnBersihkan.Name = "btnBersihkan";
			this.btnBersihkan.Size = new System.Drawing.Size(75, 29);
			this.btnBersihkan.TabIndex = 148;
			this.btnBersihkan.Text = "Bersihkan";
			this.btnBersihkan.UseVisualStyleBackColor = false;
			this.btnBersihkan.Click += new System.EventHandler(this.BtnBersihkanClick);
			// 
			// btnHapus
			// 
			this.btnHapus.BackColor = System.Drawing.Color.LightCoral;
			this.btnHapus.Enabled = false;
			this.btnHapus.Location = new System.Drawing.Point(454, 174);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(75, 29);
			this.btnHapus.TabIndex = 147;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = false;
			this.btnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Gold;
			this.btnEdit.Enabled = false;
			this.btnEdit.Location = new System.Drawing.Point(311, 174);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 29);
			this.btnEdit.TabIndex = 146;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnSimpan
			// 
			this.btnSimpan.BackColor = System.Drawing.Color.SpringGreen;
			this.btnSimpan.Location = new System.Drawing.Point(168, 174);
			this.btnSimpan.Name = "btnSimpan";
			this.btnSimpan.Size = new System.Drawing.Size(75, 29);
			this.btnSimpan.TabIndex = 145;
			this.btnSimpan.Text = "Simpan";
			this.btnSimpan.UseVisualStyleBackColor = false;
			this.btnSimpan.Click += new System.EventHandler(this.BtnSimpanClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 296);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 29);
			this.label3.TabIndex = 142;
			this.label3.Text = "DB : Cleanx, Table : Barang";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.dataGridView1.Location = new System.Drawing.Point(36, 333);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(751, 163);
			this.dataGridView1.TabIndex = 141;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(99, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 16);
			this.label2.TabIndex = 140;
			this.label2.Text = "NAMA BARANG  : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(128, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 16);
			this.label1.TabIndex = 139;
			this.label1.Text = "ID BARANG : ";
			// 
			// txtNamaBarang
			// 
			this.txtNamaBarang.Location = new System.Drawing.Point(229, 92);
			this.txtNamaBarang.Name = "txtNamaBarang";
			this.txtNamaBarang.Size = new System.Drawing.Size(503, 20);
			this.txtNamaBarang.TabIndex = 138;
			// 
			// txtIdBarang
			// 
			this.txtIdBarang.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdBarang.Location = new System.Drawing.Point(229, 58);
			this.txtIdBarang.Name = "txtIdBarang";
			this.txtIdBarang.Size = new System.Drawing.Size(503, 20);
			this.txtIdBarang.TabIndex = 137;
			// 
			// Barang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(822, 516);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtHarga);
			this.Controls.Add(this.btnBersihkan);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSimpan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNamaBarang);
			this.Controls.Add(this.txtIdBarang);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Barang";
			this.Text = "Barang";
			this.Load += new System.EventHandler(this.BarangLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtIdBarang;
		private System.Windows.Forms.TextBox txtNamaBarang;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSimpan;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnBersihkan;
		private System.Windows.Forms.TextBox txtHarga;
		private System.Windows.Forms.Label label9;
	}
}
