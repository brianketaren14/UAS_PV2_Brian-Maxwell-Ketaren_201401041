/*
 * Created by SharpDevelop.
 * User: User
 * Date: 07/06/2022
 * Time: 22:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UTS_PV
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.pembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detailBarangYangDibeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logo = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panelSide = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnPembelian = new System.Windows.Forms.Button();
			this.btnBarang = new System.Windows.Forms.Button();
			this.btnKasir = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.panelSide.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(403, 329);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = ":)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(161, 287);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(466, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "SELAMAT DATANG DI APLIKASI PAK BUDI";
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.White;
			this.mainPanel.CausesValidation = false;
			this.mainPanel.Controls.Add(this.menuStrip1);
			this.mainPanel.Controls.Add(this.label2);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.logo);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(200, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(835, 526);
			this.mainPanel.TabIndex = 8;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Enabled = false;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.pembelianToolStripMenuItem,
									this.detailBarangYangDibeliToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(835, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// pembelianToolStripMenuItem
			// 
			this.pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
			this.pembelianToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.pembelianToolStripMenuItem.Text = "Pembelian";
			this.pembelianToolStripMenuItem.Click += new System.EventHandler(this.PembelianToolStripMenuItemClick);
			// 
			// detailBarangYangDibeliToolStripMenuItem
			// 
			this.detailBarangYangDibeliToolStripMenuItem.Name = "detailBarangYangDibeliToolStripMenuItem";
			this.detailBarangYangDibeliToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
			this.detailBarangYangDibeliToolStripMenuItem.Text = "Detail Barang Yang Dibeli";
			this.detailBarangYangDibeliToolStripMenuItem.Click += new System.EventHandler(this.DetailBarangYangDibeliToolStripMenuItemClick);
			// 
			// logo
			// 
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.Location = new System.Drawing.Point(350, 126);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(126, 140);
			this.logo.TabIndex = 3;
			this.logo.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(126, 446);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "201401041";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(23, 426);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "BRIAN MAXWELL KETAREN";
			// 
			// panelSide
			// 
			this.panelSide.BackColor = System.Drawing.Color.BlueViolet;
			this.panelSide.Controls.Add(this.label6);
			this.panelSide.Controls.Add(this.label5);
			this.panelSide.Controls.Add(this.label4);
			this.panelSide.Controls.Add(this.label3);
			this.panelSide.Controls.Add(this.pictureBox1);
			this.panelSide.Controls.Add(this.btnPembelian);
			this.panelSide.Controls.Add(this.btnBarang);
			this.panelSide.Controls.Add(this.btnKasir);
			this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSide.Location = new System.Drawing.Point(0, 0);
			this.panelSide.Name = "panelSide";
			this.panelSide.Size = new System.Drawing.Size(200, 526);
			this.panelSide.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("hooge 05_54", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(34, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "PAK BUDI";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("hooge 05_54", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(62, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "TOKO";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(34, 34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(126, 140);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnPembelian
			// 
			this.btnPembelian.BackColor = System.Drawing.Color.BlueViolet;
			this.btnPembelian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPembelian.FlatAppearance.BorderSize = 0;
			this.btnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPembelian.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPembelian.ForeColor = System.Drawing.Color.White;
			this.btnPembelian.Image = ((System.Drawing.Image)(resources.GetObject("btnPembelian.Image")));
			this.btnPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPembelian.Location = new System.Drawing.Point(0, 261);
			this.btnPembelian.Name = "btnPembelian";
			this.btnPembelian.Size = new System.Drawing.Size(200, 40);
			this.btnPembelian.TabIndex = 0;
			this.btnPembelian.Text = "PEMBELIAN";
			this.btnPembelian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPembelian.UseVisualStyleBackColor = false;
			this.btnPembelian.Click += new System.EventHandler(this.BtnPembelianClick);
			// 
			// btnBarang
			// 
			this.btnBarang.BackColor = System.Drawing.Color.BlueViolet;
			this.btnBarang.FlatAppearance.BorderSize = 0;
			this.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBarang.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBarang.ForeColor = System.Drawing.Color.White;
			this.btnBarang.Image = ((System.Drawing.Image)(resources.GetObject("btnBarang.Image")));
			this.btnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBarang.Location = new System.Drawing.Point(0, 341);
			this.btnBarang.Name = "btnBarang";
			this.btnBarang.Size = new System.Drawing.Size(200, 40);
			this.btnBarang.TabIndex = 2;
			this.btnBarang.Text = "BARANG";
			this.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBarang.UseVisualStyleBackColor = false;
			this.btnBarang.Click += new System.EventHandler(this.BtnBarangClick);
			// 
			// btnKasir
			// 
			this.btnKasir.BackColor = System.Drawing.Color.BlueViolet;
			this.btnKasir.FlatAppearance.BorderSize = 0;
			this.btnKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKasir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKasir.ForeColor = System.Drawing.Color.White;
			this.btnKasir.Image = ((System.Drawing.Image)(resources.GetObject("btnKasir.Image")));
			this.btnKasir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKasir.Location = new System.Drawing.Point(0, 301);
			this.btnKasir.Name = "btnKasir";
			this.btnKasir.Size = new System.Drawing.Size(200, 40);
			this.btnKasir.TabIndex = 1;
			this.btnKasir.Text = "KASIR";
			this.btnKasir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnKasir.UseVisualStyleBackColor = false;
			this.btnKasir.Click += new System.EventHandler(this.BtnKasirClick);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1035, 526);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.panelSide);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Toko Pak Budi";
			this.Load += new System.EventHandler(this.DashboardLoad);
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.panelSide.ResumeLayout(false);
			this.panelSide.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem detailBarangYangDibeliToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pembelianToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnKasir;
		private System.Windows.Forms.Button btnBarang;
		private System.Windows.Forms.Button btnPembelian;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panelSide;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox logo;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
