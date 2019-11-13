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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string contraseña = @"Passwd.txt";
        public string rutaCarpeta = @"C:\Itla_usuarios\";

        private void Next2_Click(object sender, EventArgs e)
        {
            Form1 next = new Form1();
            this.Hide();
            next.ShowDialog();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (CorreoBox.Text != null && PassBox.Text == PassConfirmationBox.Text)
            {
                pictureBox2.Image = ItlaVirtual.Properties.Resources.icons8_tarea_completada_32;
            }
            else
            {
                pictureBox2.Image = null;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CorreoBox.Text != null && PassBox.Text == PassConfirmationBox.Text)
            {
                MessageBox.Show("Campos llenos.");
                string gmailtrim = "@gmail.com";
                string usuario = CorreoBox.Text;
                //string carpeta = usuario.Trim(gmailtrim);
                //string ruta = Path.Combine(rutaCarpeta+""+CorreoBox.Trim(), contraseña);
                try
                {
                    if (!(Directory.Exists(rutaCarpeta)))
                    {
                        Directory.CreateDirectory(rutaCarpeta);
                    }
                    if (!(Directory.Exists(rutaCarpeta)))
                    {
                        Directory.CreateDirectory(rutaCarpeta);
                    }
                    if (!File.Exists(ruta))
                    {
                        using (var stream = File.Create(ruta)) ;
                    }
                    //if (!File.Exists(ruta))
                    //{
                    //    using (var stream = File.Create(ruta));
                    //}
                    StreamWriter fichero = new StreamWriter(ruta);
                    fichero.WriteLine("Admin");
                    fichero.Close();
                }
                catch (Exception E)
                {

                    MessageBox.Show(E.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios, llene todo primero.");
            }

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
