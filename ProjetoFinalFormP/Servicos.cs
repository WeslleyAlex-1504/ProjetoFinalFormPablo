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
    public partial class Servicos : Form
    {
        public Servicos()
        {
            InitializeComponent();
            this.Load += Servico_Load;
        }

        public void Servico_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"SELECT s.Id AS ServicoId, s.SerRealizado AS Serviço, s.Peca, os.Descricao AS OS, f.Nome AS Funcionario,s.Ativo FROM Servico s INNER JOIN OS os ON s.OsId = os.Id
                                INNER JOIN Funcionario f ON s.FuncionarioId = f.Id WHERE s.Ativo = 1";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar serviços: " + ex.Message);
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Funcionarios funcionario = new Funcionarios();
            funcionario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Os os = new Os();
            os.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            atualizarServico att = new atualizarServico(this);
            att.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql;

                    if (button4.Text == "Ver Finalizados")
                    {
                        sql = @"SELECT s.Id AS ServicoId, s.SerRealizado, s.Peca,s.Ativo, os.Descricao AS OS, f.Nome AS Funcionario FROM Servico s INNER JOIN OS os ON s.OsId = os.Id
                                INNER JOIN Funcionario f ON s.FuncionarioId = f.Id WHERE s.Ativo = 1";
                        button4.Text = "Ver Incompletos";
                    }
                    else
                    {
                        sql = @"SELECT s.Id AS ServicoId, s.SerRealizado, s.Peca,s.Ativo, os.Descricao AS OS, f.Nome AS Funcionario FROM Servico s INNER JOIN OS os ON s.OsId = os.Id
                                INNER JOIN Funcionario f ON s.FuncionarioId = f.Id WHERE s.Ativo = 0";
                        button4.Text = "Ver Finalizados";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
    }
}
