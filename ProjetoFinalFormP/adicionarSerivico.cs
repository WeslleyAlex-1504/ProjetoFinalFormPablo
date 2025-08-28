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
    public partial class adicionarSerivico : Form
    {

        List<string> peças = new List<string>
{
    "Motor", "Cabeçote", "Junta do cabeçote", "Correia dentada", "Correia auxiliar", "Bomba de óleo", "Bomba d'água", "Radiador", "Ventoinha do radiador",
    "Filtro de óleo", "Filtro de ar", "Filtro de combustível", "Velas de ignição", "Cabo de vela", "Bateria", "Alternador", "Motor de arranque",
    "Caixa de câmbio", "Embreagem", "Volante do motor", "Eixo de transmissão", "Diferencial", "Semi-eixos", "Cardan", "Amortecedor dianteiro",
    "Amortecedor traseiro", "Mola helicoidal", "Braço de suspensão", "Bieleta da barra estabilizadora", "Barra estabilizadora", "Coxim de motor",
    "Coxim de câmbio", "Pastilhas de freio", "Discos de freio", "Pinça de freio", "Cilindro mestre de freio", "Cilindro de roda", "Mangueira de freio",
    "Servofreio", "Lona de freio (tambores)", "Disco de freio traseiro", "Fluido de freio", "Óleo do motor", "Óleo de transmissão", "Óleo de diferencial",
    "Fluido de direção hidráulica", "Fluido do arrefecimento", "Filtro do ar condicionado", "Radiador do ar condicionado", "Compressor do ar condicionado",
    "Válvula termostática", "Termostato", "Mangueiras do motor", "Bomba de combustível", "Injetores", "Sensor de oxigênio", "Sensor de temperatura",
    "Sensor de pressão do óleo", "Sensor de rotação", "Sensor MAP / MAF", "Cabos e chicotes elétricos", "Farol dianteiro", "Lanterna traseira",
    "Pisca dianteiro", "Pisca traseiro", "Lanterna de freio", "Farol de neblina", "Luzes internas", "Painel de instrumentos", "Retrovisor lateral",
    "Retrovisor interno", "Para-choque dianteiro", "Para-choque traseiro", "Capô", "Porta dianteira", "Porta traseira", "Teto", "Parabrisa dianteiro",
    "Vidro traseiro", "Vidro lateral", "Maçaneta externa", "Maçaneta interna", "Trava elétrica", "Fechadura", "Espelho retrovisor", "Alavanca de câmbio",
    "Pedais (freio, acelerador, embreagem)", "Volante", "Cinto de segurança", "Airbag", "Pneus", "Rodas / Aros", "Calotas", "Cubos de roda",
    "Rolamentos", "Pastilhas de freio do tambor", "Cilindro de roda do tambor", "Mola de freio", "Sistema de escapamento", "Silencioso", "Catalisador",
    "Coletor de escape", "Mangueiras do sistema de ar", "Filtro de cabine", "Haste da direção", "Caixa de direção", "Terminal de direção", "Pivô de suspensão",
    "Suporte do motor", "Mangueira de combustível", "Reservatório de combustível", "Tampa do tanque", "Filtro de combustível", "Bomba elétrica do combustível",
    "Mangueira de vácuo", "Tubo de ar do motor", "Chave de ignição", "Bobina de ignição", "Módulo de injeção", "Computador de bordo (ECU)",
    "Interruptor de luzes", "Interruptor de limpador de para-brisa", "Motor do limpador de para-brisa", "Palhetas do limpador", "Reservatório de água do limpador",
    "Sensor de estacionamento", "Câmera de ré", "Alarme", "Sistema multimídia / rádio", "Turbo", "Intercooler", "Inversor de energia (carros elétricos/híbridos)",
    "Bateria de alta tensão (híbrido/EV)", "Motor elétrico (carro elétrico)", "Módulo de controle de motor híbrido", "Injetores de alta pressão (direta)",
    "Válvula EGR", "Sensor de pressão do turbo", "Sensor de detonação", "Filtro de partículas diesel (DPF)", "Catalisador secundário",
    "Faróis de LED matriciais", "Faróis adaptativos", "Sensores de chuva", "Sensor de luminosidade", "Câmeras 360° (panorâmica)",
    "Sensores de estacionamento ultrassônicos", "Alerta de ponto cego", "Assistente de faixa (Lane Assist)", "Controle de cruzeiro adaptativo",
    "Suspensão adaptativa", "Amortecedor eletrônico", "Volante multifuncional com controles", "Sistema start-stop", "Ar-condicionado digital dual zone",
    "Aquecedor de bancos", "Teto solar elétrico", "Sistema de som premium (amplificador, subwoofer)", "Interface multimídia com tela touchscreen",
    "Modulo de conectividade (CarPlay/Android Auto)", "Sensor de qualidade do ar interno", "Filtro de ar condicionado HEPA",
    "Airbags laterais e de cortina", "Airbags de joelho", "Sistema de monitoramento de pressão dos pneus (TPMS)", "Direção elétrica assistida",
    "Freio elétrico de estacionamento (EPB)", "Sistema de regeneração de energia (EV/híbrido)", "Painel de instrumentos digital (TFT/LCD)",
    "Display head-up (HUD)"
};


        public adicionarSerivico()
        {
            InitializeComponent();
            textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection colecao = new AutoCompleteStringCollection();
            colecao.AddRange(peças.ToArray());

            textBox4.AutoCompleteCustomSource = colecao;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

                    if (!int.TryParse(textBox1.Text.Trim(), out int osId))
                    {
                        MessageBox.Show("ID da OS inválido.");
                        return;
                    }


                    string sqlOs = "SELECT Ativo FROM OS WHERE Id = @OsId LIMIT 1";
                    bool osAtiva;
                    using (var cmdOs = new MySqlCommand(sqlOs, conexao))
                    {
                        cmdOs.Parameters.AddWithValue("@OsId", osId);
                        var resultOs = cmdOs.ExecuteScalar();
                        if (resultOs == null)
                        {
                            MessageBox.Show("OS não encontrada.");
                            return;
                        }
                        osAtiva = Convert.ToBoolean(resultOs);
                    }

                    if (!osAtiva)
                    {
                        MessageBox.Show("Não é possível adicionar serviço: a OS está finalizada.");
                        return;
                    }

                    string sqlFuncionario = "SELECT Id, Ativo FROM Funcionario WHERE Nome = @Nome LIMIT 1";
                    int funcionarioId;
                    bool funcionarioAtivo;
                    using (var cmdFuncionario = new MySqlCommand(sqlFuncionario, conexao))
                    {
                        cmdFuncionario.Parameters.AddWithValue("@Nome", textBox3.Text.Trim());
                        using (var reader = cmdFuncionario.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Funcionário não encontrado com esse nome.");
                                return;
                            }

                            funcionarioId = reader.GetInt32("Id");
                            funcionarioAtivo = reader.GetBoolean("Ativo");
                        }
                    }

                    if (!funcionarioAtivo)
                    {
                        MessageBox.Show("Não é possível adicionar serviço: funcionário não trabalha mais aqui.");
                        return;
                    }

                    string sql = @"INSERT INTO Servico (SerRealizado, Peca, OsId, FuncionarioId) 
                       VALUES (@SerRealizado, @Peca, @OsId, @FuncionarioId)";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@SerRealizado", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Peca", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@OsId", osId);
                        cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Serviço adicionado com sucesso!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao adicionar serviço.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar serviço: " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
