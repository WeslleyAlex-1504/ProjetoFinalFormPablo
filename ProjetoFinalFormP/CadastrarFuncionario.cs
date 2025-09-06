using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema.Database;

namespace ProjetoFinalFormP
{
    public partial class CadastrarFuncionario : Form
    {

        private Funcionarios _formFuncionarios;

        public CadastrarFuncionario(Funcionarios formFuncionarios)
        {
            InitializeComponent();
            _formFuncionarios = formFuncionarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string nome = textBox1.Text.Trim();

                if (nome.Length < 2)
                {
                    MessageBox.Show("O nome do funcionário deve ter pelo menos 3 caracteres.");
                    return;
                }

                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"INSERT INTO Funcionario (Nome) VALUES (@Nome)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", textBox1.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funcionário cadastrado com sucesso!");

                _formFuncionarios.Funcionarios_Load(null, null);

                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Esse funcionário já existe.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
