namespace Cdp
{
    partial class frmEvento
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
            this.grupoEvento = new System.Windows.Forms.GroupBox();
            this.btnDeleteEvento = new System.Windows.Forms.Button();
            this.BtnEditarEvento = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.btnNovoEvento = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveEvento = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.txtLocalEvento = new System.Windows.Forms.TextBox();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.grupoEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoEvento
            // 
            this.grupoEvento.Controls.Add(this.btnDeleteEvento);
            this.grupoEvento.Controls.Add(this.BtnEditarEvento);
            this.grupoEvento.Controls.Add(this.txtData);
            this.grupoEvento.Controls.Add(this.btnNovoEvento);
            this.grupoEvento.Controls.Add(this.label14);
            this.grupoEvento.Controls.Add(this.label13);
            this.grupoEvento.Controls.Add(this.btnSaveEvento);
            this.grupoEvento.Controls.Add(this.label12);
            this.grupoEvento.Controls.Add(this.dgvEventos);
            this.grupoEvento.Controls.Add(this.txtLocalEvento);
            this.grupoEvento.Controls.Add(this.txtNomeEvento);
            this.grupoEvento.Location = new System.Drawing.Point(41, 62);
            this.grupoEvento.Name = "grupoEvento";
            this.grupoEvento.Size = new System.Drawing.Size(682, 522);
            this.grupoEvento.TabIndex = 2;
            this.grupoEvento.TabStop = false;
            this.grupoEvento.Text = "Evento";
            // 
            // btnDeleteEvento
            // 
            this.btnDeleteEvento.Location = new System.Drawing.Point(405, 225);
            this.btnDeleteEvento.Name = "btnDeleteEvento";
            this.btnDeleteEvento.Size = new System.Drawing.Size(59, 32);
            this.btnDeleteEvento.TabIndex = 70;
            this.btnDeleteEvento.Text = "Deletar";
            this.btnDeleteEvento.UseVisualStyleBackColor = true;
            this.btnDeleteEvento.Click += new System.EventHandler(this.BtnDeleteEvento_Click);
            // 
            // BtnEditarEvento
            // 
            this.BtnEditarEvento.Location = new System.Drawing.Point(340, 225);
            this.BtnEditarEvento.Name = "BtnEditarEvento";
            this.BtnEditarEvento.Size = new System.Drawing.Size(59, 32);
            this.BtnEditarEvento.TabIndex = 3;
            this.BtnEditarEvento.Text = "Editar";
            this.BtnEditarEvento.UseVisualStyleBackColor = true;
            this.BtnEditarEvento.Click += new System.EventHandler(this.BtnEditarEvento_Click);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(254, 55);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(76, 20);
            this.txtData.TabIndex = 68;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // btnNovoEvento
            // 
            this.btnNovoEvento.Location = new System.Drawing.Point(210, 225);
            this.btnNovoEvento.Name = "btnNovoEvento";
            this.btnNovoEvento.Size = new System.Drawing.Size(59, 32);
            this.btnNovoEvento.TabIndex = 69;
            this.btnNovoEvento.Text = "Novo";
            this.btnNovoEvento.UseVisualStyleBackColor = true;
            this.btnNovoEvento.Click += new System.EventHandler(this.BtnNovoEvento_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(192, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 67;
            this.label14.Text = "Local";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(192, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 24);
            this.label13.TabIndex = 66;
            this.label13.Text = "Data";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveEvento
            // 
            this.btnSaveEvento.Location = new System.Drawing.Point(275, 225);
            this.btnSaveEvento.Name = "btnSaveEvento";
            this.btnSaveEvento.Size = new System.Drawing.Size(59, 32);
            this.btnSaveEvento.TabIndex = 5;
            this.btnSaveEvento.Text = "Salvar";
            this.btnSaveEvento.UseVisualStyleBackColor = true;
            this.btnSaveEvento.Click += new System.EventHandler(this.BtnSaveEvento_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(192, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 65;
            this.label12.Text = "Nome";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(178, 269);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEventos.RowHeadersVisible = false;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(301, 233);
            this.dgvEventos.TabIndex = 4;
            this.dgvEventos.SelectionChanged += new System.EventHandler(this.DgvEventos_SelectionChanged);
            // 
            // txtLocalEvento
            // 
            this.txtLocalEvento.Enabled = false;
            this.txtLocalEvento.Location = new System.Drawing.Point(254, 94);
            this.txtLocalEvento.Name = "txtLocalEvento";
            this.txtLocalEvento.Size = new System.Drawing.Size(157, 20);
            this.txtLocalEvento.TabIndex = 2;
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Enabled = false;
            this.txtNomeEvento.Location = new System.Drawing.Point(254, 19);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(76, 20);
            this.txtNomeEvento.TabIndex = 0;
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.grupoEvento);
            this.Name = "frmEvento";
            this.Size = new System.Drawing.Size(761, 660);
            this.Load += new System.EventHandler(this.FrmEvento_Load);
            this.grupoEvento.ResumeLayout(false);
            this.grupoEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grupoEvento;
        private System.Windows.Forms.Button btnDeleteEvento;
        private System.Windows.Forms.Button BtnEditarEvento;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Button btnNovoEvento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveEvento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TextBox txtLocalEvento;
        private System.Windows.Forms.TextBox txtNomeEvento;
    }
}
