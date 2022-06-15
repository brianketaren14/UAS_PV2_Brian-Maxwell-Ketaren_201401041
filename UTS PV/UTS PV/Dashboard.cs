using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data;

namespace UTS_PV
{

	public partial class Dashboard : Form
	{

		MySqlConnection co = new MySqlConnection(@"server=localhost; userid=root; password=; database=toko_pak_budi;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public Dashboard()
		{
			InitializeComponent();
		}
		

		public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(3);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
                this.mainPanel.Tag = f;
                f.Show();
            }

        }
		void DashboardLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnPembelianClick(object sender, EventArgs e)
		{
			
			menuStrip1.Enabled = true;
			menuStrip1.Visible = true;			
			label1.Visible = false;
			label2.Visible = false;
			logo.Visible = false;
			loadform(new Pembelian());
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
            Application.Exit();
		}
		
		void BtnMinimizeClick(object sender, EventArgs e)
		{
            this.WindowState = FormWindowState.Minimized;
			
		}
		
		void BtnKasirClick(object sender, EventArgs e)
		{
			menuStrip1.Enabled = false;
			menuStrip1.Visible = false;			
			label1.Visible = false;
			label2.Visible = false;
			logo.Visible = false;
			loadform(new Kasir());
			
		}
		
		void BtnBarangClick(object sender, EventArgs e)
		{
			menuStrip1.Enabled = false;
			menuStrip1.Visible = false;
			label1.Visible = false;
			label2.Visible = false;
			logo.Visible = false;
			loadform(new Barang());
		}
		
		void PembelianToolStripMenuItemClick(object sender, EventArgs e)
		{
			loadform(new Pembelian());
		}
		
		void DetailBarangYangDibeliToolStripMenuItemClick(object sender, EventArgs e)
		{
			loadform(new DetailPembelian());
		}
		
		void LaporanToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
