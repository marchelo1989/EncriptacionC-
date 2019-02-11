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
            string dato = "Hola Mundo";
            txtMd5.Text = dato;
            txtSha1.Text = dato;
            txtEncripBase64.Text = dato;
            txtEncripAES.Text = dato;
            txtEncripCode.Text = dato;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5();
            string texto = txtMd5.Text;
            md5.EncripatarMD5(texto);
            lblMensaje.Items.Add(md5.EncripatarMD5(texto));
            //lMensaje.Items.Clear();
            //txtSha1.Text= md5.EncripatarMD5(texto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SHA1_1 sha1 = new SHA1_1();
            string texto = txtSha1.Text;
            sha1.GetSHA1(texto);
            lblMensaje.Items.Add(sha1.GetSHA1(texto));
            //lblMensaje.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //BASE64 base64 = new BASE64();
            string texto = txtEncripBase64.Text;
            //base64.Encriptar(texto);
            //lblMensaje.Items.Add(base64.Encriptar(texto));
            //txtDesenBase64.Text = base64.Encriptar(texto);
            ////lblMensaje.Items.Clear();

            lblMensaje.Items.Add(BASE64.Base64Encode(texto));
            txtDesenBase64.Text = BASE64.Base64Encode(texto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BASE64 base64 = new BASE64();
            string texto = txtDesenBase64.Text;
            //base64.DesEncriptar(texto);
            //lblMensaje.Items.Add(base64.DesEncriptar(texto));
            ////lblMensaje.Items.Clear();

            lblMensaje.Items.Add(BASE64.Base64Decode(texto));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AESEN aes = new AESEN();
            string texto = txtEncripAES.Text;
            aes.Encrit(texto);
            lblMensaje.Items.Add(aes.Encrit(texto));
            //lblMensaje.Items.Clear();
            txtDesmAES.Text = aes.Encrit(texto);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AESEN aes = new AESEN();
            string texto = txtDesmAES.Text;
            aes.Desencrit(texto);
            lblMensaje.Items.Add(aes.Desencrit(texto));
            //lblMensaje.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CommonsCodec19 comm = new CommonsCodec19();
            string texto = txtEncripCode.Text;
            comm.Encriptar(texto);
            lblMensaje.Items.Add(comm.Encriptar(texto));
            //lblMensaje.Items.Clear();
            txtDenseCode.Text = comm.Encriptar(texto);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CommonsCodec19 comm = new CommonsCodec19();
            string texto = txtDenseCode.Text;
            comm.Desencriptar(texto);
            lblMensaje.Items.Add(comm.Desencriptar(texto));
            //lblMensaje.Items.Clear();
        }
    }
}
