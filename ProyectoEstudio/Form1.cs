using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCalificacion2.Items.Add("0");
            txtCalificacion2.Items.Add("1");
            txtCalificacion2.Items.Add("2");
            txtCalificacion2.Items.Add("3");
            txtCalificacion2.Items.Add("4");
            txtCalificacion2.Items.Add("5");

        }

        private void btnCapturarDatos2_Click(object sender, EventArgs e)
        {

                dgvDatos2.Rows.Add(txtNombre2.Text, txtSueldo2.Text, txtCalificacion2.Text);
                txtNombre2.Text = "";
                txtSueldo2.Text = "";
                txtCalificacion2.Text = "";
                MessageBox.Show("Datos Guardados");

        }

        private void radEstudiante2_CheckedChanged(object sender, EventArgs e)
        {
            if (radEstudiante2.Checked)
            {

                txtNombre2.ReadOnly = false;
                txtSueldo2.ReadOnly = true;
                txtCalificacion2.Enabled = true;
            }
        }

        private void radProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {

                txtNombre2.ReadOnly = false;
                txtSueldo2.ReadOnly = false;
                txtCalificacion2.Enabled = false;
            }
        }

        private void txtCalificacion2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
