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
            this.Load += Clientes_Load; // Garante que o evento Load está correto
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    // Seleciona todos os campos do cliente
                    string sql = "SELECT Id, Nome, CPF, Telefone, Cidade, Estado, Pais FROM Cliente";

                    // Usando DataAdapter e DataTable para popular o DataGridView
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Opcional: ajustar colunas
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.ReadOnly = true; // Somente leitura
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
    }
}
