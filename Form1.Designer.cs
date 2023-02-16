
namespace PetShop2023
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PainelLateral = new System.Windows.Forms.Panel();
            this.PainelTopo = new System.Windows.Forms.Panel();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnRaca = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.btnmin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.PainelTopo.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelLateral
            // 
            this.PainelLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.PainelLateral.Location = new System.Drawing.Point(1018, 0);
            this.PainelLateral.Name = "PainelLateral";
            this.PainelLateral.Size = new System.Drawing.Size(10, 526);
            this.PainelLateral.TabIndex = 0;
            // 
            // PainelTopo
            // 
            this.PainelTopo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PainelTopo.Controls.Add(this.btnmin);
            this.PainelTopo.Controls.Add(this.btnSair);
            this.PainelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelTopo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PainelTopo.Location = new System.Drawing.Point(0, 0);
            this.PainelTopo.Name = "PainelTopo";
            this.PainelTopo.Size = new System.Drawing.Size(1018, 33);
            this.PainelTopo.TabIndex = 1;
            this.PainelTopo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PanelLateral
            // 
            this.PanelLateral.Controls.Add(this.panelSelecao);
            this.PanelLateral.Controls.Add(this.btnInicio);
            this.PanelLateral.Controls.Add(this.btnAgendamento);
            this.PanelLateral.Controls.Add(this.btnServicos);
            this.PanelLateral.Controls.Add(this.btnAnimal);
            this.PanelLateral.Controls.Add(this.btnRaca);
            this.PanelLateral.Controls.Add(this.btnCliente);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 33);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(200, 493);
            this.PanelLateral.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicio.Location = new System.Drawing.Point(28, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(140, 55);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgendamento.Location = new System.Drawing.Point(0, 308);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(197, 55);
            this.btnAgendamento.TabIndex = 4;
            this.btnAgendamento.Text = "Agendamentos";
            this.btnAgendamento.UseVisualStyleBackColor = true;
            // 
            // btnServicos
            // 
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnServicos.Location = new System.Drawing.Point(28, 247);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(140, 55);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Servicos";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnimal.Location = new System.Drawing.Point(28, 186);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(140, 55);
            this.btnAnimal.TabIndex = 2;
            this.btnAnimal.Text = "Animais";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnRaca
            // 
            this.btnRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaca.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRaca.Location = new System.Drawing.Point(28, 125);
            this.btnRaca.Name = "btnRaca";
            this.btnRaca.Size = new System.Drawing.Size(140, 55);
            this.btnRaca.TabIndex = 1;
            this.btnRaca.Text = "Racas";
            this.btnRaca.UseVisualStyleBackColor = true;
            this.btnRaca.Click += new System.EventHandler(this.btnRaca_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCliente.Location = new System.Drawing.Point(28, 64);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(140, 55);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCentral.BackgroundImage = global::PetShop2023.Properties.Resources.baixados;
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(200, 33);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(818, 493);
            this.panelCentral.TabIndex = 4;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelSelecao.BackgroundImage = global::PetShop2023.Properties.Resources.baixados__1_;
            this.panelSelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSelecao.Location = new System.Drawing.Point(4, 6);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(18, 55);
            this.panelSelecao.TabIndex = 6;
            this.panelSelecao.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSelecao_Paint);
            // 
            // btnmin
            // 
            this.btnmin.BackgroundImage = global::PetShop2023.Properties.Resources.OIP__1_;
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Location = new System.Drawing.Point(932, 4);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(39, 27);
            this.btnmin.TabIndex = 3;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::PetShop2023.Properties.Resources.th;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(977, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 27);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1028, 526);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PainelTopo);
            this.Controls.Add(this.PainelLateral);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PainelTopo.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelLateral;
        private System.Windows.Forms.Panel PainelTopo;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnRaca;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelSelecao;
    }
}

