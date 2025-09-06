using MySql.Data.MySqlClient;
using ProjetoFinalFormP.Model;
using Sistema.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoFinalFormP
{
    public partial class atualizarServico : Form
    {

        private Servicos _formServico;

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
            "Display head-up (HUD)","Óleo hidráulico da direção", "Óleo de freio DOT 3", "Óleo de freio DOT 4", "Óleo de freio DOT 5", "Fluido CVT", "Fluido de transmissão automática (ATF)",
            "Graxa para rolamentos", "Aditivo para radiador", "Aditivo para combustível", "Tensor da correia", "Polia do virabrequim", "Corrente de comando",
            "Tuchos hidráulicos", "Balancins de válvula", "Junta da tampa de válvulas", "Cárter do motor", "Protetor de cárter", "Reservatório de expansão do radiador",
            "Tampa do radiador", "Regulador de pressão do combustível", "Válvula de purga do cânister", "Reservatório do cânister", "Corpo de borboleta (TBI)", "Atuador da marcha lenta",
            "Junta do coletor de escape", "Flexível do escapamento", "Relés", "Fusíveis", "Sensor ABS", "Sensor de velocidade da roda",
            "Módulo do airbag", "Atuador elétrico do retrovisor", "Atuador elétrico do porta-malas", "Sensor de chuva", "Sensor de luminosidade", "Sensor de monitoramento dos pneus (TPMS)",
            "Alerta de ponto cego", "Assistente de faixa (Lane Assist)", "Câmera 360°", "Teto solar elétrico", "Apoio de braço", "Encosto de cabeça",
            "Tapetes internos", "Forro interno do teto", "Isolamento acústico do motor", "Reservatório de água do limpador", "Tampa do tanque de combustível", "Juntas homocinéticas",
            "Buchas da bandeja", "Calço de suspensão", "Polia do alternador", "Escovas do alternador",
            };

        public atualizarServico(Servicos formServico)
        {
            InitializeComponent();
            _formServico = formServico;

            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection colecao = new AutoCompleteStringCollection();
            colecao.AddRange(peças.ToArray());

            textBox2.AutoCompleteCustomSource = colecao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    var campos = new Dictionary<string, object>();


                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        if (textBox1.Text.Trim().Length < 3)
                        {
                            MessageBox.Show("O campo 'Serviço Realizado' deve ter pelo menos 4 caracteres.");
                            return;
                        }
                        campos.Add("SerRealizado", textBox1.Text.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        if (textBox2.Text.Trim().Length < 3)
                        {
                            MessageBox.Show("O campo 'Peça' deve ter pelo menos 4 caracteres.");
                            return;
                        }
                        campos.Add("Peca", textBox2.Text.Trim());
                    }

                    if (!string.IsNullOrWhiteSpace(comboBox2.Text))
                    {
                        bool ativo = comboBox2.Text.Trim().Equals("Incompleto", StringComparison.OrdinalIgnoreCase);
                        campos.Add("Ativo", ativo ? 1 : 0);
                    }

                    if (campos.Count == 0)
                    {
                        MessageBox.Show("Nenhum campo preenchido para atualizar.");
                        return;
                    }

                    int servicoId = int.Parse(textBox6.Text.Trim());
                    int osId;

                    using (var cmdOs = new MySqlCommand("SELECT OsId FROM Servico WHERE Id = @Id", conexao))
                    {
                        cmdOs.Parameters.AddWithValue("@Id", servicoId);
                        object resultado = cmdOs.ExecuteScalar();
                        if (resultado == null)
                        {
                            MessageBox.Show("Serviço não encontrado.");
                            return;
                        }
                        osId = Convert.ToInt32(resultado);
                    }

                    using (var cmdVerificaOs = new MySqlCommand("SELECT Ativo FROM OS WHERE Id = @Id", conexao))
                    {
                        cmdVerificaOs.Parameters.AddWithValue("@Id", osId);
                        object ativoOsObj = cmdVerificaOs.ExecuteScalar();
                        if (ativoOsObj == null)
                        {
                            MessageBox.Show("OS associada não encontrada.");
                            return;
                        }
                        bool osAtiva = Convert.ToBoolean(ativoOsObj);
                        if (!osAtiva)
                        {
                            MessageBox.Show("OS finalizada. Não é possível atualizar este serviço.");
                            return;
                        }
                    }

                    string sql = "UPDATE Servico SET " +
                                 string.Join(", ", campos.Keys.Select(c => $"{c} = @{c}")) +
                                 " WHERE Id = @Id";

                    if (!campos.ContainsKey("Ativo"))
                        sql += " AND Ativo = 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        foreach (var par in campos)
                            cmd.Parameters.AddWithValue("@" + par.Key, par.Value);

                        cmd.Parameters.AddWithValue("@Id", int.Parse(textBox6.Text.Trim()));

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Registro atualizado com sucesso!");
                            _formServico.Servico_Load(null, null);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro atualizado (ID não encontrado ou já foi finalizado).");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
