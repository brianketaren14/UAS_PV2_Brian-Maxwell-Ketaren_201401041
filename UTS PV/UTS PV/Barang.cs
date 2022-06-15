using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data;

namespace UTS_PV
{

	public partial class Barang : Form
	{
		MySqlConnection co = new MySqlConnection(@"server=localhost; userid=root; password=; database=toko_pak_budi; Convert Zero Datetime=True");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		public Barang()
		{
			InitializeComponent();
			ReadData();
		}
		public void ReadData(){ 
			 try{ 
				 mycommand.Connection = co; 
				 co.Open();
				 myadapter.SelectCommand = mycommand; 
				 mycommand.CommandText = "select * from barang"; 
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
			 mycommand.CommandText="insert into barang values('"+txtIdBarang.Text+"','"+txtNamaBarang.Text+"','"+txtHarga.Text+"')"; 
			 myadapter.SelectCommand= mycommand; 
			 if (mycommand.ExecuteNonQuery()==1){ 
				 MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
				 co.Close();
				 ReadData();
				 bersihkanForm();
			 } 
		 } 
		 catch(Exception ex){ 
		 		MessageBox.Show(ex.ToString()); 
		 }
			
		}
		
		public void UpdateData(){ 
			 try{ 
				co.Open();
				 mycommand.CommandText = "update barang set id_barang ='"+txtIdBarang.Text+"',nama_barang ='"+ txtNamaBarang.Text +"',harga ='"+txtHarga.Text+"' where id_barang ='"+txtIdBarang.Text+"'"; 
				 myadapter.SelectCommand = mycommand; 
				 if (mycommand.ExecuteNonQuery()==1){ 
					 MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
					 co.Close();
					 ReadData();
					 bersihkanForm();
				}
			} 
			catch(Exception ex){
			 	MessageBox.Show(ex.ToString()); 
			}  
		}
		
		public void DeleteData(){ 
			 try{ 
				co.Open();
			 mycommand.CommandText="delete from barang where id_barang ='"+txtIdBarang.Text+"'"; 
			 myadapter.SelectCommand = mycommand; 
				 if (mycommand.ExecuteNonQuery()==1){ 
					 MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
					 co.Close();
					 ReadData(); 
					 bersihkanForm();
					 
				 } 
			 } 
			 catch(Exception ex) { 
			 	MessageBox.Show(ex.ToString()); 
			 } 
		}
		public void bersihkanForm(){
			txtIdBarang.Text = "";
			txtNamaBarang.Text="";
			txtHarga.Text="";
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;
		}
		void BarangLoad(object sender, EventArgs e)
		{
			
		}
		
		void BtnSimpanClick(object sender, EventArgs e)
		{
			InsertData();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSimpan.Enabled = false;
			btnEdit.Enabled = true;
			btnHapus.Enabled = true;		
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			txtIdBarang.Text = row.Cells["id_barang"].Value.ToString();
			txtNamaBarang.Text = row.Cells["nama_barang"].Value.ToString();
			txtHarga.Text = row.Cells["harga"].Value.ToString();
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
			bersihkanForm();
		}
	}
}
