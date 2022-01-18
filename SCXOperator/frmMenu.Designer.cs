
namespace SCXOperator
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSolucao = new System.Windows.Forms.Button();
            this.btnExperimentos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtAviso = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSolucao
            // 
            this.btnSolucao.Image = ((System.Drawing.Image)(resources.GetObject("btnSolucao.Image")));
            this.btnSolucao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolucao.Location = new System.Drawing.Point(12, 12);
            this.btnSolucao.Name = "btnSolucao";
            this.btnSolucao.Size = new System.Drawing.Size(208, 89);
            this.btnSolucao.TabIndex = 0;
            this.btnSolucao.Text = "Encontrar solução";
            this.btnSolucao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSolucao.UseVisualStyleBackColor = true;
            this.btnSolucao.Click += new System.EventHandler(this.btnSolucao_Click);
            // 
            // btnExperimentos
            // 
            this.btnExperimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnExperimentos.Image")));
            this.btnExperimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExperimentos.Location = new System.Drawing.Point(12, 120);
            this.btnExperimentos.Name = "btnExperimentos";
            this.btnExperimentos.Size = new System.Drawing.Size(208, 89);
            this.btnExperimentos.TabIndex = 1;
            this.btnExperimentos.Text = "Experimentos";
            this.btnExperimentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExperimentos.UseVisualStyleBackColor = true;
            this.btnExperimentos.Click += new System.EventHandler(this.btnExperimentos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 227);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(208, 89);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Fechar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtAviso
            // 
            this.txtAviso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAviso.Location = new System.Drawing.Point(236, 12);
            this.txtAviso.Name = "txtAviso";
            this.txtAviso.ReadOnly = true;
            this.txtAviso.Size = new System.Drawing.Size(642, 304);
            this.txtAviso.TabIndex = 3;
            this.txtAviso.Text = resources.GetString("txtAviso.Text");
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 332);
            this.Controls.Add(this.txtAviso);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExperimentos);
            this.Controls.Add(this.btnSolucao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu da aplicação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolucao;
        private System.Windows.Forms.Button btnExperimentos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RichTextBox txtAviso;
    }
}