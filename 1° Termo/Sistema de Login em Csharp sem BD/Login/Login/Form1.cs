using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login
{
    public partial class Form1 : Form
    {
        Thread nf;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Todas as alterações e redefinicoões só serão feitas pelo administradores, entre em contato pelo email marco.silva@sou.unifeb.edu.br");
        }

        private void textuser1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnentrar1_Click(object sender, EventArgs e)
        {
            if (textuser1.Text == "534671" | textBox1.Text == ("123456"))
            {
                MessageBox.Show("Seja bem-vindo");
                this.Close();
                nf = new Thread(novoform);
                nf.SetApartmentState(ApartmentState.STA);
                nf.Start();
            }
            else
            {
                MessageBox.Show("Login ou senha invalido");
            }
        }

        private void novoform()
        {
            Application.Run(new Form2());
        }
    }
}
