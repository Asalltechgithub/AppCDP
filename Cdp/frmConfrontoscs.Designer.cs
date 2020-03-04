namespace Cdp
{
    partial class frmConfrontoscs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfrontoscs));
            this.cbEventoCard = new System.Windows.Forms.ComboBox();
            this.grupoCard = new System.Windows.Forms.GroupBox();
            this.cbDescrição = new System.Windows.Forms.ComboBox();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.btnAbrirTelao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.FotoVermelho = new System.Windows.Forms.PictureBox();
            this.cbVermelho = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FotoAzul = new System.Windows.Forms.PictureBox();
            this.cbAzul = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbCategoriaCard = new System.Windows.Forms.ComboBox();
            this.CbVencedor = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnremoverlutaCard = new System.Windows.Forms.Button();
            this.btnEditarCard = new System.Windows.Forms.Button();
            this.btnSaveCard = new System.Windows.Forms.Button();
            this.dgvCard = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbEmpate = new System.Windows.Forms.CheckBox();
            this.grupoCard.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoVermelho)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCard)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEventoCard
            // 
            this.cbEventoCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventoCard.FormattingEnabled = true;
            this.cbEventoCard.Location = new System.Drawing.Point(3, 266);
            this.cbEventoCard.Name = "cbEventoCard";
            this.cbEventoCard.Size = new System.Drawing.Size(121, 21);
            this.cbEventoCard.TabIndex = 4;
            this.cbEventoCard.SelectedIndexChanged += new System.EventHandler(this.CbEventoCard_SelectedIndexChanged);
            // 
            // grupoCard
            // 
            this.grupoCard.BackgroundImage = global::Cdp.Properties.Resources._1;
            this.grupoCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grupoCard.Controls.Add(this.cbDescrição);
            this.grupoCard.Controls.Add(this.BtnResultado);
            this.grupoCard.Controls.Add(this.btnAbrirTelao);
            this.grupoCard.Controls.Add(this.panel2);
            this.grupoCard.Controls.Add(this.panel1);
            this.grupoCard.Location = new System.Drawing.Point(16, 308);
            this.grupoCard.Name = "grupoCard";
            this.grupoCard.Size = new System.Drawing.Size(729, 349);
            this.grupoCard.TabIndex = 4;
            this.grupoCard.TabStop = false;
            this.grupoCard.Text = "Card";
            // 
            // cbDescrição
            // 
            this.cbDescrição.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescrição.FormattingEnabled = true;
            this.cbDescrição.Items.AddRange(new object[] {
            "Decisão Dividida",
            "Decisão Unamine",
            "TKO",
            "KO"});
            this.cbDescrição.Location = new System.Drawing.Point(303, 138);
            this.cbDescrição.Name = "cbDescrição";
            this.cbDescrição.Size = new System.Drawing.Size(121, 21);
            this.cbDescrição.TabIndex = 78;
            // 
            // BtnResultado
            // 
            this.BtnResultado.BackColor = System.Drawing.Color.Transparent;
            this.BtnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResultado.Font = new System.Drawing.Font("MMA champ", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnResultado.Location = new System.Drawing.Point(234, 89);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(273, 43);
            this.BtnResultado.TabIndex = 77;
            this.BtnResultado.Text = "Enviar Resultado";
            this.BtnResultado.UseVisualStyleBackColor = false;
            this.BtnResultado.Click += new System.EventHandler(this.BtnResultado_Click);
            // 
            // btnAbrirTelao
            // 
            this.btnAbrirTelao.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirTelao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirTelao.Font = new System.Drawing.Font("MMA champ", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirTelao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirTelao.Location = new System.Drawing.Point(234, 19);
            this.btnAbrirTelao.Name = "btnAbrirTelao";
            this.btnAbrirTelao.Size = new System.Drawing.Size(273, 43);
            this.btnAbrirTelao.TabIndex = 5;
            this.btnAbrirTelao.Text = "Abrir Painel";
            this.btnAbrirTelao.UseVisualStyleBackColor = false;
            this.btnAbrirTelao.Click += new System.EventHandler(this.BtnAbrirTelao_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.FotoVermelho);
            this.panel2.Controls.Add(this.cbVermelho);
            this.panel2.Location = new System.Drawing.Point(523, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 324);
            this.panel2.TabIndex = 76;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 24);
            this.label16.TabIndex = 67;
            this.label16.Text = "Corner Vermelho";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FotoVermelho
            // 
            this.FotoVermelho.Image = global::Cdp.Properties.Resources.img_pic;
            this.FotoVermelho.InitialImage = ((System.Drawing.Image)(resources.GetObject("FotoVermelho.InitialImage")));
            this.FotoVermelho.Location = new System.Drawing.Point(-2, 34);
            this.FotoVermelho.Name = "FotoVermelho";
            this.FotoVermelho.Size = new System.Drawing.Size(200, 235);
            this.FotoVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoVermelho.TabIndex = 74;
            this.FotoVermelho.TabStop = false;
            // 
            // cbVermelho
            // 
            this.cbVermelho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVermelho.Enabled = false;
            this.cbVermelho.FormattingEnabled = true;
            this.cbVermelho.Location = new System.Drawing.Point(37, 284);
            this.cbVermelho.Name = "cbVermelho";
            this.cbVermelho.Size = new System.Drawing.Size(121, 21);
            this.cbVermelho.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.FotoAzul);
            this.panel1.Controls.Add(this.cbAzul);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 324);
            this.panel1.TabIndex = 76;
            // 
            // FotoAzul
            // 
            this.FotoAzul.Image = global::Cdp.Properties.Resources.img_pic;
            this.FotoAzul.InitialImage = ((System.Drawing.Image)(resources.GetObject("FotoAzul.InitialImage")));
            this.FotoAzul.Location = new System.Drawing.Point(3, 34);
            this.FotoAzul.Name = "FotoAzul";
            this.FotoAzul.Size = new System.Drawing.Size(195, 235);
            this.FotoAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoAzul.TabIndex = 75;
            this.FotoAzul.TabStop = false;
            // 
            // cbAzul
            // 
            this.cbAzul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAzul.Enabled = false;
            this.cbAzul.FormattingEnabled = true;
            this.cbAzul.Location = new System.Drawing.Point(38, 284);
            this.cbAzul.Name = "cbAzul";
            this.cbAzul.Size = new System.Drawing.Size(121, 21);
            this.cbAzul.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DodgerBlue;
            this.label15.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 24);
            this.label15.TabIndex = 66;
            this.label15.Text = "Corner Azul";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("MMA champ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Goldenrod;
            this.label17.Location = new System.Drawing.Point(334, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 19);
            this.label17.TabIndex = 69;
            this.label17.Text = "Categoria";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbCategoriaCard
            // 
            this.cbCategoriaCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaCard.Enabled = false;
            this.cbCategoriaCard.FormattingEnabled = true;
            this.cbCategoriaCard.Location = new System.Drawing.Point(328, 281);
            this.cbCategoriaCard.Name = "cbCategoriaCard";
            this.cbCategoriaCard.Size = new System.Drawing.Size(121, 21);
            this.cbCategoriaCard.TabIndex = 68;
            // 
            // CbVencedor
            // 
            this.CbVencedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbVencedor.FormattingEnabled = true;
            this.CbVencedor.Location = new System.Drawing.Point(637, 266);
            this.CbVencedor.Name = "CbVencedor";
            this.CbVencedor.Size = new System.Drawing.Size(121, 21);
            this.CbVencedor.TabIndex = 73;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("MMA champ", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnNovo.Location = new System.Drawing.Point(117, 177);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(127, 63);
            this.btnNovo.TabIndex = 77;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click_1);
            // 
            // btnremoverlutaCard
            // 
            this.btnremoverlutaCard.BackColor = System.Drawing.Color.Transparent;
            this.btnremoverlutaCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnremoverlutaCard.BackgroundImage")));
            this.btnremoverlutaCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnremoverlutaCard.Enabled = false;
            this.btnremoverlutaCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremoverlutaCard.Font = new System.Drawing.Font("MMA champ", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoverlutaCard.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnremoverlutaCard.Location = new System.Drawing.Point(520, 177);
            this.btnremoverlutaCard.Name = "btnremoverlutaCard";
            this.btnremoverlutaCard.Size = new System.Drawing.Size(127, 63);
            this.btnremoverlutaCard.TabIndex = 76;
            this.btnremoverlutaCard.Text = "Remover";
            this.btnremoverlutaCard.UseVisualStyleBackColor = false;
            this.btnremoverlutaCard.Click += new System.EventHandler(this.BtnremoverlutaCard_Click_1);
            // 
            // btnEditarCard
            // 
            this.btnEditarCard.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarCard.BackgroundImage")));
            this.btnEditarCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCard.Font = new System.Drawing.Font("MMA champ", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCard.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnEditarCard.Location = new System.Drawing.Point(387, 177);
            this.btnEditarCard.Name = "btnEditarCard";
            this.btnEditarCard.Size = new System.Drawing.Size(127, 63);
            this.btnEditarCard.TabIndex = 75;
            this.btnEditarCard.Text = "Editar";
            this.btnEditarCard.UseVisualStyleBackColor = false;
            this.btnEditarCard.Click += new System.EventHandler(this.BtnEditarCard_Click_1);
            // 
            // btnSaveCard
            // 
            this.btnSaveCard.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCard.BackgroundImage")));
            this.btnSaveCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveCard.Enabled = false;
            this.btnSaveCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCard.Font = new System.Drawing.Font("MMA champ", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCard.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSaveCard.Location = new System.Drawing.Point(250, 177);
            this.btnSaveCard.Name = "btnSaveCard";
            this.btnSaveCard.Size = new System.Drawing.Size(127, 63);
            this.btnSaveCard.TabIndex = 74;
            this.btnSaveCard.Text = "Incluir";
            this.btnSaveCard.UseVisualStyleBackColor = false;
            this.btnSaveCard.Click += new System.EventHandler(this.BtnSaveCard_Click_1);
            // 
            // dgvCard
            // 
            this.dgvCard.AllowUserToAddRows = false;
            this.dgvCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCard.Location = new System.Drawing.Point(63, 15);
            this.dgvCard.Name = "dgvCard";
            this.dgvCard.ReadOnly = true;
            this.dgvCard.RowHeadersVisible = false;
            this.dgvCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCard.Size = new System.Drawing.Size(666, 156);
            this.dgvCard.TabIndex = 73;
            this.dgvCard.SelectionChanged += new System.EventHandler(this.DgvCard_SelectionChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MMA champ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(3, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Evento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MMA champ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(653, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Vencedor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckbEmpate
            // 
            this.ckbEmpate.AutoSize = true;
            this.ckbEmpate.BackColor = System.Drawing.Color.Transparent;
            this.ckbEmpate.Font = new System.Drawing.Font("MMA champ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEmpate.ForeColor = System.Drawing.Color.Goldenrod;
            this.ckbEmpate.Location = new System.Drawing.Point(520, 266);
            this.ckbEmpate.Name = "ckbEmpate";
            this.ckbEmpate.Size = new System.Drawing.Size(84, 20);
            this.ckbEmpate.TabIndex = 80;
            this.ckbEmpate.Text = "Empate";
            this.ckbEmpate.UseVisualStyleBackColor = false;
            // 
            // frmConfrontoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::Cdp.Properties.Resources.Background_gloves;
            this.Controls.Add(this.ckbEmpate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnremoverlutaCard);
            this.Controls.Add(this.btnEditarCard);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CbVencedor);
            this.Controls.Add(this.cbCategoriaCard);
            this.Controls.Add(this.btnSaveCard);
            this.Controls.Add(this.dgvCard);
            this.Controls.Add(this.cbEventoCard);
            this.Controls.Add(this.grupoCard);
            this.Name = "frmConfrontoscs";
            this.Size = new System.Drawing.Size(761, 660);
            this.Load += new System.EventHandler(this.FrmConfrontoscs_Load);
            this.grupoCard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoVermelho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoCard;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbCategoriaCard;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbEventoCard;
        private System.Windows.Forms.ComboBox cbVermelho;
        private System.Windows.Forms.ComboBox cbAzul;
        private System.Windows.Forms.Button btnAbrirTelao;
        private System.Windows.Forms.ComboBox CbVencedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox FotoVermelho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox FotoAzul;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnremoverlutaCard;
        private System.Windows.Forms.Button btnEditarCard;
        private System.Windows.Forms.Button btnSaveCard;
        private System.Windows.Forms.DataGridView dgvCard;
        private System.Windows.Forms.Button BtnResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbEmpate;
        private System.Windows.Forms.ComboBox cbDescrição;
    }
}
