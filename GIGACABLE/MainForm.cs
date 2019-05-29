/*
 * Created by SharpDevelop.
 * User: irving
 * Date: 05/04/2019
 * Time: 09:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GIGACABLE
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
 
 		private String conn;
        private MySqlConnection connect;
        String id;
        public MainForm()
		{
            
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
        private bool validate_login(String user, String pass,String table)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select id from "+table+" where usuario=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
            	//TODO: Guardar id del usuario. DONE
            	//TODO:Guardar id y dirigir a técnico o usuario.
            	id = login[0].ToString();
            	//llamada1.setBienvenida();
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

      
        void Button1Click(object sender, EventArgs e)
		{
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
	        usuario llamada1 = new usuario();

            if (radioButton1.Checked == true)
            {
            	if(validate_login(textBox1.Text,textBox2.Text,"usuario")){
            		this.Hide();
            		llamada1.id_usuario = id;
            		llamada1.setBienvenida();
            		llamada1.ShowDialog();
            		cleanSignIn();
            		this.Show();
            	}else{
            		MessageBox.Show ("Usuario o contraseña incorrectos");
            	}
                //llamada1.Show();
                //_ = llamada1.DialogResult == DialogResult.Yes;
            }
            else
            {        
				if(validate_login(textBox1.Text,textBox2.Text,"tecnico")){
            		this.Hide();
            		Tecnico llamada3= new Tecnico(id);
            		llamada3.id_tecnico = id;
            		llamada3.setBienvenida();
            		llamada3.ShowDialog();
            		cleanSignIn();
            		this.Show();
            	}else{
            		MessageBox.Show ("Usuario o contraseña incorrectos");
            	}
                    
                    //llamada3.Show();
                    // _ = llamada3.DialogResult == DialogResult.Yes;

                
            }
            /* if (llamada1.DialogResult == DialogResult.Yes)
             {

             }*/
        }
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}

          private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void cleanSignIn(){
        	textBox1.Text = "";
        	textBox2.Text = "";
        }
    }
}
