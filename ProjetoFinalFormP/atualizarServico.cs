using MySql.Data.MySqlClient;
using ProjetoFinalFormP.Model;
using Sistema.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalFormP
{
    public partial class atualizarServico : Form
    {

        private Servicos _formServico;

        public atualizarServico(Servicos formServico)
        {
            InitializeComponent();
            _formServico = formServico;
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
                    {
                        if (textBox1.Text.Trim().Length < 4)
                        {
                            MessageBox.Show("O campo 'Serviço Realizado' deve ter pelo menos 4 caracteres.");
                            return;
                        }
                        campos.Add("SerRealizado", textBox1.Text.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        if (textBox2.Text.Trim().Length < 4)
                        {
                            MessageBox.Show("O campo 'Peça' deve ter pelo menos 4 caracteres.");
                            return;
                        }
                        campos.Add("Peca", textBox2.Text.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        bool ativo = comboBox2.Text.Trim().Equals("Incompleto", StringComparison.OrdinalIgnoreCase);
                        campos.Add("Ativo", ativo ? 1 : 0);
                    }

                    if (campos.Count == 0)
                    {
                        MessageBox.Show("Nenhum campo preenchido para atualizar.");
                        return;
                    }

                    string sql = "UPDATE Servico SET " +
                                 string.Join(", ", campos.Keys.Select(c => $"{c} = @{c}")) +
                                 " WHERE Id = @Id";

                    if (!campos.ContainsKey("Ativo"))
                        sql += " AND Ativo = 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        foreach (var par in campos)
                            cmd.Parameters.AddWithValue("@" + par.Key, par.Value);

                        cmd.Parameters.AddWithValue("@Id", int.Parse(textBox6.Text.Trim()));

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!");
                            _formServico.Servico_Load(null, null);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro atualizado (ID não encontrado ou já foi finalizado).");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
