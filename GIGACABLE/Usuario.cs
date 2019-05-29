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
    public partial class usuario : Form
    {
    	private String conn;
        private MySqlConnection connect;
        String status;
        String fecha_ini;        	
        DateTime now = DateTime.Now;
        String fecha_fin;
        String descripcion;
        String id_cliente;
        public String id_usuario;
        String id_tecnico;
        int tipo_reporte;
        public usuario()
        {
        	InitializeComponent();
        	fechaLabel.Text = now.Date.ToString("yyyy-MM-dd");
        	comboBox1.SelectedIndex = 0;
        	comboBox2.SelectedIndex = 0;
        	comboBox3.SelectedIndex = 0;
        	comboBox4.SelectedIndex = 0;
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
//Generar
		private void Button1_Click(object sender, EventArgs e)
        {
        	status = comboBox1.SelectedItem.ToString();
        	fecha_ini = now.Date.ToString("yyyy-MM-dd");
        	tipo_reporte = comboBox2.SelectedIndex+1;
        	if(tipo_reporte  == '1'){
        		fecha_fin = fecha_ini;
        	}else{
        		fecha_fin = "";
        	}
        	descripcion = textBox5.Text.ToString();
        	id_tecnico = comboBox3.SelectedItem.ToString();
        	id_cliente = comboBox4.SelectedItem.ToString();
        	if(descripcion == ""){
        		 MessageBox.Show ("Por favor llene los campos");
        	}else{
        		insert();
        	}
        		
        }
        private void insert(){
        	db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO `reporte`(`status`, `fecha_ini`, `fecha_fin`, `descripcion`, `id_cliente`, `id_usuario`, `id_tecnico`, `tipo_reporte`) VALUES (@status, @fecha_ini, @fecha_fin, @descripcion, @id_cliente, @id_usuario, @id_tecnico, @tipo_reporte)";
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@fecha_ini", fecha_ini);
            cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
            cmd.Parameters.AddWithValue("@id_tecnico", id_tecnico);
            cmd.Parameters.AddWithValue("@tipo_reporte", tipo_reporte.ToString());
            cmd.Connection = connect;
            MySqlDataReader inserta = cmd.ExecuteReader();
            MessageBox.Show ("Reporte generado");
            connect.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            busqueda llamada2 = new busqueda();
            llamada2.ShowDialog();
            if (llamada2.DialogResult == DialogResult.Yes)
            {

            }
        }
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		public void setBienvenida(){	
            label7.Text = label7.Text + id_usuario;
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
    }
}
