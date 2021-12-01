using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Rede_Hotelaria
{
    public partial class OpADM : Form
    {
        public OpADM()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OpADM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CQ cadq = new CQ();
            cadq.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Home voltar = new Home();
            voltar.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroF Cadf = new CadastroF();
            Cadf.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadH cadh = new CadH();
            cadh.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }
    }
}
