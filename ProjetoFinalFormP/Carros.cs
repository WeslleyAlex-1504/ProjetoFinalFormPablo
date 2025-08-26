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
    public partial class Carros : Form
    {
        public Carros()
        {
            InitializeComponent();
            this.Load += Carros_Load;
        }

        public void Carros_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {

                    string sql = @"SELECT c.Id AS CarroId, c.Placa, c.Marca, c.Modelo, c.Ano,cl.Nome AS Cliente, cl.CPF AS CPF FROM Carro c INNER JOIN Cliente cl ON c.ClienteId = cl.Id
";


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
            Form2 voltar = new Form2();
            voltar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 voltar = new Form2();
            voltar.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AtualizarCarro att = new AtualizarCarro(this);
            att.ShowDialog();
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

                    string colunaSql = coluna switch
                    {
                        "Nome" => "cl.Nome",
                        "CPF" => "cl.CPF",
                        "Placa" => "c.Placa",
                        "Modelo" => "c.Modelo",
                        "Ano" => "c.Ano",
                        "Marca" => "c.Marca",
                    };


                    string sql = $@"SELECT c.Id AS CarroId, c.Placa, c.Marca, c.Modelo, c.Ano, cl.Nome AS Cliente, cl.CPF AS CpfCliente FROM Carro c 
                                 INNER JOIN Cliente cl ON c.ClienteId = cl.Id WHERE {colunaSql} LIKE @valor";

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adicionarOS add = new adicionarOS();
            add.ShowDialog();
        }
    }
}
