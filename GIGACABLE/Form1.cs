using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIGACABLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        	Reporte p = new Reporte(turnoTextBox.Text,Int32.Parse(horasTextBox.Text),tipoTextBox.Text,Int32.Parse(cuatriTextBox.Text));
			p.save();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
