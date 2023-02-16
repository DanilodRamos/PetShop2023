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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try//tente
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)//captura o erro
            {

                MessageBox.Show("Ocorreu um erro, verefique os valores informados");
            }



        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.petshopDataSet.cliente);

        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clienteDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cli_celularMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cli_codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cli_celularLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_codigoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cli_emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cli_cpfLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_cpfMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cli_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cli_fotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try//tenta fazer isso
            {
                if (MessageBox.Show("Confirme a exlusão do registro", "PetShop2023",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();//removeu
                    clienteTableAdapter.Update(petshopDataSet.cliente);//salva
                }

            }
            catch (Exception)//captura o erro 
            {

                clienteTableAdapter.Fill(petshopDataSet.cliente);
                MessageBox.Show("Registro não pode ser excluido");
            }

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png;) | *.jpg; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
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
