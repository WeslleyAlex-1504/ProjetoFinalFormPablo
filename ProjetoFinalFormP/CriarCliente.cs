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

namespace ProjetoFinalFormP
{
    public partial class CriarCliente : Form
    {

        private Clientes _formClientes;
        public CriarCliente(Clientes formClientes)
        {
            InitializeComponent();
            _formClientes = formClientes;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CriarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string cpf = textBox3.Text.Trim();

                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"INSERT INTO Cliente (Nome, Cpf, Telefone, Cidade, Estado, Pais) 
                           VALUES (@Nome, @Cpf, @Telefone, @Cidade, @Estado, @Pais)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cpf", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefone", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cidade", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@Estado", comboBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Pais", textBox5.Text.Trim());

                        if (!string.IsNullOrWhiteSpace(cpf) && !ValidadorCPF.Validar(cpf))
                        {
                            MessageBox.Show("CPF inválido!");
                            return;
                        }

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Cliente inserido com sucesso!");

                            _formClientes.Clientes_Load(null, null);

                            this.Close();
                          
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi inserido.");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
