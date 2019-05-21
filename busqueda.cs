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
        //private Reporte reporte = new Reporte();
        public busqueda()
        {
            InitializeComponent();
        }
 		public void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=gigacable;Uid=admin;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
 		private bool buscar_reporte()
        {
 			String[] reportes = new String[9];
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM `reporte` WHERE `id` =@id";
            cmd.Parameters.AddWithValue("@id", idTextBox.Text);
            cmd.Connection = connect;
            MySqlDataReader reporte = cmd.ExecuteReader();
            if (reporte.Read())
            {
            	//TODO: Guardar id del usuario
            	reportes[0] = reporte[0].ToString(); //id
            	StatusTextBox.Text = reporte[1].ToString(); //status
            	iniTextBox.Text = reporte[2].ToString(); //ini
            	finTextBox.Text = reporte[3].ToString(); //fin
            	descripcionTextBox.Text = reporte[4].ToString(); //desc
            	clienteTextBox.Text = reporte[5].ToString(); //cliente
            	userTextBox.Text = reporte[6].ToString(); //user
            	tecnicoTextBox.Text = reporte[7].ToString(); //tecnico
            	tipoTextBox.Text = reporte[8].ToString(); //tipo
                connect.Close();
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
            cmd.Parameters.AddWithValue("@id", idTextBox.Text);
            cmd.Parameters.AddWithValue("@status", StatusTextBox.Text);
            cmd.Parameters.AddWithValue("@fecha_ini",iniTextBox.Text);
            cmd.Parameters.AddWithValue("@fecha_fin",finTextBox.Text);
            cmd.Parameters.AddWithValue("@descripcion",descripcionTextBox.Text);
            cmd.Parameters.AddWithValue("@id_tecnico",tecnicoTextBox.Text);
            cmd.Parameters.AddWithValue("@tipo_reporte",tipoTextBox.Text);
            
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
			//Buscar
			buscar_reporte();
		}
		void Button2Click(object sender, EventArgs e)
		{
			modificar_reporte();
		}
    }
}
