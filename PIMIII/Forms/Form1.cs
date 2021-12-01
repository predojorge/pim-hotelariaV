using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace PIMIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int iParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void abrirForm(object nomeForm)
        {
            if (this.painelTela.Controls.Count > 0)
                this.painelTela.Controls.RemoveAt(0);
            Form fh = nomeForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.painelTela.Controls.Add(fh);
            this.painelTela.Tag = fh;
            fh.Show();
        }
        
        private void btnCdQuarto_Click(object sender, EventArgs e)
        {
            abrirForm(new CdQuarto());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirForm(new CadastrarCliente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new CadastrarHotel());
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {

        }
    }


}
