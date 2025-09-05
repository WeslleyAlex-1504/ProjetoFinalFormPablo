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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
            this.Load += Funcionarios_Load;
        }

        public void Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {

                    string sql = @"SELECT * FROM Funcionario WHERE Ativo = 1";


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
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario add = new CadastrarFuncionario(this);
            add.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"SELECT Id, Nome, Ativo FROM Funcionario WHERE Nome LIKE @valor";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@valor", textBox1.Text.Trim() + "%");

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.ReadOnly = true;
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar funcionário: " + ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AtualizarFuncionario att = new AtualizarFuncionario(this);
            att.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql;

                    if (button4.Text == "Ver Funcionarios")
                    {
                        sql = @"SELECT Id, Nome, Ativo FROM Funcionario WHERE Ativo = true";
                        button4.Text = "Ver Demitidos";
                    }
                    else
                    {
                        sql = @"SELECT Id, Nome, Ativo FROM Funcionario WHERE Ativo = false";
                        button4.Text = "Ver Funcionarios";
                    }

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
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Servicos servico = new Servicos();
            servico.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
