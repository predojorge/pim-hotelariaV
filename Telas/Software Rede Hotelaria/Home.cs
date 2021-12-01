using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software_Rede_Hotelaria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagarDiaria Pg = new PagarDiaria();
            Pg.Show();
            this.Close();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           CadastroC Cadastro1 = new CadastroC();
            Cadastro1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReservarQ ReQ = new ReservarQ();
            ReQ.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpADM ADM = new OpADM();
            ADM.Show();
            this.Close();
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 sair = new Form1();
            sair.Show();
            this.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SQ sq1 = new SQ();
            sq1.Show();
            this.Close();
        }
    }
}
