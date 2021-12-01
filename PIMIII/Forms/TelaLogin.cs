using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using PIMIII.classes;

namespace PIMIII
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapure();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int iParam);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.controleLogin(mtxtUsuario.Text, mtxtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.vrLogin)
                {
                    Form1 fh = new Form1();
                    this.Hide();
                    fh.Show();
                    
                }
                else
                {
                    MessageBox.Show("Login nao encontrado");
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
