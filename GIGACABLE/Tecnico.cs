using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GIGACABLE
{
    public partial class Tecnico : Form
    {
    	private String conn;
        private MySqlConnection connect;
        private String id_reporte;
        private String fecha_fin;
        private DateTime now;
        private String status;
        public String id_tecnico;
		
        public Tecnico(String id_tecnico)
        {
            InitializeComponent();
           	comboBox1.SelectedIndex = 0;
            this.id_tecnico = id_tecnico;
            loadData();
        }
		public void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=gigacable;Uid=admin;Pwd=;Allow Zero Datetime=True;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
        	this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            detalles llamada4 = new detalles();
            llamada4.ShowDialog();
            if (llamada4.DialogResult == DialogResult.Yes)
            {

            }
        }
        void loadData(){
        	db_connection();
            String sql ="SELECT id,status,descripcion,fecha_ini,fecha_fin FROM reporte WHERE id_tecnico='" +id_tecnico+"'";
        	MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connect);
        	DataTable consulta = new DataTable();
        	dataAdapter.Fill(consulta);
        	dataGridView1.DataSource = consulta;
        	this.dataGridView1.Columns[0].Visible = false;
        }
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		public void setBienvenida(){	
            label1.Text = "Bienvenido tecnico: " + id_tecnico;
		}
		void ActualizarButtonClick(object sender, EventArgs e)
		{
			DataGridViewCell selectedRow =  dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0];
			id_reporte = Convert.ToString(selectedRow.Value);
			now = DateTime.Now;
			fecha_fin = now.Date.ToString("yyyy-MM-dd");
			status = comboBox1.SelectedItem.ToString();
			db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE `reporte` SET `status` = @status, `fecha_fin` = @fecha_fin WHERE `reporte`.`id` =@id_reporte";
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);
            cmd.Parameters.AddWithValue("@id_reporte", id_reporte);            
            cmd.Connection = connect;
            MySqlDataReader edit = cmd.ExecuteReader();
            if (edit.RecordsAffected > 0)
            {
				MessageBox.Show ("¡Reporte actualizado!");
                connect.Close();
                loadData();
            }
            else
            {
            	MessageBox.Show ("Error );");
                connect.Close();
            }
        
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
    }
}
