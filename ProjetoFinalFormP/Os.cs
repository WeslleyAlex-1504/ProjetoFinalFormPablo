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
                                INNER JOIN Carro c ON os.CarroId = c.Id INNER JOIN Cliente cl ON c.ClienteId = cl.Id";

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
    }
}
