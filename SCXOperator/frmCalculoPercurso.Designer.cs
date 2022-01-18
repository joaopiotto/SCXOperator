using System;
using System.Windows.Forms;

namespace SCXOperator
{
    partial class frmCalculoPercurso
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtGeracao = new System.Windows.Forms.TextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamPopulacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTxSelecaoMelhores = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFitnessMeta = new System.Windows.Forms.TextBox();
            this.txtMaxGeracaoSemMelhoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaxaMutacaoGenes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaxaMutacaoPopulacao = new System.Windows.Forms.TextBox();
            this.dgvMelhores = new System.Windows.Forms.DataGridView();
            this.Geracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fitness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFitnessInf = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.lblTempoGasto = new System.Windows.Forms.Label();
            this.lblTotalGeracoes = new System.Windows.Forms.Label();
            this.lblFitness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelhores)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Location = new System.Drawing.Point(13, 265);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(420, 251);
            this.chart.TabIndex = 8;
            this.chart.Text = "chart1";
            // 
            // txtGeracao
            // 
            this.txtGeracao.Location = new System.Drawing.Point(11, 27);
            this.txtGeracao.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeracao.Name = "txtGeracao";
            this.txtGeracao.Size = new System.Drawing.Size(193, 22);
            this.txtGeracao.TabIndex = 0;
            this.txtGeracao.Text = "150";
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(216, 189);
            this.btnProcessar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(194, 28);
            this.btnProcessar.TabIndex = 7;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
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
            // ofdAbrir
            // 
            this.ofdAbrir.InitialDirectory = "Área de Trabalho";
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
            this.txtTamPopulacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtTamPopulacao.Name = "txtTamPopulacao";
            this.txtTamPopulacao.Size = new System.Drawing.Size(193, 22);
            this.txtTamPopulacao.TabIndex = 1;
            this.txtTamPopulacao.Text = "1000";
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
            this.txtTxSelecaoMelhores.Margin = new System.Windows.Forms.Padding(4);
            this.txtTxSelecaoMelhores.Name = "txtTxSelecaoMelhores";
            this.txtTxSelecaoMelhores.Size = new System.Drawing.Size(193, 22);
            this.txtTxSelecaoMelhores.TabIndex = 2;
            this.txtTxSelecaoMelhores.Text = "0,20";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.panel1.Controls.Add(this.btnProcessar);
            this.panel1.Controls.Add(this.txtTxSelecaoMelhores);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTamPopulacao);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 228);
            this.panel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fitness meta (opicional):";
            // 
            // txtFitnessMeta
            // 
            this.txtFitnessMeta.Location = new System.Drawing.Point(11, 192);
            this.txtFitnessMeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtFitnessMeta.Name = "txtFitnessMeta";
            this.txtFitnessMeta.Size = new System.Drawing.Size(193, 22);
            this.txtFitnessMeta.TabIndex = 3;
            this.txtFitnessMeta.Text = "39,00";
            // 
            // txtMaxGeracaoSemMelhoria
            // 
            this.txtMaxGeracaoSemMelhoria.Location = new System.Drawing.Point(217, 27);
            this.txtMaxGeracaoSemMelhoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxGeracaoSemMelhoria.Name = "txtMaxGeracaoSemMelhoria";
            this.txtMaxGeracaoSemMelhoria.Size = new System.Drawing.Size(193, 22);
            this.txtMaxGeracaoSemMelhoria.TabIndex = 4;
            this.txtMaxGeracaoSemMelhoria.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Taxa mutação genes:";
            // 
            // txtTaxaMutacaoGenes
            // 
            this.txtTaxaMutacaoGenes.Location = new System.Drawing.Point(217, 137);
            this.txtTaxaMutacaoGenes.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxaMutacaoGenes.Name = "txtTaxaMutacaoGenes";
            this.txtTaxaMutacaoGenes.Size = new System.Drawing.Size(193, 22);
            this.txtTaxaMutacaoGenes.TabIndex = 6;
            this.txtTaxaMutacaoGenes.Text = "0,10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Máx. gerações sem melhoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Taxa mutação população:";
            // 
            // txtTaxaMutacaoPopulacao
            // 
            this.txtTaxaMutacaoPopulacao.Location = new System.Drawing.Point(217, 82);
            this.txtTaxaMutacaoPopulacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxaMutacaoPopulacao.Name = "txtTaxaMutacaoPopulacao";
            this.txtTaxaMutacaoPopulacao.Size = new System.Drawing.Size(193, 22);
            this.txtTaxaMutacaoPopulacao.TabIndex = 5;
            this.txtTaxaMutacaoPopulacao.Text = "0,10";
            // 
            // dgvMelhores
            // 
            this.dgvMelhores.AllowUserToAddRows = false;
            this.dgvMelhores.AllowUserToDeleteRows = false;
            this.dgvMelhores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMelhores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Geracao,
            this.Fitness,
            this.Percurso});
            this.dgvMelhores.Location = new System.Drawing.Point(444, 13);
            this.dgvMelhores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMelhores.Name = "dgvMelhores";
            this.dgvMelhores.RowHeadersVisible = false;
            this.dgvMelhores.RowHeadersWidth = 51;
            this.dgvMelhores.Size = new System.Drawing.Size(776, 503);
            this.dgvMelhores.TabIndex = 9;
            // 
            // Geracao
            // 
            this.Geracao.HeaderText = "Geração";
            this.Geracao.MinimumWidth = 6;
            this.Geracao.Name = "Geracao";
            this.Geracao.Width = 125;
            // 
            // Fitness
            // 
            this.Fitness.HeaderText = "Fitness";
            this.Fitness.MinimumWidth = 6;
            this.Fitness.Name = "Fitness";
            this.Fitness.Width = 125;
            // 
            // Percurso
            // 
            this.Percurso.HeaderText = "Percurso";
            this.Percurso.MinimumWidth = 6;
            this.Percurso.Name = "Percurso";
            this.Percurso.Width = 300;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblFitnessInf);
            this.panel2.Controls.Add(this.Label);
            this.panel2.Controls.Add(this.lblTempoGasto);
            this.panel2.Controls.Add(this.lblTotalGeracoes);
            this.panel2.Controls.Add(this.lblFitness);
            this.panel2.Location = new System.Drawing.Point(13, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 70);
            this.panel2.TabIndex = 23;
            // 
            // lblFitnessInf
            // 
            this.lblFitnessInf.AutoSize = true;
            this.lblFitnessInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFitnessInf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFitnessInf.Location = new System.Drawing.Point(549, 41);
            this.lblFitnessInf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFitnessInf.Name = "lblFitnessInf";
            this.lblFitnessInf.Size = new System.Drawing.Size(0, 17);
            this.lblFitnessInf.TabIndex = 21;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(397, 41);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(152, 17);
            this.Label.TabIndex = 20;
            this.Label.Text = "Fitness inferior à meta:";
            // 
            // lblTempoGasto
            // 
            this.lblTempoGasto.AutoSize = true;
            this.lblTempoGasto.Location = new System.Drawing.Point(397, 13);
            this.lblTempoGasto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempoGasto.Name = "lblTempoGasto";
            this.lblTempoGasto.Size = new System.Drawing.Size(95, 17);
            this.lblTempoGasto.TabIndex = 19;
            this.lblTempoGasto.Text = "Tempo gasto:";
            // 
            // lblTotalGeracoes
            // 
            this.lblTotalGeracoes.AutoSize = true;
            this.lblTotalGeracoes.Location = new System.Drawing.Point(8, 40);
            this.lblTotalGeracoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalGeracoes.Name = "lblTotalGeracoes";
            this.lblTotalGeracoes.Size = new System.Drawing.Size(276, 17);
            this.lblTotalGeracoes.TabIndex = 18;
            this.lblTotalGeracoes.Text = "Gerações necessárias para convergência:";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Location = new System.Drawing.Point(8, 12);
            this.lblFitness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(176, 17);
            this.lblFitness.TabIndex = 17;
            this.lblFitness.Text = "Melhor fitness encontrado:";
            // 
            // frmCalculoPercurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvMelhores);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculoPercurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular melhor percurso - SCX Operator";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMelhores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox txtGeracao;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamPopulacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTxSelecaoMelhores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMelhores;
        private System.Windows.Forms.TextBox txtMaxGeracaoSemMelhoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaxaMutacaoGenes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaxaMutacaoPopulacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fitness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percurso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label lblTempoGasto;
        private System.Windows.Forms.Label lblTotalGeracoes;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFitnessMeta;
        private System.Windows.Forms.Label lblFitnessInf;
    }
}

