using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombres= txtnombre.Text;
            string apellidos = txtapellido.Text;
            string edad = txtedad.Text;
            string estatura = txtestatura.Text;
            string telefono = txttelefono.Text;
            string genero = "";
            if (rbhombre.Checked)
            {
                genero = "hombre";  
            }
            else if (rbmujer.Checked)
            {
                genero = "mujer";
            }
            string datos = $"Nombres :{nombres}\r\nApellidos: {apellidos }\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nTelefono: {telefono}\r\nGenero: {genero} ";

            string rutaArchivo = "C://Users//sebas//Downloads//datos";

            bool archivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }

            MessageBox.Show("Datos guardados con exito: \n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtestatura.Clear();
            txtedad.Clear();
            rbhombre.Checked = false;
            rbmujer.Checked = false;   
        }
    }
}
