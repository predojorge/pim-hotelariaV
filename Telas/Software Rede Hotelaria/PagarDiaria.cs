using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Rede_Hotelaria
{
    public partial class PagarDiaria : Form
    {
        public PagarDiaria()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fatura quitada com sucesso!");
            this.Close();
            Home voltar = new Home();
            voltar.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home voltar = new Home();
            voltar.Show();
            this.Close();
        }
    }
}
