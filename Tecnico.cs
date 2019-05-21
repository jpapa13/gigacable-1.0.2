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
    public partial class Tecnico : Form
    {
        public Tecnico()
        {
            InitializeComponent();
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
    }
}
