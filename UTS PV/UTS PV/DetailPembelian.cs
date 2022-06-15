using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data;

namespace UTS_PV
{
	public partial class DetailPembelian : Form
	{
		MySqlConnection co = new MySqlConnection(@"server=localhost; userid=root; password=; database=toko_pak_budi; Convert Zero Datetime=True");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		string barang;
		
		public DetailPembelian()
		{
			InitializeComponent();
			isicmbbarang();
		}
		void isicmbbarang(){
			try {
				mycommand.Connection = co;
				co.Open();
				mycommand.CommandText = "select id_barang, nama_barang from barang";
				myadapter.SelectCommand = mycommand;
				DataTable table1 = new DataTable();
				myadapter.Fill(table1);
				cmbBarang.DataSource = table1;
				cmbBarang.DisplayMember = "nama_barang";
				cmbBarang.ValueMember = "id_barang";
				co.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}			
		}
		public void ReadData(){ 
			 try{ 
				 mycommand.Connection = co; 
				 co.Open();
				 mycommand.CommandText = "select detail_pembelian.id_pembelian, barang.nama_barang, barang.harga, detail_pembelian.kuantitas, (detail_pembelian.kuantitas*barang.harga) as total from detail_pembelian inner join barang on detail_pembelian.id_barang = barang.id_barang where id_pembelian = '"+txtIdPembelian.Text+"'"; 
				 myadapter.SelectCommand = mycommand; 
				 DataSet ds = new DataSet(); 
				 myadapter.Fill(ds,"detail_pembelian");
				 dataGridView1.DataSource = ds;
				 dataGridView1.DataMember = "detail_pembelian";
				 dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				 co.Close();
				 
			}
			
			 catch (Exception ex){ 
			 	MessageBox.Show(ex.ToString()); 
			} 
		}
		
		public void setHargaTotal(){
			try{
				mycommand.Connection = co; 
				co.Open();	
				mycommand.CommandText = "select sum(detail_pembelian.kuantitas*barang.harga) as total from detail_pembelian inner join barang on detail_pembelian.id_barang = barang.id_barang where id_pembelian = '"+txtIdPembelian.Text+"'"; 
				MySqlDataReader reader = mycommand.ExecuteReader();
				if(reader.Read()){
					txtTotalHarga.Text = reader.GetString("total");
				}
				co.Close();
			} catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}

		public void InsertData(){
		 try{ 
			 mycommand.Connection=co; 
			 co.Open();
			 mycommand.CommandText="insert into detail_pembelian values('"+txtIdPembelian.Text+"','"+cmbBarang.SelectedValue.ToString()+"','"+kuantitas.Value.ToString()+"')";
			 myadapter.SelectCommand= mycommand; 
			 if (mycommand.ExecuteNonQuery()==1){ 
				 MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
				 co.Close();
				 ReadData();
				 setHargaTotal();
				 bersihkanForm();
			 } 
		 } 
		 catch(Exception ex){ 
		 		MessageBox.Show(ex.ToString()); 
		 }
			
		}
		
		public void UpdateData(){ 
			 try{ 
			 	mycommand.Connection=co;
				co.Open();
				mycommand.CommandText = "update kasir set id_pembelian ='"+txtIdPembelian.Text+"', id_barang ='"+ cmbBarang.SelectedValue.ToString() +"',kuantitas ='"+kuantitas.Value.ToString()+"' where id_pembelian ='"+txtIdPembelian.Text+"' and id_barang = '"+barang+"'";
				 myadapter.SelectCommand = mycommand; 
				 if (mycommand.ExecuteNonQuery()==1){ 
					 MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
					 co.Close();
					 ReadData();
					 setHargaTotal();
					 bersihkanForm();
				}
			} 
			catch(Exception ex){
			 	MessageBox.Show(ex.ToString()); 
			}  
		}
		
		public void DeleteData(){ 
			 try{ 
			 	mycommand.Connection=co;
				co.Open();
				mycommand.CommandText="delete from detail_pembelian where id_pembelian ='"+txtIdPembelian.Text+"' and id_barang = '"+cmbBarang.SelectedValue.ToString()+"'";
			 	myadapter.SelectCommand = mycommand; 
				 if (mycommand.ExecuteNonQuery()==1){ 
					 MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
					 co.Close();
					 ReadData();
					 setHargaTotal();
					 bersihkanForm();
					 
				 } 
			 } 
			 catch(Exception ex) { 
			 	MessageBox.Show(ex.ToString()); 
			 } 
		}

		public void bersihkanForm(){
			txtIdPembelian.Text = "";
			txtIdPembelian.Enabled = true;
			btnSimpan.Enabled = true;
			btnEdit.Enabled = false;
			btnHapus.Enabled = false;
		}
		void BtnSimpanClick(object sender, EventArgs e)
		{
			InsertData();
			bersihkanForm();
		}
		
		void BtnEditClick(object sender, EventArgs e)
		{
			UpdateData();
			bersihkanForm();
			
		}
		
		void BtnHapusClick(object sender, EventArgs e)
		{
			DeleteData();
			bersihkanForm();
		}
		
		void BtnBersihkanClick(object sender, EventArgs e)
		{
			bersihkanForm();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSimpan.Enabled = false;
			btnEdit.Enabled = true;
			btnHapus.Enabled = true;		
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			txtIdPembelian.Text = row.Cells["id_pembelian"].Value.ToString();
			cmbBarang.Text = row.Cells["nama_barang"].Value.ToString();
			kuantitas.Text = row.Cells["kuantitas"].Value.ToString();
			
		}
		
		void BtnCariClick(object sender, EventArgs e)
		{
			 	mycommand.Connection=co;
				co.Open();
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select id_pembelian from pembelian where id_pembelian = '"+txtIdPembelian.Text+"'";
				MySqlDataReader reader = mycommand.ExecuteReader();
				
				if(reader.Read())
				{
					MessageBox.Show("Data berhasil ditemukan");
					co.Close();
					ReadData();
					setHargaTotal();
					txtIdPembelian.Enabled = false;
				} else{
					MessageBox.Show("Data tidak ditemukan");
				}
		}
		
		void DetailPembelianLoad(object sender, EventArgs e)
		{
			isicmbbarang();
		}
	}
}
