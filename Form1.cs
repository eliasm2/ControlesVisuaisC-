using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_Visuais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtTexto.Text, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void chkOp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOp.Checked == true)
                MessageBox.Show("Opção Marcada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Opção Desmarcada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelecionaItem_Click(object sender, EventArgs e)
        {
            if (lstItens.Text != "")
                MessageBox.Show("Selecionado o " + lstItens.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int n;

            string[] Cores = new string[10] { "Blue", "Cyan", "Green", "Black", "White", "Magenta", "Maroon", "Gray", "Orange", "Purple" };

            n = scrMudaCor.Value;

            pctImagem.BackColor = Color.FromName(Cores[n]);

        }

        private void cmbOpções_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionado o " + cboOpções.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdoOpcA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOpcA.Checked)
                MessageBox.Show("Marcada a " + rdoOpcA.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdoOpcB_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOpcB.Checked)
                MessageBox.Show("Marcada a " + rdoOpcB.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdoOpcC_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoOpcC.Checked)
                MessageBox.Show("Marcada a " + rdoOpcC.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            pbarContagem.Maximum = 1000000;
            pbarContagem.Value = 0;
            pbarContagem.Step = 1;

            for (int i = 1; i < 1000000; i++)
                pbarContagem.Value = i;

            MessageBox.Show("Acabou!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trkRolagem_Scroll(object sender, EventArgs e)
        {
            txtRolagem.Text = trkRolagem.Value.ToString();
        }

        private void lnkPUCMinas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkPUCMinas.LinkVisited = true;

            System.Diagnostics.Process.Start("http://www.pucminas.br");
        }

        private void calCalendário_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Data Selecionada: " + e.Start.ToShortDateString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BarraFerramentas_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Clicada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void opçãoA21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Clicada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opçãoA22ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Clicada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calCalendário_DateChanged(object sender, DateRangeEventArgs e)
        {

        }





    }
}
