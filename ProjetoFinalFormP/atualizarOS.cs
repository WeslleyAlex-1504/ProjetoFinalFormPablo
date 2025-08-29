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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalFormP
{
    public partial class atualizarOS : Form
    {

        private Os _formOs;

        public atualizarOS(Os formOs)
        {
            InitializeComponent();
            _formOs = formOs;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Checked = false;
            dateTimePicker1.MaxDate = DateTime.Today;

        }

        private void atualizarOS_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    var campos = new Dictionary<string, object>();

                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        if (textBox1.Text.Trim().Length <= 3)
                        {
                            MessageBox.Show("Descrição deve ter pelo menos 3 caracteres!");
                            return;
                        }
                        campos.Add("Descricao", textBox1.Text.Trim());
                    }
                    if (dateTimePicker1.Checked)
                        campos.Add("Data", dateTimePicker1.Value);
                    if (!string.IsNullOrWhiteSpace(comboBox1.Text))
                    {
                        bool ativo = comboBox1.Text.Trim().Equals("Incompleto", StringComparison.OrdinalIgnoreCase);
                        campos.Add("Ativo", ativo);
                    }



                    if (campos.Count == 0)
                    {
                        MessageBox.Show("Nenhum campo preenchido para atualizar.");
                        return;
                    }

                    string sql = "UPDATE OS SET " +
                                 string.Join(", ", campos.Keys.Select(c => $"{c} = @{c}")) +
                                 " WHERE Id = @Id";

                    if (!campos.ContainsKey("Ativo"))
                        sql += " AND Ativo = 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        foreach (var par in campos)
                            cmd.Parameters.AddWithValue("@" + par.Key, par.Value);


                        cmd.Parameters.AddWithValue("@Id", textBox2.Text.Trim());

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!");

                            _formOs.OS_Load(null, null);

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
