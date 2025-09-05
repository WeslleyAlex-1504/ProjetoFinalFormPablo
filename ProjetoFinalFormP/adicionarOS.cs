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
using ProjetoFinalFormP.Model;
using Sistema.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoFinalFormP
{
    public partial class adicionarOS : Form
    {
        public adicionarOS()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; 
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Checked = false;
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = textBox1.Text.Trim();

                if (string.IsNullOrWhiteSpace(descricao) || descricao.Length < 3)
                {
                    MessageBox.Show("Descrição deve 4 ou mais caracteres!");
                    return;
                }

                using (var conexao = Conexao.ObterConexao())
                {
                    string sqlCarro = "SELECT Id FROM Carro WHERE Placa = @Placa";

                    int carroId;
                    using (var cmdCarro = new MySqlCommand(sqlCarro, conexao))
                    {
                        cmdCarro.Parameters.AddWithValue("@Placa", textBox2.Text.Trim().ToUpper());
                        var result = cmdCarro.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Carro não encontrado com essa placa.");
                            return;
                        }



                        carroId = Convert.ToInt32(result);
                    }

                    if (!dateTimePicker1.Checked)
                    {
                        MessageBox.Show("Escolha uma data para criar a OS!");
                        return;
                    }


                    string sql = @"INSERT INTO OS (Descricao, Data, CarroId) VALUES (@Descricao, @Data, @CarroId)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Data", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@CarroId", carroId);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("OS criada com sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao criar OS.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void adicionarOS_Load(object sender, EventArgs e)
        {

        }
    }
}
