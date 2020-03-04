namespace Cdp
{
    partial class frmAtleta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbsf = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbEquipe = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.txtPesquisaAtleta = new System.Windows.Forms.TextBox();
            this.grupoAtleta = new System.Windows.Forms.GroupBox();
            this.Bandeira = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHistoricoAtleta = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVitorias = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncarregafoto = new System.Windows.Forms.Button();
            this.btnSaveAtleta = new System.Windows.Forms.PictureBox();
            this.fotoAtleta = new System.Windows.Forms.PictureBox();
            this.txtDerrotas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpates = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEquipe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPesquisaAtleta = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnNovo = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.CbPais = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.grupoAtleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bandeira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoAtleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveAtleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAtleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaAtleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnPesquisar.Location = new System.Drawing.Point(616, 552);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 20);
            this.btnPesquisar.TabIndex = 96;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // rbsf
            // 
            this.rbsf.AutoSize = true;
            this.rbsf.Location = new System.Drawing.Point(364, 450);
            this.rbsf.Name = "rbsf";
            this.rbsf.Size = new System.Drawing.Size(71, 17);
            this.rbsf.TabIndex = 95;
            this.rbsf.TabStop = true;
            this.rbsf.Text = "Sem Filtro";
            this.rbsf.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(293, 450);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 94;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbEquipe
            // 
            this.rbEquipe.AutoSize = true;
            this.rbEquipe.Location = new System.Drawing.Point(105, 450);
            this.rbEquipe.Name = "rbEquipe";
            this.rbEquipe.Size = new System.Drawing.Size(58, 17);
            this.rbEquipe.TabIndex = 93;
            this.rbEquipe.TabStop = true;
            this.rbEquipe.Text = "Equipe";
            this.rbEquipe.UseVisualStyleBackColor = true;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(202, 450);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(70, 17);
            this.rbCategoria.TabIndex = 92;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaAtleta
            // 
            this.txtPesquisaAtleta.Location = new System.Drawing.Point(582, 528);
            this.txtPesquisaAtleta.Name = "txtPesquisaAtleta";
            this.txtPesquisaAtleta.Size = new System.Drawing.Size(143, 20);
            this.txtPesquisaAtleta.TabIndex = 91;
            // 
            // grupoAtleta
            // 
            this.grupoAtleta.Controls.Add(this.label16);
            this.grupoAtleta.Controls.Add(this.label15);
            this.grupoAtleta.Controls.Add(this.txtCidade);
            this.grupoAtleta.Controls.Add(this.CbPais);
            this.grupoAtleta.Controls.Add(this.Bandeira);
            this.grupoAtleta.Controls.Add(this.label14);
            this.grupoAtleta.Controls.Add(this.label13);
            this.grupoAtleta.Controls.Add(this.label12);
            this.grupoAtleta.Controls.Add(this.txtAltura);
            this.grupoAtleta.Controls.Add(this.TxtIdade);
            this.grupoAtleta.Controls.Add(this.txtPeso);
            this.grupoAtleta.Controls.Add(this.label11);
            this.grupoAtleta.Controls.Add(this.label1);
            this.grupoAtleta.Controls.Add(this.dgvHistoricoAtleta);
            this.grupoAtleta.Controls.Add(this.txtNome);
            this.grupoAtleta.Controls.Add(this.txtSobreNome);
            this.grupoAtleta.Controls.Add(this.txtApelido);
            this.grupoAtleta.Controls.Add(this.label10);
            this.grupoAtleta.Controls.Add(this.cbCategoria);
            this.grupoAtleta.Controls.Add(this.label9);
            this.grupoAtleta.Controls.Add(this.txtVitorias);
            this.grupoAtleta.Controls.Add(this.label8);
            this.grupoAtleta.Controls.Add(this.btncarregafoto);
            this.grupoAtleta.Controls.Add(this.btnSaveAtleta);
            this.grupoAtleta.Controls.Add(this.fotoAtleta);
            this.grupoAtleta.Controls.Add(this.txtDerrotas);
            this.grupoAtleta.Controls.Add(this.label7);
            this.grupoAtleta.Controls.Add(this.txtEmpates);
            this.grupoAtleta.Controls.Add(this.label6);
            this.grupoAtleta.Controls.Add(this.txtModalidade);
            this.grupoAtleta.Controls.Add(this.label5);
            this.grupoAtleta.Controls.Add(this.cbEquipe);
            this.grupoAtleta.Controls.Add(this.label4);
            this.grupoAtleta.Controls.Add(this.cbSexo);
            this.grupoAtleta.Controls.Add(this.label3);
            this.grupoAtleta.Controls.Add(this.label2);
            this.grupoAtleta.Enabled = false;
            this.grupoAtleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAtleta.Location = new System.Drawing.Point(34, 18);
            this.grupoAtleta.Name = "grupoAtleta";
            this.grupoAtleta.Size = new System.Drawing.Size(718, 413);
            this.grupoAtleta.TabIndex = 90;
            this.grupoAtleta.TabStop = false;
            this.grupoAtleta.Text = "Dados do Atleta";
            // 
            // Bandeira
            // 
            this.Bandeira.Image = global::Cdp.Properties.Resources._148_1485366_flag_spot_icon_free_download_png_clipart_stick;
            this.Bandeira.Location = new System.Drawing.Point(582, 310);
            this.Bandeira.Name = "Bandeira";
            this.Bandeira.Size = new System.Drawing.Size(102, 66);
            this.Bandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bandeira.TabIndex = 95;
            this.Bandeira.TabStop = false;
            this.Bandeira.Click += new System.EventHandler(this.Bandeira_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(343, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 24);
            this.label14.TabIndex = 94;
            this.label14.Text = "Altura";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(447, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 24);
            this.label13.TabIndex = 93;
            this.label13.Text = "Idade";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(350, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 24);
            this.label12.TabIndex = 92;
            this.label12.Text = "Peso";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.Azure;
            this.txtAltura.Location = new System.Drawing.Point(341, 51);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(74, 20);
            this.txtAltura.TabIndex = 91;
            // 
            // TxtIdade
            // 
            this.TxtIdade.BackColor = System.Drawing.Color.Azure;
            this.TxtIdade.Location = new System.Drawing.Point(435, 109);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(74, 20);
            this.TxtIdade.TabIndex = 90;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.Azure;
            this.txtPeso.Location = new System.Drawing.Point(341, 109);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(74, 20);
            this.txtPeso.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(197, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 24);
            this.label11.TabIndex = 78;
            this.label11.Text = "Histórico de lutas";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvHistoricoAtleta
            // 
            this.dgvHistoricoAtleta.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoricoAtleta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHistoricoAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoAtleta.Location = new System.Drawing.Point(42, 329);
            this.dgvHistoricoAtleta.Name = "dgvHistoricoAtleta";
            this.dgvHistoricoAtleta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHistoricoAtleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoricoAtleta.Size = new System.Drawing.Size(517, 75);
            this.dgvHistoricoAtleta.TabIndex = 77;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Azure;
            this.txtNome.Location = new System.Drawing.Point(6, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 20);
            this.txtNome.TabIndex = 52;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.BackColor = System.Drawing.Color.Azure;
            this.txtSobreNome.Location = new System.Drawing.Point(157, 51);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(140, 20);
            this.txtSobreNome.TabIndex = 53;
            // 
            // txtApelido
            // 
            this.txtApelido.BackColor = System.Drawing.Color.Azure;
            this.txtApelido.Location = new System.Drawing.Point(6, 110);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(140, 20);
            this.txtApelido.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(378, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 24);
            this.label10.TabIndex = 73;
            this.label10.Text = "Empates";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Azure;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(303, 167);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(140, 21);
            this.cbCategoria.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(285, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 72;
            this.label9.Text = "Derrotas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtVitorias
            // 
            this.txtVitorias.Location = new System.Drawing.Point(209, 217);
            this.txtVitorias.Name = "txtVitorias";
            this.txtVitorias.Size = new System.Drawing.Size(51, 20);
            this.txtVitorias.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 71;
            this.label8.Text = "Vitorias";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btncarregafoto
            // 
            this.btncarregafoto.Location = new System.Drawing.Point(566, 256);
            this.btncarregafoto.Name = "btncarregafoto";
            this.btncarregafoto.Size = new System.Drawing.Size(103, 29);
            this.btncarregafoto.TabIndex = 88;
            this.btncarregafoto.Text = "Carrega Foto";
            this.btncarregafoto.UseVisualStyleBackColor = true;
            this.btncarregafoto.Click += new System.EventHandler(this.Btncarregafoto_Click);
            // 
            // btnSaveAtleta
            // 
            this.btnSaveAtleta.Image = global::Cdp.Properties.Resources.save_button_png_download_this_image_as_600;
            this.btnSaveAtleta.Location = new System.Drawing.Point(443, 291);
            this.btnSaveAtleta.Name = "btnSaveAtleta";
            this.btnSaveAtleta.Size = new System.Drawing.Size(74, 33);
            this.btnSaveAtleta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSaveAtleta.TabIndex = 63;
            this.btnSaveAtleta.TabStop = false;
            this.btnSaveAtleta.Click += new System.EventHandler(this.BtnSaveAtleta_Click);
            // 
            // fotoAtleta
            // 
            this.fotoAtleta.Image = global::Cdp.Properties.Resources.user_male_icon;
            this.fotoAtleta.Location = new System.Drawing.Point(515, 19);
            this.fotoAtleta.Name = "fotoAtleta";
            this.fotoAtleta.Size = new System.Drawing.Size(183, 231);
            this.fotoAtleta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoAtleta.TabIndex = 87;
            this.fotoAtleta.TabStop = false;
            // 
            // txtDerrotas
            // 
            this.txtDerrotas.Location = new System.Drawing.Point(301, 217);
            this.txtDerrotas.Name = "txtDerrotas";
            this.txtDerrotas.Size = new System.Drawing.Size(51, 20);
            this.txtDerrotas.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 70;
            this.label7.Text = "Sexo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmpates
            // 
            this.txtEmpates.Location = new System.Drawing.Point(392, 217);
            this.txtEmpates.Name = "txtEmpates";
            this.txtEmpates.Size = new System.Drawing.Size(51, 20);
            this.txtEmpates.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 69;
            this.label6.Text = "Equipe";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtModalidade
            // 
            this.txtModalidade.BackColor = System.Drawing.Color.Azure;
            this.txtModalidade.Location = new System.Drawing.Point(157, 110);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(140, 20);
            this.txtModalidade.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "Modalidade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbEquipe
            // 
            this.cbEquipe.BackColor = System.Drawing.Color.Azure;
            this.cbEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipe.FormattingEnabled = true;
            this.cbEquipe.Location = new System.Drawing.Point(6, 167);
            this.cbEquipe.Name = "cbEquipe";
            this.cbEquipe.Size = new System.Drawing.Size(140, 21);
            this.cbEquipe.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Categoria";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.Azure;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(157, 167);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(140, 21);
            this.cbSexo.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Apelido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Sobrenome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvPesquisaAtleta
            // 
            this.dgvPesquisaAtleta.AllowUserToAddRows = false;
            this.dgvPesquisaAtleta.AllowUserToOrderColumns = true;
            this.dgvPesquisaAtleta.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvPesquisaAtleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaAtleta.Location = new System.Drawing.Point(34, 473);
            this.dgvPesquisaAtleta.Name = "dgvPesquisaAtleta";
            this.dgvPesquisaAtleta.ReadOnly = true;
            this.dgvPesquisaAtleta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPesquisaAtleta.RowHeadersVisible = false;
            this.dgvPesquisaAtleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisaAtleta.Size = new System.Drawing.Size(517, 164);
            this.dgvPesquisaAtleta.TabIndex = 89;
            this.dgvPesquisaAtleta.SelectionChanged += new System.EventHandler(this.DgvPesquisaAtleta_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(572, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 99;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Cdp.Properties.Resources.button_new_1_512;
            this.btnNovo.Location = new System.Drawing.Point(657, 604);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(21, 30);
            this.btnNovo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNovo.TabIndex = 98;
            this.btnNovo.TabStop = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Cdp.Properties.Resources.edit_button_blue_hi;
            this.btnEdit.Location = new System.Drawing.Point(569, 604);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 33);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEdit.TabIndex = 97;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // CbPais
            // 
            this.CbPais.BackColor = System.Drawing.Color.Azure;
            this.CbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPais.FormattingEnabled = true;
            this.CbPais.Items.AddRange(new object[] {
            "BRASIL",
            "USA",
            "CHINA",
            "RUSSIA",
            "ALEMANHA",
            "ESPANHA",
            "ITÁLIA",
            "GRECIA",
            "MEXICO",
            "ARGENTINA",
            "CHILE",
            "HOLANDA",
            "CANADÁ",
            "JAPÃO"});
            this.CbPais.Location = new System.Drawing.Point(6, 216);
            this.CbPais.Name = "CbPais";
            this.CbPais.Size = new System.Drawing.Size(140, 21);
            this.CbPais.TabIndex = 96;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.Azure;
            this.txtCidade.Location = new System.Drawing.Point(6, 275);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(140, 20);
            this.txtCidade.TabIndex = 97;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 24);
            this.label15.TabIndex = 98;
            this.label15.Text = "Pais";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(41, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 24);
            this.label16.TabIndex = 99;
            this.label16.Text = "Cidade";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog2_FileOk);
            // 
            // frmAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.rbsf);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.rbEquipe);
            this.Controls.Add(this.rbCategoria);
            this.Controls.Add(this.txtPesquisaAtleta);
            this.Controls.Add(this.grupoAtleta);
            this.Controls.Add(this.dgvPesquisaAtleta);
            this.Name = "frmAtleta";
            this.Size = new System.Drawing.Size(761, 660);
            this.Load += new System.EventHandler(this.FrmAtleta_Load);
            this.grupoAtleta.ResumeLayout(false);
            this.grupoAtleta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bandeira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoAtleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveAtleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAtleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaAtleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnNovo;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rbsf;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbEquipe;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.TextBox txtPesquisaAtleta;
        private System.Windows.Forms.GroupBox grupoAtleta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHistoricoAtleta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtVitorias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnSaveAtleta;
        private System.Windows.Forms.MaskedTextBox txtDerrotas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtEmpates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEquipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPesquisaAtleta;
        private System.Windows.Forms.Button btncarregafoto;
        private System.Windows.Forms.PictureBox fotoAtleta;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.PictureBox Bandeira;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox CbPais;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
