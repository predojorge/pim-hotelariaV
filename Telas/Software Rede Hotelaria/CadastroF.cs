using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_Rede_Hotelaria
{
    public partial class CadastroF : Form
    {
        public CadastroF()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroF_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D83UVNJ\\SQLEXPRESS;Initial Catalog=FUNCIONARIOS;Integrated Security=True");

            string sql = "INSERT INTO DADOS_FUNCIONARIOS(NOME, CPF, RG, SEXO, ESTADO_CIVIL, EMAIL, TELEFONE, ESTADO, CIDADE, RUA, NUMERO, SALARIO, CARGO) VALUES (@NOME, @CPF, @RG, @SEXO, @ESTADO_CIVIL, @EMAIL, @TELEFONE, @ESTADO, @CIDADE, @RUA, @NUMERO, @SALARIO, @CARGO)";

            //Random numeroID = new Random();
            //numeroID.Next();

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);

               
                c.Parameters.Add(new SqlParameter("@NOME", this.TxtNome.Text));
                c.Parameters.Add(new SqlParameter("@CPF", this.TxtCpf.Text));
                c.Parameters.Add(new SqlParameter("@RG", this.TxtRg.Text));
                c.Parameters.Add(new SqlParameter("@SEXO", this.TxtSexo.Text));
                c.Parameters.Add(new SqlParameter("@ESTADO_CIVIL", this.TxtEstC.Text));
                c.Parameters.Add(new SqlParameter("@EMAIL", this.TxtEmail.Text));
                c.Parameters.Add(new SqlParameter("@TELEFONE", this.TxtTelefone.Text));
                c.Parameters.Add(new SqlParameter("@ESTADO", this.TxtEstado.Text));
                c.Parameters.Add(new SqlParameter("@CIDADE", this.TxtCidade.Text));
                c.Parameters.Add(new SqlParameter("@RUA", this.TxtRua.Text));
                c.Parameters.Add(new SqlParameter("@NUMERO", this.TxtNum.Text));
                c.Parameters.Add(new SqlParameter("@SALARIO", this.TxtSal.Text));
                c.Parameters.Add(new SqlParameter("@CARGO", this.TxtCargo.Text));

                conn.Open();

                c.ExecuteNonQuery();

                conn.Close();

            MessageBox.Show("Cadastrado com sucesso!");
            this.Close();
            OpADM admt = new OpADM();
            admt.Show();

            }catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu o Erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpADM admt = new OpADM();
            admt.Show();
            this.Close();
        }
    }
}
