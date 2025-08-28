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
    public partial class Os : Form
    {
        public Os()
        {
            InitializeComponent();
            this.Load += OS_Load;
        }

        public void OS_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql = @"SELECT os.Id AS OsId, os.Descricao, os.Data, c.Placa AS Carro, cl.Nome AS Cliente, os.Ativo FROM OS os 
                                INNER JOIN Carro c ON os.CarroId = c.Id INNER JOIN Cliente cl ON c.ClienteId = cl.Id WHERE os.Ativo = 1";

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
                MessageBox.Show("Erro ao carregar OS: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            atualizarOS att = new atualizarOS(this);
            att.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    string sql;

                    if (button4.Text == "OS Finalizadas")
                    {
                        sql = @"SELECT os.Id AS OsId, os.Descricao, os.Data, c.Placa AS Carro, cl.Nome AS Cliente, os.Ativo 
                    FROM OS os
                    INNER JOIN Carro c ON os.CarroId = c.Id
                    INNER JOIN Cliente cl ON c.ClienteId = cl.Id
                    WHERE os.Ativo = 0";
                        button4.Text = "OS Incompletas";
                    }
                    else
                    {
                        sql = @"SELECT os.Id AS OsId, os.Descricao, os.Data, c.Placa AS Carro, cl.Nome AS Cliente, os.Ativo 
                    FROM OS os
                    INNER JOIN Carro c ON os.CarroId = c.Id
                    INNER JOIN Cliente cl ON c.ClienteId = cl.Id
                    WHERE os.Ativo = 1";
                        button4.Text = "OS Finalizadas";
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
                MessageBox.Show("Erro ao carregar OS: " + ex.Message);
            }
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
                        "Descrição" => "os.Descricao",
                        "Placa" => "c.Placa",
                        "Cliente" => "cl.Nome",
                    };

                    string sql = $@"SELECT os.Id AS OsId, os.Descricao, os.Data, c.Placa AS Carro, cl.Nome AS Cliente, os.Ativo  FROM OS os INNER JOIN Carro c ON os.CarroId = c.Id
                                 INNER JOIN Cliente cl ON c.ClienteId = cl.Id    WHERE {colunaSql} LIKE @valor";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@valor", valor + "%");

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
                MessageBox.Show("Erro ao buscar OS: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Servicos servico = new Servicos();
            servico.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Carros carro = new Carros();
            carro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adicionarSerivico add = new adicionarSerivico();
            add.ShowDialog();
        }
    }
}
