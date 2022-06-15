using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data;

namespace UTS_PV
{

	public partial class Kasir : Form
	{		
		MySqlConnection co = new MySqlConnection(@"server=localhost; userid=root; password=; database=toko_pak_budi; Convert Zero Datetime=True");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		public Kasir()
		{
			InitializeComponent();
			ReadData();
		}
		public void ReadData(){ 
			 try{ 
				 mycommand.Connection = co; 
				 co.Open();
				 myadapter.SelectCommand = mycommand; 
				 mycommand.CommandText = "select * from kasir"; 
				 DataSet ds = new DataSet(); 
				 myadapter.Fill(ds,"kasir");
				 dataGridView1.DataSource = ds;
				 dataGridView1.DataMember = "kasir";
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
			 mycommand.CommandText="insert into kasir values('"+txtIdKasir.Text+"','"+txtNama.Text+"','"+txtNoHp.Text+"','"+txtAlamat.Text+"')"; 
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
				 mycommand.CommandText = "update kasir set id_kasir ='"+txtIdKasir.Text+"',nama_kasir ='"+ txtNama.Text +"',no_hp ='"+txtNoHp.Text+"', alamat = '"+txtAlamat.Text+"' where id_kasir ='"+txtIdKasir.Text+"'"; 
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
			 mycommand.CommandText="delete from kasir where id_kasir ='"+txtIdKasir.Text+"'"; 
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
			txtIdKasir.Text = "";
			txtNama.Text="";
			txtAlamat.Text="";
			txtNoHp.Text="";
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
			txtIdKasir.Text = row.Cells["id_kasir"].Value.ToString();
			txtNama.Text = row.Cells["nama_kasir"].Value.ToString();
			txtNoHp.Text = row.Cells["no_hp"].Value.ToString();
			txtAlamat.Text = row.Cells["alamat"].Value.ToString();
			
		}
	}
}
