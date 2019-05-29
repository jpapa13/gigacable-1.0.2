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
    public partial class busqueda : Form
    {
    	private String conn;
        private MySqlConnection connect;
        public String id_user;
        public String id_reporte;
        DateTime now = DateTime.Now;
        public busqueda()
        {
            InitializeComponent();
        }
		public void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=gigacable;Uid=admin;Pwd=;Convert Zero Datetime=True;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
		void loadDataId(){
        	db_connection();
            String sql ="SELECT id,status,descripcion,fecha_ini,fecha_fin FROM reporte WHERE id_tecnico='" +id_user+"'";
        	MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connect);
        	DataTable consulta = new DataTable();
        	dataAdapter.Fill(consulta);
        	dataGridView1.DataSource = consulta;
        	this.dataGridView1.Columns[0].Visible = false;
        }
		void loadDataUser(){
        	db_connection();
            String sql ="SELECT * FROM reporte WHERE id_cliente='" +id_user+"'";
        	MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connect);
        	DataTable consulta = new DataTable();
        	dataAdapter.Fill(consulta);
        	dataGridView1.DataSource = consulta;
        	//this.dataGridView1.Columns[0].Visible = false;
        }
		private bool buscar_reporte()
        {
 			String[] reportes = new String[9];
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM `reporte` WHERE `id` =@id";
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Connection = connect;
            MySqlDataReader reporte = cmd.ExecuteReader();
            if (reporte.Read())
            {
            	//TODO: Guardar id del usuario DONE
            	reportes[0] = reporte[0].ToString(); //id
            	if(reporte[1].ToString() == "Reportado"){
            		comboBox1.SelectedIndex = 0;
            	}
            	else if(reporte[1].ToString() == "En progreso"){
            		comboBox1.SelectedIndex = 1;
            	}
            	else if(reporte[1].ToString() == "Finalizado"){
            		comboBox1.SelectedIndex = 2;
            	}
            //	textBox4.Text = reporte[1].ToString(); //status
            DateTime enteredDate = DateTime.Parse(reporte[2].ToString());
            if(enteredDate.Year < 1758){
            	dateTimePicker1.Value = now.Date;
            }
            else{
            	dateTimePicker1.Value = enteredDate;
            }
            //	textBox7.Text = reporte[2].ToString(); //ini
            DateTime enteredDate2 = DateTime.Parse(reporte[3].ToString());
            if(enteredDate2.Year < 1758){
            	dateTimePicker2.Value = now.Date;
            }
            else{
            	dateTimePicker2.Value = enteredDate2;
            }
            //	textBox9.Text = reporte[3].ToString(); //fin
            	textBox5.Text = reporte[4].ToString(); //desc
            //	textBox6.Text = reporte[5].ToString(); //cliente
            //	textBox2.Text = reporte[6].ToString(); //user
            	textBox3.Text = reporte[7].ToString(); //tecnico
            	int r = Convert.ToInt16(reporte[8]);
            	comboBox2.SelectedIndex = r;
            	
				//tipoTextBox.Text = reporte[8].ToString(); //tipo
                connect.Close();
                MessageBox.Show ("Reporte  encontrado");
                return true;
            }
            else
            {
            	MessageBox.Show ("Reporte no encontrado");
                connect.Close();
                return false;
            }
        }
		
 		private bool modificar_reporte()
        {
 			String[] reportes = new String[9];
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE reporte SET status=@status, `fecha_ini`=@fecha_ini, `fecha_fin`=@fecha_fin, `descripcion`=@descripcion,`id_tecnico`=@id_tecnico, `tipo_reporte`=@tipo_reporte  WHERE `id` =@id";
            //cmd.Parameters.AddWithValue("@id", textBox8.Text);
            //cmd.Parameters.AddWithValue("@status", textBox4.Text);
         //   cmd.Parameters.AddWithValue("@fecha_ini",textBox7.Text);
           // cmd.Parameters.AddWithValue("@fecha_fin",textBox9.Text);
            cmd.Parameters.AddWithValue("@descripcion",textBox5.Text);
            cmd.Parameters.AddWithValue("@id_tecnico",textBox3.Text);
            cmd.Parameters.AddWithValue("@tipo_reporte","distancia");
            
            cmd.Connection = connect;
            MySqlDataReader reporte = cmd.ExecuteReader();
            	MessageBox.Show ("Actualizado");
                connect.Close();
                return false;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
		void Button1Click(object sender, EventArgs e)
		{
			buscar_reporte();
		}
		void Button2Click(object sender, EventArgs e)
		{
			modificar_reporte();
		}
		void Button3Click(object sender, EventArgs e)
		{
			id_user = textBox6.Text;
			loadDataUser();
		}
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell selectedRow =  dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0];
			id_reporte = Convert.ToString(selectedRow.Value);

			textBox1.Text = id_reporte;
		}
    }
}
