using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Rede_Hotelaria
{
    public partial class CQ : Form
    {
        public CQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso!");
            this.Close();
            OpADM admt = new OpADM();
            admt.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            OpADM admt = new OpADM();
            admt.Show();
        }
    }
}
