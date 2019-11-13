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
    public partial class portal : Form
    {
        public portal()
        {
            InitializeComponent();
        }
        public string contraseñaAdmin = @"Passwd.txt";
        public string rutaCarpetaAdmin = @"C:\Itla_usuarios\Admin";
        public string contraseña = @"Passwd.txt";
        public string rutaCarpeta = @"C:\Itla_usuarios\";
        private int index = 1;
        private void CargarImagenes()
        {
            if (index == 12)
            {
                index = 1;
            }
            Slider.ImageLocation = string.Format(@"banner\{0}.jpg", index);
            index++;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            CargarImagenes();
        }

        private void BotonContinuar_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(rutaCarpeta, contraseña);
            string rutaAdmin = Path.Combine(rutaCarpetaAdmin, contraseñaAdmin);
            try
            {
                if (!(Directory.Exists(rutaCarpeta)))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }
                if (!(Directory.Exists(rutaCarpetaAdmin)))
                {
                    Directory.CreateDirectory(rutaCarpetaAdmin);
                }
                if (!File.Exists(rutaAdmin))
                {
                    using (var stream = File.Create(rutaAdmin));
                }
                //if (!File.Exists(ruta))
                //{
                //    using (var stream = File.Create(ruta));
                //}
                StreamWriter fichero = new StreamWriter(rutaAdmin);
                fichero.WriteLine("Admin");
                fichero.Close();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
            Form1 next = new Form1();
            this.Hide();
            next.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
    //    public class Persona
    //    {
    //        public string Nombre { get; set; }
    //        public string Apellido { get; set; }
    //        public string Edad { get; set; }
    //    }

    //    public class Profesor : Persona
    //    {
    //        public string Horario { get; set; }
    //        public string Matricula { get; set; }
    //    }
    //    public class Alumno : Persona
    //    {
    //        public string Matricula { get; set; }
    //    }
}
