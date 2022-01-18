using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SCXOperator
{
    public partial class frmExperimentos : Form
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

        public frmExperimentos()
        {
            InitializeComponent();

            AplicarMascaraDecimal(txtTxSelecaoMelhores);
            AplicarMascaraDecimal(txtFitnessMeta);
            AplicarMascaraDecimal(txtTaxaMutacaoPopulacao);
            AplicarMascaraDecimal(txtTaxaMutacaoGenes);

            AplicarMascaraInteiro(txtGeracao);
            AplicarMascaraInteiro(txtMaxGeracaoSemMelhoria);
            AplicarMascaraInteiro(txtTamPopulacao);
            AplicarMascaraInteiro(txtExecucao);

        }

        public void Processar(String fileName)
        {

            chart.Series.Clear();
            dgvResultados.Rows.Clear();
            chart.ResetAutoValues();

            Runner runner = new Runner();
            
            List<DadosExecucao> HistoricoExperimento = runner.Executar(fileName,
                                                              int.Parse(txtExecucao.Text),
                                                              int.Parse(txtTamPopulacao.Text),
                                                              int.Parse(txtGeracao.Text),
                                                              int.Parse(txtMaxGeracaoSemMelhoria.Text),
                                                              double.Parse(txtTxSelecaoMelhores.Text),
                                                              double.Parse(txtTaxaMutacaoPopulacao.Text),
                                                              double.Parse(txtTaxaMutacaoGenes.Text)
                                                              );

            dgvResultados.Rows.Add(HistoricoExperimento.Min(x => x.MelhorFitness),
                                   HistoricoExperimento.Average(x => x.MelhorFitness),
                                   HistoricoExperimento.Max(x => x.MelhorFitness));
            dgvResultados.Rows[0].HeaderCell.Value = "Fitness";

            dgvResultados.Rows.Add(HistoricoExperimento.Min(x => x.Tempo).ToString(@"hh\:mm\:ss"),
                                   new TimeSpan((long)Math.Round(HistoricoExperimento.Average(x => x.Tempo.Ticks))).ToString(@"hh\:mm\:ss"),
                                   HistoricoExperimento.Max(x => x.Tempo).ToString(@"hh\:mm\:ss"));
            dgvResultados.Rows[1].HeaderCell.Value = "Tempo";

            dgvResultados.Rows.Add(HistoricoExperimento.Min(x => x.TotalGeracaoConvergencia),
                                   HistoricoExperimento.Average(x => x.TotalGeracaoConvergencia),
                                   HistoricoExperimento.Max(x => x.TotalGeracaoConvergencia));
            dgvResultados.Rows[2].HeaderCell.Value = "Gerações";

            
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            Series serie = new Series();

            serie.ChartArea = "ChartArea1";
            serie.ChartType = SeriesChartType.Line;
            serie.MarkerStyle = MarkerStyle.Circle;
            serie.BorderWidth = 2;
            serie.Color = Color.Red;

            for (int i = 0; i < HistoricoExperimento.Count; i++)
            {
                DataPoint p = new DataPoint(i + 1, HistoricoExperimento[i].MelhorFitness);
                p.Label = Math.Round(HistoricoExperimento[i].MelhorFitness, 2).ToString();
                serie.Points.Add(p);
            }
                

            chart.Series.Add(serie);

            if (!String.IsNullOrEmpty(txtFitnessMeta.Text))
            {

                Series linhaMeta = new Series();

                linhaMeta.ChartArea = "ChartArea1";
                linhaMeta.ChartType = SeriesChartType.Line;
                linhaMeta.MarkerStyle = MarkerStyle.None;
                linhaMeta.BorderWidth = 2;

                linhaMeta.Color = Color.Blue;

                linhaMeta.Points.Add(new DataPoint(1, double.Parse(txtFitnessMeta.Text)));
                linhaMeta.Points.Add(new DataPoint(HistoricoExperimento.Count, double.Parse(txtFitnessMeta.Text)));

                chart.Series.Add(linhaMeta);

            }

            chart.ChartAreas[0].AxisX.Title = "Execução";
            chart.ChartAreas[0].AxisY.Title = "Melhor Fitness";

            MessageBox.Show("Processo finalizado");

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Processar(ofdAbrir.FileName);
        }
    }

}
