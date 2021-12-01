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
using PIMIII.classes;

namespace PIMIII
{
    public partial class CadastrarHotel : Form
    {
        public CadastrarHotel()
        {
            InitializeComponent();
        }

        private void bntEnviar_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            ComandoSql cadastrarhotel = new ComandoSql();
            //Chama o método validar hotel da classe Controle para verificar se todos os campos do cadastro estão válidos
            controle.validarHotel(mtxtCpf.Text, mtxtUf.Text, mtxtCidade.Text, mtxtRua.Text, mtxtNumero.Text, mtxtBairro.Text, mtxtTelefone.Text);

            //Verifica se todos os campos estão válidos, se sim irá executar o método para inserir as informações no banco
            if (controle.mensagem.Equals(""))
            {
                //Inicia o método inserirHotel da classe comandosql e caso retorne true significa que inseriu todos os dados dentro do banco
                if (cadastrarhotel.inserirHotel(mtxtCpf.Text, mtxtUf.Text, mtxtCidade.Text, mtxtRua.Text, mtxtNumero.Text, mtxtBairro.Text, mtxtTelefone.Text))
                {
                    MessageBox.Show("Hotel Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show(cadastrarhotel.mensagem);
                }
                
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }

    }
}
