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
using ProjetoFinalFormP.Middleware;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalFormP
{
    public partial class AtualizarCliente : Form
    {

        private Clientes _formClientes;

        public AtualizarCliente(Clientes formClientes)
        {
            InitializeComponent();
            _formClientes = formClientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = textBox3.Text.Trim();

                using (var conexao = Conexao.ObterConexao())
                {
                    int clienteId;
                    using (var cmdCliente = new MySqlCommand("SELECT Id FROM Cliente WHERE Cpf = @Cpf", conexao))
                    {
                        cmdCliente.Parameters.AddWithValue("@Cpf", textBox6.Text.Trim());
                        object result = cmdCliente.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Cliente não encontrado!");
                            return;
                        }
                        clienteId = Convert.ToInt32(result);
                    }

                    string sqlCheck = @" SELECT COUNT(*)  FROM OS o INNER JOIN Carro c ON o.CarroId = c.Id WHERE c.ClienteId = @ClienteId";

                    using (var checkCmd = new MySqlCommand(sqlCheck, conexao))
                    {
                        checkCmd.Parameters.AddWithValue("@ClienteId", clienteId);
                        long qtdOs = (long)checkCmd.ExecuteScalar();
                        if (qtdOs > 0)
                        {
                            MessageBox.Show("Este cliente já possui Ordem de Serviço cadastrada e não pode ser atualizado.");
                            return;
                        }
                    }

                    var campos = new Dictionary<string, object>();

                    if (!string.IsNullOrWhiteSpace(textBox1.Text) && textBox1.Text.Trim().Length <= 3)
                    {
                        MessageBox.Show("Nome deve ter pelo menos 3 caracteres!");
                        return;
                    }
                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                        campos.Add("Telefone", textBox2.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Trim().Length <= 3)
                    {
                        MessageBox.Show("Cidade deve ter pelo menos 3 caracteres!");
                        return;
                    }
                    if (!string.IsNullOrWhiteSpace(comboBox1.Text))
                        campos.Add("Estado", comboBox1.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Trim().Length <= 3)
                    {
                        MessageBox.Show("País deve ter pelo menos 3 caracteres!");
                        return;
                    }
                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                        campos.Add("Cpf", textBox3.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        bool ativo = comboBox2.Text.Trim().ToLower() == "true";
                        campos.Add("Ativo", ativo);
                    }

                    if (campos.Count == 0)
                    {
                        MessageBox.Show("Nenhum campo preenchido para atualizar.");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        if (textBox2.Text.Trim().Length != 11)
                        {
                            MessageBox.Show("Número inválido!! Deve conter o DD Eemplo: 51");
                            return;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(cpf) && !ValidadorCPF.Validar(cpf))
                    {
                        MessageBox.Show("CPF inválido!");
                        return;
                    }

                    string sql = "UPDATE Cliente SET " +
                                 string.Join(", ", campos.Keys.Select(c => $"{c} = @{c}")) +
                                 " WHERE Cpf = @Cpf2";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        foreach (var par in campos)
                            cmd.Parameters.AddWithValue("@" + par.Key, par.Value);

                        cmd.Parameters.AddWithValue("@Cpf2", textBox6.Text.Trim());

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Cliente atualizado com sucesso!");
                            _formClientes.Clientes_Load(null, null);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("CPF não encontrado. Nenhum registro atualizado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
