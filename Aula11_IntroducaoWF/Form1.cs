using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_IntroducaoWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_digitado = txt_nome.Text;

            txt_nome_copiado.Text = nome_digitado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_nome_copiado.Text = "";

            txt_nome.Focus();

            MessageBox.Show("Sou uma mensagem simples.");

            MessageBox.Show("Texto da Mensagem", "Titulo");

            MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.OKCancel);

            MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
        }
    }
}
