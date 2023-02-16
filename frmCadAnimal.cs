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
    public partial class frmCadAnimal : Form
    {
        public frmCadAnimal()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void frmCadAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.petshopDataSet.raca);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.petshopDataSet.animal);

        }

        private void ani_fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
