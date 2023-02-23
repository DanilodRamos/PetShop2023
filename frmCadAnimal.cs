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

        private void ani_sexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void animalBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try//tenta fazer isso
            {
                if (MessageBox.Show("Confirme a exlusão do registro", "PetShop2023",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();//removeu
                    animalTableAdapter.Update(petshopDataSet.animal);//salva
                }

            }
            catch (Exception)//captura o erro 
            {

                animalTableAdapter.Fill(petshopDataSet.animal);
                MessageBox.Show("Registro não pode ser excluido");
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try//tente
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                animalTableAdapter.Update(petshopDataSet.animal);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)//captura o erro
            {

                MessageBox.Show("Ocorreu um erro, verefique os valores informados");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           animalBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png;) | *.jpg; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar o arquivo de imagem",
                    "PetShop2023", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
