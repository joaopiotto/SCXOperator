using System;
using System.Drawing;
using System.Windows.Forms;

namespace SCXOperator
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {

            InitializeComponent();

            txtAviso.Select(35, 39);
            txtAviso.SelectionFont = new Font(txtAviso.Font, FontStyle.Bold);

            txtAviso.Select(307, 93);
            txtAviso.SelectionFont = new Font(txtAviso.Font, FontStyle.Bold);

            txtAviso.Select(497, 39);
            txtAviso.SelectionFont = new Font(txtAviso.Font, FontStyle.Bold);

        }

        private void btnSolucao_Click(object sender, EventArgs e)
        {
            new frmCalculoPercurso().ShowDialog();
        }

        private void btnExperimentos_Click(object sender, EventArgs e)
        {
            new frmExperimentos().ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
