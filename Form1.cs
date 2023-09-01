using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Canciones
{
    public partial class Temas : Form
    {
        public Temas()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Temas_Load(object sender, EventArgs e)
        {
            wmp.uiMode = "none"; 
            StreamReader sr = new StreamReader("temas.txt");

            string linea;
            while(sr.EndOfStream == false) 
            {
                linea = sr.ReadLine();
                string[] datos = linea.Split(',');
                cbTema.Items.Add(datos[1]);
            }
            cbTema.SelectedIndex = 0;
            sr.Close();
            sr.Dispose();
        }

        private void cbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            string video = "video" + (cbTema.SelectedIndex + 1).ToString() + ".mp4";
            wmp.URL = video;
        }
    }
}
