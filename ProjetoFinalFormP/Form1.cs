namespace ProjetoFinalFormP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int espessura = 2; // espessura da borda
            Color corBorda = Color.White; // cor branca

            using (Pen pen = new Pen(corBorda, espessura))
            {
                // Ajusta o retângulo para a borda ficar dentro do painel
                Rectangle rect = new Rectangle(0, 0, panel1.Width - espessura, panel1.Height - espessura);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            int espessura = 2; // espessura da borda
            Color corBorda = Color.White; // cor branca

            using (Pen pen = new Pen(corBorda, espessura))
            {
                // Ajusta o retângulo para a borda ficar dentro do painel
                Rectangle rect = new Rectangle(0, 0, panel1.Width - espessura, panel1.Height - espessura);
                e.Graphics.DrawRectangle(pen, rect);
            }
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
    }
}
