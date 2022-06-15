using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data;

namespace UTS_PV
{

	public partial class Pembelian : Form
	{
		MySqlConnection co = new MySqlConnection(@"server=localhost; userid=root; password=; database=toko_pak_budi; Convert Zero Datetime=True");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public Pembelian()
		{
			InitializeComponent();
			isiCmbKasir();
	 		ReadData(); 

		}
		public void ReadData(){ 
			 try{ 
			 mycommand.Connection = co; 
			 co.Open();
			 myadapter.SelectCommand = mycommand; 
			 mycommand.CommandText = "select id_pembelian, pembelian.id_kasir, kasir.nama_kasir as nama_kasir, tanggal_pembelian from pembelian inner join kasir on pembelian.id_kasir = kasir.id_kasir"; 
			 DataSet ds = new DataSet(); 
			 myadapter.Fill(ds,"pembelian");
			 dataGridView1.DataSource = ds;
			 dataGridView1.DataMember = "pembelian";	
			 dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			co.Close();
			}
			 catch (Exception ex){ 
			 	MessageBox.Show(ex.ToString()); 
			 } 
		}
		public void InsertData(){ 
		 try{ 
			 mycommand.Connection=co; 
			 co.Open();
			 mycommand.CommandText="insert into pembelian values('"+txtIdPembelian.Text+"','"+cmbKasir.SelectedValue.ToString()+"','"+tglPembelian.Text+"')"; 
			 myadapter.SelectCommand= mycommand; 
			 if (mycommand.ExecuteNonQuery()==1){ 
				 MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
				 co.Close();
				 ReadData(); 
			 } 
		 } 
		 catch(Exception ex){ 
		 		MessageBox.Show(ex.ToString()); 
		 }
			
		}
		
		public void UpdateData(){ 
			 try{ 
				co.Open();
				 mycommand.CommandText = "update pembelian set id_pembelian ='"+txtIdPembelian.Text+"',id_kasir ='"+ cmbKasir.SelectedValue.ToString() +"',tanggal_pembelian ='"+tglPembelian.Text+"' where id_pembelian ='"+txtIdPembelian.Text+"'"; 
				 myadapter.SelectCommand = mycommand; 
				 if (mycommand.ExecuteNonQuery()==1){ 
					 MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
					 co.Close();
					 ReadData(); 
				}
			} 
			catch(Exception ex){
			 	MessageBox.Show(ex.ToString()); 
			}  
		}
		public void DeleteData(){ 
			 try{ 
				co.Open();
			 mycommand.CommandText="delete from pembelian where id_pembelian ='"+txtIdPembelian.Text+"'"; 
			 myadapter.SelectCommand = mycommand; 
				 if (mycommand.ExecuteNonQuery()==1){ 
					 MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
					 co.Close();
					 ReadData(); 
				 } 
			 } 
			 catch(Exception ex) { 
			 	MessageBox.Show(ex.ToString()); 
			 } 
		}
		public void isiCmbKasir(){
			try {
				mycommand.Connection = co;
				co.Open();
				mycommand.CommandText = "select id_kasir, nama_kasir from kasir";
				myadapter.SelectCommand = mycommand;
				DataTable table1 = new DataTable();
				myadapter.Fill(table1);
				cmbKasir.DataSource = table1;
				cmbKasir.DisplayMember = "nama_kasir";
				cmbKasir.ValueMember = "id_kasir";
				co.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e) 
		{ 			
				btnSimpan.Enabled = false;
				btnEdit.Enabled = true;
				btnHapus.Enabled = true;		
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				txtIdPembelian.Text = row.Cells["id_pembelian"].Value.ToString();
				cmbKasir.Text = row.Cells["nama_kasir"].Value.ToString();
				tglPembelian.Text = row.Cells["tanggal_pembelian"].Value.ToString();

		}

		

		
		void BtnSimpanClick(object sender, EventArgs e)
		{
			InsertData();
			
		}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			UpdateData();
		}
		
		void BtnHapusClick(object sender, EventArgs e)
		{
			DeleteData();
		}
		
		void BtnBersihkanClick(object sender, EventArgs e)
		{
			txtIdPembelian.Text = "";
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;	
		}
		

	}
}
