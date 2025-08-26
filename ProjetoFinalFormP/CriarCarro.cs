using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema.Database;

namespace ProjetoFinalFormP
{
    public partial class CriarCarro : Form
    {
        public CriarCarro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CriarCarro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string placa = textBox1.Text.Trim().ToUpper();

                    if (!Regex.IsMatch(textBox1.Text.Trim().ToUpper(), @"^([A-Z]{3}-\d{4}|[A-Z]{3}\d[A-Z]\d{2})$"))
                    {
                        MessageBox.Show("Placa inválida! Formatos válidos: ABC-1234 ou ABC1D23.");
                        return;
                    }

                    int clienteId;
                    string sqlCliente = "SELECT Id FROM Cliente WHERE Cpf = @cpf";

                    using (var cmdCliente = new MySqlCommand(sqlCliente, conexao))
                    {
                        cmdCliente.Parameters.AddWithValue("@cpf", textBox5.Text.Trim());
                        var result = cmdCliente.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Cliente não encontrado com este CPF.");
                            return;
                        }

                        clienteId = Convert.ToInt32(result);
                    }

                    string sqlCarro = @"INSERT INTO Carro (Placa, Marca, Modelo, Ano, ClienteId)
                                VALUES (@Placa, @Marca, @Modelo, @Ano, @ClienteId)";

                    using (var cmdCarro = new MySqlCommand(sqlCarro, conexao))
                    {
                        cmdCarro.Parameters.AddWithValue("@Placa", textBox1.Text.Trim());
                        cmdCarro.Parameters.AddWithValue("@Marca", textBox3.Text.Trim());
                        cmdCarro.Parameters.AddWithValue("@Modelo", textBox2.Text.Trim());
                        cmdCarro.Parameters.AddWithValue("@Ano", Convert.ToInt32(textBox4.Text.Trim()));
                        cmdCarro.Parameters.AddWithValue("@ClienteId", clienteId);

                        int linhasAfetadas = cmdCarro.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Carro inserido com sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir carro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
    }
}
