using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TelaInicial Outroform = new TelaInicial();
            Outroform.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            conexao Outroform = new conexao();
            Outroform.ShowDialog();
            Console.WriteLine("Nova Tela");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // new Formnovo().Show();//
            Formnovo Outroform = new Formnovo();
            Outroform.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            new FrmCliente().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //habilitar multiline no elemento lá na view em suas propriedades permite deixar a
            //    box do tamanho que quiser
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
