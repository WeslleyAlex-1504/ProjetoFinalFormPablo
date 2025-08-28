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
    public partial class AtualizarFuncionario : Form
    {

        private Funcionarios _formFuncionarios;

        public AtualizarFuncionario(Funcionarios formFuncionarios)
        {
            InitializeComponent();
            _formFuncionarios = formFuncionarios;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    var campos = new Dictionary<string, object>();

                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                        campos.Add("Nome", textBox1.Text.Trim());

                    if (!string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        bool ativo = !comboBox2.Text.Trim().Equals("Demitido", StringComparison.OrdinalIgnoreCase);
                        campos.Add("Ativo", ativo);
                    }

                    if (campos.Count == 0)
                    {
                        MessageBox.Show("Nenhum campo preenchido para atualizar.");
                        return;
                    }
                 
                    string identificador = textBox6.Text.Trim();

                    string sql = "UPDATE Funcionario SET " +
                                 string.Join(", ", campos.Keys.Select(c => $"{c} = @{c}")) +
                                 " WHERE Id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        foreach (var par in campos)
                            cmd.Parameters.AddWithValue("@" + par.Key, par.Value);

                        cmd.Parameters.AddWithValue("@Id", identificador);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Funcionário atualizado com sucesso!");

                            _formFuncionarios.Funcionarios_Load(null, null);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado. Nenhum registro atualizado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar funcionário: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
