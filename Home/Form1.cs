using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Encriptacion;
namespace Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMd5.Text = "ABCabc123";
            txtSha1.Text = "ABCabc123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5();
            string texto = txtMd5.Text;
            md5.EncripatarMD5(texto);
            lblMensaje.Items.Add(md5.EncripatarMD5(texto));
            //lMensaje.Items.Clear();
            txtSha1.Text= md5.EncripatarMD5(texto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SHA1_1 sha1 = new SHA1_1();
            string texto = txtSha1.Text;
            sha1.GetSHA1(texto);
            lblMensaje.Items.Add(sha1.GetSHA1(texto));
            //lblMensaje.Items.Clear();
        }
    }
}
