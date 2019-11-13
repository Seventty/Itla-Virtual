using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ItlaVirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string rutaCarpetaAdmin = @"C:\Itla_usuarios\Admin";
        public string contraseña = @"Passwd.txt";
        public string rutaCarpeta = @"C:\Itla_usuarios\";

        private void LogoItla_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 next = new Form2();
            this.Hide();
            next.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(rutaCarpeta, contraseña);
            string rutaAdmin = Path.Combine(rutaCarpetaAdmin, contraseña);
            StreamReader ficheroRead = new StreamReader(rutaAdmin);
            string contraseñaV = ficheroRead.ReadLine();
            if (UsuarioBox.Text == rutaAdmin.Substring(17, 5) && ContraseñaBox.Text == contraseñaV)
            {
                MessageBox.Show("Bienvenido, Administrador.");
                PanelControl acceso = new PanelControl();
                this.Hide();
                acceso.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos erroneos, intente otra vez.");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContraseñaBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
