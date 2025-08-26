using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoFinalFormP.Middleware;
using Sistema.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalFormP
{
    public partial class AtualizarCarro : Form
    {

        private Carros _formCarros;

        public AtualizarCarro(Carros formCarros)
        {
            InitializeComponent();
            _formCarros = formCarros;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string placa = textBox1.Text.Trim().ToUpper();

                if (!string.IsNullOrWhiteSpace(placa))
                {

                if (!Regex.IsMatch(textBox1.Text.Trim().ToUpper(), @"^([A-Z]{3}-\d{4}|[A-Z]{3}\d[A-Z]\d{2})$"))
                {
                    MessageBox.Show("Placa inválida! Formatos válidos: ABC-1234 ou ABC1D23.");
                    return;
                }

                }

                using (var conexao = Conexao.ObterConexao())
                {

                    var campos = new Dictionary<string, object>();

                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                        campos.Add("Placa", textBox1.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                        campos.Add("Marca", textBox3.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                        campos.Add("Modelo", textBox2.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(textBox4.Text))
                        campos.Add("ano", textBox4.Text.Trim());

                    if (campos.Count == 0)
                    {
                        MessageBox.Show("Nenhum campo preenchido para atualizar.");
                        return;
                    }

                    string sql = "UPDATE Carro SET " +
                                 string.Join(", ", campos.Keys.Select(c => $"{c} = @{c}")) +
                                 " WHERE Placa = @Placa2";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        foreach (var par in campos)
                            cmd.Parameters.AddWithValue("@" + par.Key, par.Value);

                        cmd.Parameters.AddWithValue("@Placa2", textBox6.Text.Trim());

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Carro atualizado com sucesso!");

                            _formCarros.Carros_Load(null, null);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Carro não encontrado. atualização cancelada.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
            }
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
