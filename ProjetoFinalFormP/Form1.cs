using MySql.Data.MySqlClient;
using Sistema.Database;

namespace ProjetoFinalFormP
{
    public partial class Form1 : Form
    {

        MySqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string senha = textBox2.Text.Trim();
            try
            {

                using (var conexao = Conexao.ObterConexao())
                {
              

                    string sql = "SELECT Nome, Password FROM user WHERE Nome = @nome AND Password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", usuario);
                        cmd.Parameters.AddWithValue("@password", senha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                Form2 home = new Form2();
                                home.Show();
                                this.Hide();
                            }
                            else
                            {

                                MessageBox.Show("Usuário ou senha incorretos.");
                            }
                        }
                    }
                }


            } 
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message);
            }


        }
    }
}
