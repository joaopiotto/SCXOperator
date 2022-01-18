using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SCXOperator
{
    public partial class frmCalculoPercurso : Form
    {

        #region Mascara para campos numéricos

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox obj = sender as TextBox;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (obj.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtDecimal_Leave(object sender, EventArgs e)
        {
            TextBox obj = sender as TextBox;
            String valor = obj.Text.Replace("R$", String.Empty);

            if (String.IsNullOrEmpty(valor.Replace(",", String.Empty)))
                valor = "0,00";

            obj.Text = string.Format("{0:C}", Convert.ToDouble(valor)).Replace("R$", String.Empty).Trim();
        }

        private void txtInteiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        public void AplicarMascaraDecimal(TextBox textBox)
        {
            textBox.KeyPress += txtDecimal_KeyPress;
            textBox.Leave += txtDecimal_Leave;
        }

        public void AplicarMascaraInteiro(TextBox textBox)
        {
            textBox.KeyPress += txtInteiro_KeyPress;
        }

        #endregion

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Processar(ofdAbrir.FileName);
        }

        public frmCalculoPercurso()
        {
            InitializeComponent();

            AplicarMascaraDecimal(txtTxSelecaoMelhores);
            AplicarMascaraDecimal(txtFitnessMeta);
            AplicarMascaraDecimal(txtTaxaMutacaoPopulacao);
            AplicarMascaraDecimal(txtTaxaMutacaoGenes);

            AplicarMascaraInteiro(txtGeracao);
            AplicarMascaraInteiro(txtMaxGeracaoSemMelhoria);
            AplicarMascaraInteiro(txtTamPopulacao);

        }

        public void Processar(String fileName)
        {

            chart.Series.Clear();
            dgvMelhores.Rows.Clear();

            double[][] matriz = Util.CarregarMatrizCusto(fileName);
            Populacao populacao = new Populacao(int.Parse(txtTamPopulacao.Text), matriz);

            Cromossomo solucao = populacao.CalcularMelhorSolucao(int.Parse(txtGeracao.Text), 
                                                                 int.Parse(txtMaxGeracaoSemMelhoria.Text),
                                                                 double.Parse(txtTxSelecaoMelhores.Text), 
                                                                 double.Parse(txtTaxaMutacaoPopulacao.Text),
                                                                 double.Parse(txtTaxaMutacaoGenes.Text));

            lblFitness.Text = "Melhor fitness encontrado: " + Math.Round(solucao.Fitness, 3);
            lblTotalGeracoes.Text = "Gerações necessárias para convergência: " + populacao.HistoricoMelhoresPorGeracao.Count();
            lblTempoGasto.Text = "Tempo Gasto: " + populacao.TempoDeProcessamento.ToString(@"hh\:mm\:ss");

            if (String.IsNullOrEmpty(txtFitnessMeta.Text))
                lblFitnessInf.Text = String.Empty;
            else if (solucao.Fitness <= double.Parse(txtFitnessMeta.Text))
            {
                lblFitnessInf.Text = "SIM";
                lblFitnessInf.ForeColor = Color.Green;
            }
            else
            {
                lblFitnessInf.Text = "NÃO";
                lblFitnessInf.ForeColor = Color.Red;
            }

            for (int i = 0; i < populacao.HistoricoMelhoresPorGeracao.Count; i++)
			{

                dgvMelhores.Rows.Add(i, populacao.HistoricoMelhoresPorGeracao[i].Fitness);

                for (int j = 0; j < populacao.HistoricoMelhoresPorGeracao[i].Genes.Length; j++)
                    dgvMelhores.Rows[i].Cells[2].Value = populacao.HistoricoMelhoresPorGeracao[i].Genes[j];

                dgvMelhores.Rows[i].Cells[2].Value = String.Join(" - ", populacao.HistoricoMelhoresPorGeracao[i].Genes);

            }

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            Series serie = new Series();

            serie.ChartArea = "ChartArea1";
            serie.ChartType = SeriesChartType.Line;
            serie.MarkerStyle = MarkerStyle.Star4;

            serie.Color = Color.Red;

            serie.BorderWidth = 2;

            for (int i = 0; i < dgvMelhores.Rows.Count; i++)
                serie.Points.Add(new DataPoint(i + 1, double.Parse(dgvMelhores.Rows[i].Cells[1].Value.ToString())));

            chart.Series.Add(serie);

            if (!String.IsNullOrEmpty(txtFitnessMeta.Text))
            {

                Series linhaMeta = new Series();

                linhaMeta.ChartArea = "ChartArea1";
                linhaMeta.ChartType = SeriesChartType.Line;
                linhaMeta.MarkerStyle = MarkerStyle.None;
                linhaMeta.BorderWidth = 2;

                linhaMeta.Color = Color.Blue;

                linhaMeta.Points.Add(new DataPoint(0, double.Parse(txtFitnessMeta.Text)));
                linhaMeta.Points.Add(new DataPoint(dgvMelhores.Rows.Count + 1, double.Parse(txtFitnessMeta.Text)));

                chart.Series.Add(linhaMeta);

            }

            chart.ChartAreas[0].AxisX.Title = "Geração";
            chart.ChartAreas[0].AxisY.Title = "Fitness";

            MessageBox.Show("Processo finalizado");
            
        }

    }
}
