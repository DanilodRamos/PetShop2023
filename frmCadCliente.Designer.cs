
namespace PetShop2023
{
    partial class frmCadCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cli_codigoLabel;
            System.Windows.Forms.Label cli_nomeLabel;
            System.Windows.Forms.Label cli_celularLabel;
            System.Windows.Forms.Label cli_emailLabel;
            System.Windows.Forms.Label cli_cpfLabel;
            System.Windows.Forms.Label cli_enderecoLabel;
            System.Windows.Forms.Label cli_fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.cli_codigoLabel1 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new PetShop2023.petshopDataSet();
            this.cli_nomeTextBox = new System.Windows.Forms.TextBox();
            this.cli_celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cli_emailTextBox = new System.Windows.Forms.TextBox();
            this.cli_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cli_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cli_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.clienteTableAdapter = new PetShop2023.petshopDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new PetShop2023.petshopDataSetTableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            cli_codigoLabel = new System.Windows.Forms.Label();
            cli_nomeLabel = new System.Windows.Forms.Label();
            cli_celularLabel = new System.Windows.Forms.Label();
            cli_emailLabel = new System.Windows.Forms.Label();
            cli_cpfLabel = new System.Windows.Forms.Label();
            cli_enderecoLabel = new System.Windows.Forms.Label();
            cli_fotoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cli_codigoLabel
            // 
            cli_codigoLabel.AutoSize = true;
            cli_codigoLabel.Location = new System.Drawing.Point(6, 61);
            cli_codigoLabel.Name = "cli_codigoLabel";
            cli_codigoLabel.Size = new System.Drawing.Size(79, 18);
            cli_codigoLabel.TabIndex = 0;
            cli_codigoLabel.Text = "cli codigo:";
            cli_codigoLabel.Click += new System.EventHandler(this.cli_codigoLabel_Click);
            // 
            // cli_nomeLabel
            // 
            cli_nomeLabel.AutoSize = true;
            cli_nomeLabel.Location = new System.Drawing.Point(6, 91);
            cli_nomeLabel.Name = "cli_nomeLabel";
            cli_nomeLabel.Size = new System.Drawing.Size(70, 18);
            cli_nomeLabel.TabIndex = 2;
            cli_nomeLabel.Text = "cli nome:";
            cli_nomeLabel.Click += new System.EventHandler(this.cli_nomeLabel_Click);
            // 
            // cli_celularLabel
            // 
            cli_celularLabel.AutoSize = true;
            cli_celularLabel.Location = new System.Drawing.Point(6, 129);
            cli_celularLabel.Name = "cli_celularLabel";
            cli_celularLabel.Size = new System.Drawing.Size(76, 18);
            cli_celularLabel.TabIndex = 4;
            cli_celularLabel.Text = "cli celular:";
            cli_celularLabel.Click += new System.EventHandler(this.cli_celularLabel_Click);
            // 
            // cli_emailLabel
            // 
            cli_emailLabel.AutoSize = true;
            cli_emailLabel.Location = new System.Drawing.Point(6, 167);
            cli_emailLabel.Name = "cli_emailLabel";
            cli_emailLabel.Size = new System.Drawing.Size(69, 18);
            cli_emailLabel.TabIndex = 6;
            cli_emailLabel.Text = "cli email:";
            cli_emailLabel.Click += new System.EventHandler(this.cli_emailLabel_Click);
            // 
            // cli_cpfLabel
            // 
            cli_cpfLabel.AutoSize = true;
            cli_cpfLabel.Location = new System.Drawing.Point(6, 205);
            cli_cpfLabel.Name = "cli_cpfLabel";
            cli_cpfLabel.Size = new System.Drawing.Size(52, 18);
            cli_cpfLabel.TabIndex = 8;
            cli_cpfLabel.Text = "cli cpf:";
            cli_cpfLabel.Click += new System.EventHandler(this.cli_cpfLabel_Click);
            // 
            // cli_enderecoLabel
            // 
            cli_enderecoLabel.AutoSize = true;
            cli_enderecoLabel.Location = new System.Drawing.Point(6, 243);
            cli_enderecoLabel.Name = "cli_enderecoLabel";
            cli_enderecoLabel.Size = new System.Drawing.Size(97, 18);
            cli_enderecoLabel.TabIndex = 10;
            cli_enderecoLabel.Text = "cli endereco:";
            cli_enderecoLabel.Click += new System.EventHandler(this.cli_enderecoLabel_Click);
            // 
            // cli_fotoLabel
            // 
            cli_fotoLabel.AutoSize = true;
            cli_fotoLabel.Location = new System.Drawing.Point(6, 278);
            cli_fotoLabel.Name = "cli_fotoLabel";
            cli_fotoLabel.Size = new System.Drawing.Size(57, 18);
            cli_fotoLabel.TabIndex = 12;
            cli_fotoLabel.Text = "cli foto:";
            cli_fotoLabel.Click += new System.EventHandler(this.cli_fotoLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(cli_codigoLabel);
            this.groupBox1.Controls.Add(this.cli_codigoLabel1);
            this.groupBox1.Controls.Add(cli_nomeLabel);
            this.groupBox1.Controls.Add(this.cli_nomeTextBox);
            this.groupBox1.Controls.Add(cli_celularLabel);
            this.groupBox1.Controls.Add(this.cli_celularMaskedTextBox);
            this.groupBox1.Controls.Add(cli_emailLabel);
            this.groupBox1.Controls.Add(this.cli_emailTextBox);
            this.groupBox1.Controls.Add(cli_cpfLabel);
            this.groupBox1.Controls.Add(this.cli_cpfMaskedTextBox);
            this.groupBox1.Controls.Add(cli_enderecoLabel);
            this.groupBox1.Controls.Add(this.cli_enderecoTextBox);
            this.groupBox1.Controls.Add(cli_fotoLabel);
            this.groupBox1.Controls.Add(this.cli_fotoPictureBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFoto
            // 
            this.btnFoto.BackgroundImage = global::PetShop2023.Properties.Resources.adicionar_usuario1;
            this.btnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Location = new System.Drawing.Point(289, 278);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(47, 33);
            this.btnFoto.TabIndex = 14;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // cli_codigoLabel1
            // 
            this.cli_codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cli_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_codigo", true));
            this.cli_codigoLabel1.Location = new System.Drawing.Point(142, 61);
            this.cli_codigoLabel1.Name = "cli_codigoLabel1";
            this.cli_codigoLabel1.Size = new System.Drawing.Size(123, 26);
            this.cli_codigoLabel1.TabIndex = 1;
            this.cli_codigoLabel1.Text = "label1";
            this.cli_codigoLabel1.Click += new System.EventHandler(this.cli_codigoLabel1_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cli_nomeTextBox
            // 
            this.cli_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_nome", true));
            this.cli_nomeTextBox.Location = new System.Drawing.Point(142, 88);
            this.cli_nomeTextBox.Name = "cli_nomeTextBox";
            this.cli_nomeTextBox.Size = new System.Drawing.Size(417, 26);
            this.cli_nomeTextBox.TabIndex = 3;
            this.cli_nomeTextBox.TextChanged += new System.EventHandler(this.cli_nomeTextBox_TextChanged);
            // 
            // cli_celularMaskedTextBox
            // 
            this.cli_celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_celular", true));
            this.cli_celularMaskedTextBox.Location = new System.Drawing.Point(142, 126);
            this.cli_celularMaskedTextBox.Mask = "(99) 99999-9999";
            this.cli_celularMaskedTextBox.Name = "cli_celularMaskedTextBox";
            this.cli_celularMaskedTextBox.Size = new System.Drawing.Size(182, 26);
            this.cli_celularMaskedTextBox.TabIndex = 5;
            this.cli_celularMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cli_celularMaskedTextBox_MaskInputRejected);
            // 
            // cli_emailTextBox
            // 
            this.cli_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_email", true));
            this.cli_emailTextBox.Location = new System.Drawing.Point(142, 164);
            this.cli_emailTextBox.Name = "cli_emailTextBox";
            this.cli_emailTextBox.Size = new System.Drawing.Size(417, 26);
            this.cli_emailTextBox.TabIndex = 7;
            this.cli_emailTextBox.TextChanged += new System.EventHandler(this.cli_emailTextBox_TextChanged);
            // 
            // cli_cpfMaskedTextBox
            // 
            this.cli_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_cpf", true));
            this.cli_cpfMaskedTextBox.Location = new System.Drawing.Point(142, 202);
            this.cli_cpfMaskedTextBox.Mask = "999.999.999-99";
            this.cli_cpfMaskedTextBox.Name = "cli_cpfMaskedTextBox";
            this.cli_cpfMaskedTextBox.Size = new System.Drawing.Size(332, 26);
            this.cli_cpfMaskedTextBox.TabIndex = 9;
            this.cli_cpfMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cli_cpfMaskedTextBox_MaskInputRejected);
            // 
            // cli_enderecoTextBox
            // 
            this.cli_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cli_endereco", true));
            this.cli_enderecoTextBox.Location = new System.Drawing.Point(142, 240);
            this.cli_enderecoTextBox.Name = "cli_enderecoTextBox";
            this.cli_enderecoTextBox.Size = new System.Drawing.Size(417, 26);
            this.cli_enderecoTextBox.TabIndex = 11;
            this.cli_enderecoTextBox.TextChanged += new System.EventHandler(this.cli_enderecoTextBox_TextChanged);
            // 
            // cli_fotoPictureBox
            // 
            this.cli_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "cli_foto", true));
            this.cli_fotoPictureBox.Location = new System.Drawing.Point(142, 278);
            this.cli_fotoPictureBox.Name = "cli_fotoPictureBox";
            this.cli_fotoPictureBox.Size = new System.Drawing.Size(141, 118);
            this.cli_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cli_fotoPictureBox.TabIndex = 13;
            this.cli_fotoPictureBox.TabStop = false;
            this.cli_fotoPictureBox.Click += new System.EventHandler(this.cli_fotoPictureBox_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PetShop2023.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = null;
            this.clienteBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clienteBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar,
            this.toolStripButton1});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(628, 43);
            this.clienteBindingNavigator.TabIndex = 1;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            this.clienteBindingNavigator.RefreshItems += new System.EventHandler(this.clienteBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 40);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::PetShop2023.Properties.Resources.adicionar_usuario;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::PetShop2023.Properties.Resources.trash;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 40);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(40, 40);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::PetShop2023.Properties.Resources.reject;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 40);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Image = global::PetShop2023.Properties.Resources.editing;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 40);
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Escolha a Foto do Cliente";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(628, 494);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadCliente";
            this.Text = "frmCadCliente";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private petshopDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cli_codigoLabel1;
        private System.Windows.Forms.TextBox cli_nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cli_celularMaskedTextBox;
        private System.Windows.Forms.TextBox cli_emailTextBox;
        private System.Windows.Forms.MaskedTextBox cli_cpfMaskedTextBox;
        private System.Windows.Forms.TextBox cli_enderecoTextBox;
        private System.Windows.Forms.PictureBox cli_fotoPictureBox;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}