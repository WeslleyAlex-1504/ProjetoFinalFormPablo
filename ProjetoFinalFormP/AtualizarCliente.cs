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

                    var campos = new Dictionary<string, object>();

                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                        campos.Add("Nome", textBox1.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                        campos.Add("Telefone", textBox2.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(textBox4.Text))
                        campos.Add("Cidade", textBox4.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(comboBox1.Text))
                        campos.Add("Estado", comboBox1.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(textBox5.Text))
                        campos.Add("Pais", textBox5.Text.Trim());
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
    }
}
