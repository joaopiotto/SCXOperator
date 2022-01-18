
namespace SCXOperator
{
    partial class frmExperimentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExecucao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFitnessMeta = new System.Windows.Forms.TextBox();
            this.txtMaxGeracaoSemMelhoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaxaMutacaoGenes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaxaMutacaoPopulacao = new System.Windows.Forms.TextBox();
            this.txtGeracao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTxSelecaoMelhores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamPopulacao = new System.Windows.Forms.TextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Fitness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_geracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnProcessar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtExecucao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtFitnessMeta);
            this.panel1.Controls.Add(this.txtMaxGeracaoSemMelhoria);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTaxaMutacaoGenes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTaxaMutacaoPopulacao);
            this.panel1.Controls.Add(this.txtGeracao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTxSelecaoMelhores);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTamPopulacao);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 175);
            this.panel1.TabIndex = 23;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(424, 137);
            this.btnProcessar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(195, 28);
            this.btnProcessar.TabIndex = 8;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Número de execuções:";
            // 
            // txtExecucao
            // 
            this.txtExecucao.Location = new System.Drawing.Point(424, 82);
            this.txtExecucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExecucao.Name = "txtExecucao";
            this.txtExecucao.Size = new System.Drawing.Size(193, 22);
            this.txtExecucao.TabIndex = 7;
            this.txtExecucao.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fitness meta (opicional):";
            // 
            // txtFitnessMeta
            // 
            this.txtFitnessMeta.Location = new System.Drawing.Point(424, 27);
            this.txtFitnessMeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFitnessMeta.Name = "txtFitnessMeta";
            this.txtFitnessMeta.Size = new System.Drawing.Size(193, 22);
            this.txtFitnessMeta.TabIndex = 6;
            this.txtFitnessMeta.Text = "39,00";
            // 
            // txtMaxGeracaoSemMelhoria
            // 
            this.txtMaxGeracaoSemMelhoria.Location = new System.Drawing.Point(217, 27);
            this.txtMaxGeracaoSemMelhoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaxGeracaoSemMelhoria.Name = "txtMaxGeracaoSemMelhoria";
            this.txtMaxGeracaoSemMelhoria.Size = new System.Drawing.Size(193, 22);
            this.txtMaxGeracaoSemMelhoria.TabIndex = 3;
            this.txtMaxGeracaoSemMelhoria.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Taxa mutação genes:";
            // 
            // txtTaxaMutacaoGenes
            // 
            this.txtTaxaMutacaoGenes.Location = new System.Drawing.Point(217, 82);
            this.txtTaxaMutacaoGenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxaMutacaoGenes.Name = "txtTaxaMutacaoGenes";
            this.txtTaxaMutacaoGenes.Size = new System.Drawing.Size(193, 22);
            this.txtTaxaMutacaoGenes.TabIndex = 4;
            this.txtTaxaMutacaoGenes.Text = "0,10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Máx. gerações sem melhoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Taxa mutação população:";
            // 
            // txtTaxaMutacaoPopulacao
            // 
            this.txtTaxaMutacaoPopulacao.Location = new System.Drawing.Point(217, 138);
            this.txtTaxaMutacaoPopulacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaxaMutacaoPopulacao.Name = "txtTaxaMutacaoPopulacao";
            this.txtTaxaMutacaoPopulacao.Size = new System.Drawing.Size(193, 22);
            this.txtTaxaMutacaoPopulacao.TabIndex = 5;
            this.txtTaxaMutacaoPopulacao.Text = "0,10";
            // 
            // txtGeracao
            // 
            this.txtGeracao.Location = new System.Drawing.Point(11, 27);
            this.txtGeracao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGeracao.Name = "txtGeracao";
            this.txtGeracao.Size = new System.Drawing.Size(193, 22);
            this.txtGeracao.TabIndex = 0;
            this.txtGeracao.Text = "150";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Taxa de seleção melhores:";
            // 
            // txtTxSelecaoMelhores
            // 
            this.txtTxSelecaoMelhores.Location = new System.Drawing.Point(11, 137);
            this.txtTxSelecaoMelhores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTxSelecaoMelhores.Name = "txtTxSelecaoMelhores";
            this.txtTxSelecaoMelhores.Size = new System.Drawing.Size(193, 22);
            this.txtTxSelecaoMelhores.TabIndex = 2;
            this.txtTxSelecaoMelhores.Text = "0,20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Máx. gerações:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tamanho população:";
            // 
            // txtTamPopulacao
            // 
            this.txtTamPopulacao.Location = new System.Drawing.Point(11, 82);
            this.txtTamPopulacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTamPopulacao.Name = "txtTamPopulacao";
            this.txtTamPopulacao.Size = new System.Drawing.Size(193, 22);
            this.txtTamPopulacao.TabIndex = 1;
            this.txtTamPopulacao.Text = "1000";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fitness,
            this.Total_geracao,
            this.Tempo});
            this.dgvResultados.Location = new System.Drawing.Point(13, 196);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 90;
            this.dgvResultados.Size = new System.Drawing.Size(629, 228);
            this.dgvResultados.TabIndex = 24;
            // 
            // Fitness
            // 
            this.Fitness.HeaderText = "Mín";
            this.Fitness.MinimumWidth = 6;
            this.Fitness.Name = "Fitness";
            this.Fitness.Width = 125;
            // 
            // Total_geracao
            // 
            this.Total_geracao.HeaderText = "Média";
            this.Total_geracao.MinimumWidth = 6;
            this.Total_geracao.Name = "Total_geracao";
            this.Total_geracao.Width = 125;
            // 
            // Tempo
            // 
            this.Tempo.HeaderText = "Máx";
            this.Tempo.MinimumWidth = 6;
            this.Tempo.Name = "Tempo";
            this.Tempo.Width = 125;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(651, 14);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(528, 410);
            this.chart.TabIndex = 25;
            this.chart.Text = "chart1";
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.InitialDirectory = "Área de Trabalho";
            // 
            // frmExperimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 438);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExperimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Experimentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFitnessMeta;
        private System.Windows.Forms.TextBox txtMaxGeracaoSemMelhoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaxaMutacaoGenes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaxaMutacaoPopulacao;
        private System.Windows.Forms.TextBox txtGeracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTxSelecaoMelhores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamPopulacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExecucao;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fitness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_geracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
    }
}