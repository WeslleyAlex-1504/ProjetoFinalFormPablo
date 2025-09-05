using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema.Database;

namespace ProjetoFinalFormP
{
    public partial class CriarCarro : Form
    {

        List<string> marcas = new List<string>
{
    "Acura","Alfa Romeo","Aston Martin","Audi","BMW","Bentley","Bugatti","Buick","Cadillac","Chevrolet",
    "Chrysler","Citroën","Dacia","Daihatsu","Dodge","Ferrari","Fiat","Ford","Genesis","GMC",
    "Honda","Hyundai","Infiniti","Jaguar","Jeep","Karma","Kia","Koenigsegg","Lamborghini","Lancia",
    "Land Rover","Lexus","Lincoln","Lotus","Maserati","Mazda","McLaren","Mercedes-Benz","Mini","Mitsubishi",
    "Nissan","Pagani","Peugeot","Polestar","Porsche","Ram","Renault","Rimac","Rolls-Royce","Saab",
    "Subaru","Suzuki","Tesla","Toyota","Volkswagen","Volvo","Wiesmann","Zenos","Zotye","Aiways",
    "Arrinera","Artega","Aspark","BAC","Baojun","BAIC","Borgward","Brilliance","BYD","Canoo",
    "Changan","Chery","Dartz","DeLorean","Detroit Electric","Eadon Green","Eicher","Elfin","Faraday Future","Fisker",
    "GAC","Gemballa","Ginetta","Great Wall","Haval","Hennessey","Holden","Hudson","IKCO","Imperial",
    "Isdera","JAC","JBA","Jetour","JMC","Jonway","Karrier","Lada","Laffite","Lagonda",
    "Lifan","Lucid Motors","Mahindra","Marussia","Maruti Suzuki","Maxus","MG","Microcar","Minerva","Mosler",
    "Nio","NeuV","Noble","Opel","ORA","Panoz","Perodua","Plymouth","Qoros","Radical",
    "Rely","Rinspeed","Rivian","Roewe","Saipa","Scion","SEAT","Shelby","Singer","Simca",
    "Skoda","Smart","Spyker","SsangYong","Stutz","Subaru Tecnica International","Tata","Tesla","Tianma","TVR",
    "Vauxhall","Vector","Venturi","VinFast","Volkswagen","Wuling","XPeng","Yulon","Zenvo","Zotye",
    "AC","AC Schnitzer","Aixam","Alpina","Alpina Burkard Bovensiepen","Apollo Automobil","Arash","Arcfox","Artega","Aspark Owl",
    "ATS","BAC Mono","Baojun","Bertone","Brabus","Bristol","Caterham","Changfeng","Chrysler Pacifica","Citroën DS",
    "Cizeta","Cupra","Dacia Logan","Daihatsu Charade","De Tomaso","Derways","Dodge Viper","Dongfeng","DR Motor","Eagle",
    "Elva","Englon","Foday","Foton","Fouga","GAC Motor","Ginetta G60","GMC Yukon","Gordon Murray Automotive","Hennessey Venom",
    "Hindustan","Hozon","Hudson Super Six","Imperial Motors","Infiniti QX","JAC Motors","Jiangling","JMC Yuhu","Kaiyi","Karma Revero",
    "Keating","KTM","Lancia Delta","Lancia Ypsilon","Lexus LC","Ligier","Lucid Air","Mahindra XUV","Marussia B1","Maxus T70",
    "Melkus","Mitsuoka","Nissan Leaf","Noble M600","Ora Good Cat","Pagani Huayra","Peugeot 208","Plymouth Barracuda","Polestar 2","Porsche Taycan",
    "Qoros 3","Radical SR3","Ravon","Renault Twizy","Rimac C_Two","Rivian R1T","Roewe RX5","Saab 9-3","SEAT Leon","Shelby GT500",
    "Singer 911","Simca 1000","Skoda Fabia","Smart ForTwo","Spyker C8","SsangYong Tivoli","Stelvio","Stutz Blackhawk","Tata Nano","Tata Harrier",
    "TVR Griffith","Vauxhall Astra","Vector W8","Venturi Fetish","VinFast VF e34","Wiesmann GT MF5","Wuling Hongguang","XPeng P7","Yulon Luxgen","Zenvo TSR-S",
    "Zotye T600","AC Cobra","AC 378 GT","Aixam City","Alpina B7","Alpina D3","Apollo Intensa Emozione","Arash AF10","Arcfox α-T","Artega GT",
    "Aspark Owl","ATS GT","BAC Mono R","Baojun 510","Bertone Mantide","Brabus 900","Bristol Bullet","Caterham Seven","Changfeng Liebao","Chrysler 300C",
    "Citroën C4 Cactus","Cizeta V16T","Cupra Formentor","Dacia Duster","Daihatsu Terios","De Tomaso Pantera","Derways Shuttle","Dodge Challenger","Dongfeng Fengon","DR 1",
    "Eagle Vision","Elfin MS8","Englon SC7","Foday Landfort","Foton Tunland","Fouga Magister","GAC Trumpchi","Ginetta G40","GMC Sierra","Gordon Murray T.50"
};

        public CriarCarro()
        {
            InitializeComponent();
            textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection colecao = new AutoCompleteStringCollection();
            colecao.AddRange(marcas.ToArray());

            textBox3.AutoCompleteCustomSource = colecao;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CriarCarro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {

                    int clienteId;
                    bool clienteAtivo;
                    string sqlCliente = "SELECT Id,Ativo FROM Cliente WHERE Cpf = @cpf";

                    using (var cmdCliente = new MySqlCommand(sqlCliente, conexao))
                    {
                        cmdCliente.Parameters.AddWithValue("@cpf", textBox5.Text.Trim());

                        using (var reader = cmdCliente.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Cliente não encontrado com este CPF.");
                                return;
                            }

                            string placa = textBox1.Text.Trim().ToUpper();

                            if (!Regex.IsMatch(textBox1.Text.Trim().ToUpper(), @"^([A-Z]{3}-\d{4}|[A-Z]{3}\d[A-Z]\d{2})$"))
                            {
                                MessageBox.Show("Placa inválida! Formatos válidos: ABC-1234 ou ABC1D23.");
                                return;
                            }

                            clienteId = reader.GetInt32("Id");
                            clienteAtivo = reader.GetBoolean("Ativo");
                        }
                    }

                    if (!clienteAtivo)
                    {
                        MessageBox.Show("Erro: Cliente inativo. Não é possível cadastrar carro.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Trim().Length < 2 ||
                        string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text.Trim().Length < 2 ||
                        string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text.Trim().Length < 2 ||
                        string.IsNullOrWhiteSpace(textBox4.Text) || !int.TryParse(textBox4.Text.Trim(), out int ano) || ano < 1950 || ano > 2025 ||
                        string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text.Trim().Length < 2)
                    {
                        MessageBox.Show("Todos os campos devem ter pelo menos 3 caracteres e Ano deve ser entre 1950 e 2025!");
                        return;
                    }

                    string sqlCarro = @"INSERT INTO Carro (Placa, Marca, Modelo, Ano, ClienteId)
                                VALUES (@Placa, @Marca, @Modelo, @Ano, @ClienteId)";

                    using (var cmdCarro = new MySqlCommand(sqlCarro, conexao))
                    {
                        cmdCarro.Parameters.AddWithValue("@Placa", textBox1.Text.Trim());
                        cmdCarro.Parameters.AddWithValue("@Marca", textBox3.Text.Trim());
                        cmdCarro.Parameters.AddWithValue("@Modelo", textBox2.Text.Trim());
                        cmdCarro.Parameters.AddWithValue("@Ano", Convert.ToInt32(textBox4.Text.Trim()));
                        cmdCarro.Parameters.AddWithValue("@ClienteId", clienteId);

                        int linhasAfetadas = cmdCarro.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Carro inserido com sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir carro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
