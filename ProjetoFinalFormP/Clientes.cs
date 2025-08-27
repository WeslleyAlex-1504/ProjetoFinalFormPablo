using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema.Database;

namespace ProjetoFinalFormP
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            this.Load += Clientes_Load;
        }

        public void Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {

                    string sql = "SELECT Id, Nome, CPF, Telefone, Cidade, Estado, Pais, Ativo FROM Cliente Where Ativo = true";


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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CriarCliente add = new CriarCliente(this);
            add.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CriarCarro add = new CriarCarro();
            add.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AtualizarCliente att = new AtualizarCliente(this);
            att.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {


                    if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, selecione um campo para buscar.");
                        return;
                    }

                    string coluna = comboBox1.SelectedItem.ToString();

                    string valor = textBox1.Text.Trim();


                    string sql = $"SELECT * FROM Cliente WHERE {coluna} LIKE @valor";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@valor", valor + "%");

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql;

                    if (button4.Text == "Ver Ativos")
                    {
                        sql = "SELECT Id, Nome, CPF, Telefone, Cidade, Estado, Pais, Ativo FROM Cliente WHERE Ativo = true";
                        button4.Text = "Ver Inativos";
                    }
                    else
                    {
                        sql = "SELECT Id, Nome, CPF, Telefone, Cidade, Estado, Pais, Ativo FROM Cliente WHERE Ativo = false";
                        button4.Text = "Ver Ativos";
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
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }
    }
}
