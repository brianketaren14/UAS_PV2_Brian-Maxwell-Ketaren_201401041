/*
 * Created by SharpDevelop.
 * User: User
 * Date: 07/06/2022
 * Time: 23:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UTS_PV
{
	partial class Kasir
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
			this.label5 = new System.Windows.Forms.Label();
			this.txtAlamat = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNoHp = new System.Windows.Forms.TextBox();
			this.btnBersihkan = new System.Windows.Forms.Button();
			this.btnHapus = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSimpan = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.txtIdKasir = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(114, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 16);
			this.label5.TabIndex = 133;
			this.label5.Text = "ALAMAT : ";
			// 
			// txtAlamat
			// 
			this.txtAlamat.BackColor = System.Drawing.SystemColors.Window;
			this.txtAlamat.Location = new System.Drawing.Point(197, 148);
			this.txtAlamat.Name = "txtAlamat";
			this.txtAlamat.Size = new System.Drawing.Size(503, 20);
			this.txtAlamat.TabIndex = 132;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(121, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 16);
			this.label6.TabIndex = 131;
			this.label6.Text = "NO HP  : ";
			// 
			// txtNoHp
			// 
			this.txtNoHp.Location = new System.Drawing.Point(197, 114);
			this.txtNoHp.Name = "txtNoHp";
			this.txtNoHp.Size = new System.Drawing.Size(503, 20);
			this.txtNoHp.TabIndex = 130;
			// 
			// btnBersihkan
			// 
			this.btnBersihkan.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnBersihkan.Location = new System.Drawing.Point(559, 189);
			this.btnBersihkan.Name = "btnBersihkan";
			this.btnBersihkan.Size = new System.Drawing.Size(75, 29);
			this.btnBersihkan.TabIndex = 128;
			this.btnBersihkan.Text = "Bersihkan";
			this.btnBersihkan.UseVisualStyleBackColor = false;
			this.btnBersihkan.Click += new System.EventHandler(this.BtnBersihkanClick);
			// 
			// btnHapus
			// 
			this.btnHapus.BackColor = System.Drawing.Color.LightCoral;
			this.btnHapus.Enabled = false;
			this.btnHapus.Location = new System.Drawing.Point(416, 189);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(75, 29);
			this.btnHapus.TabIndex = 127;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = false;
			this.btnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Gold;
			this.btnEdit.Enabled = false;
			this.btnEdit.Location = new System.Drawing.Point(273, 189);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 29);
			this.btnEdit.TabIndex = 126;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnSimpan
			// 
			this.btnSimpan.BackColor = System.Drawing.Color.SpringGreen;
			this.btnSimpan.Location = new System.Drawing.Point(130, 189);
			this.btnSimpan.Name = "btnSimpan";
			this.btnSimpan.Size = new System.Drawing.Size(75, 29);
			this.btnSimpan.TabIndex = 125;
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
			this.label3.TabIndex = 122;
			this.label3.Text = "DB : Toko Pak Budi, Table : Kasir";
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
			this.dataGridView1.TabIndex = 121;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(124, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 120;
			this.label2.Text = "NAMA  : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(109, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 119;
			this.label1.Text = "ID KASIR : ";
			// 
			// txtNama
			// 
			this.txtNama.Location = new System.Drawing.Point(197, 77);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(503, 20);
			this.txtNama.TabIndex = 118;
			// 
			// txtIdKasir
			// 
			this.txtIdKasir.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdKasir.Location = new System.Drawing.Point(197, 43);
			this.txtIdKasir.Name = "txtIdKasir";
			this.txtIdKasir.Size = new System.Drawing.Size(503, 20);
			this.txtIdKasir.TabIndex = 117;
			// 
			// Kasir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(822, 516);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtAlamat);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNoHp);
			this.Controls.Add(this.btnBersihkan);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSimpan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.txtIdKasir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Kasir";
			this.Text = "Kasir";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtIdKasir;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSimpan;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnBersihkan;
		private System.Windows.Forms.TextBox txtNoHp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAlamat;
		private System.Windows.Forms.Label label5;
	}
}
