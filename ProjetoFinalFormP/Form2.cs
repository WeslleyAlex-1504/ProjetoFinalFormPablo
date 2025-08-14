using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalFormP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = @"C:\Users\WESLLEYALEXDASILVA\Downloads\Background.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionarios funcionario = new Funcionarios();
            funcionario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Carros carro = new Carros();
            carro.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Os os = new Os();
            os.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Servicos servico = new Servicos();
            servico.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
