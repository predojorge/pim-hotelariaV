using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Rede_Hotelaria
{
    public partial class ReservarQ : Form
    {
        public ReservarQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservado com sucesso!");
            this.Close();
            Home voltar = new Home();
            voltar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home voltar = new Home();
            voltar.Show();
            this.Close();

        }
    }
}
