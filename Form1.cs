using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetShop2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnServicos_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "PetShop", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            //minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); //limpa o painel
            panelCentral.Controls.Add(cliente);//adiciona o form no painel
            cliente.Show();//apareca

            //aplica a posicao do eixo X do botao ao panelSelecao

            panelSelecao.Top = btnCliente.Top;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();
            panelSelecao.Top = btnInicio.Top;
        }
    }
}


