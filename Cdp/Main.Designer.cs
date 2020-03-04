namespace Cdp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnEquipes = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnConfrontos = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnAtleta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainControl1 = new Cdp.MainControl1();
            this.frmConfrontoscs1 = new Cdp.frmConfrontoscs();
            this.frmEvento1 = new Cdp.frmEvento();
            this.frmAtleta1 = new Cdp.frmAtleta();
            this.ranking1 = new Cdp.Ranking();
            this.frmEquipe1 = new Cdp.frmEquipe();
            this.sidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.Controls.Add(this.btnInicio);
            this.sidePanel.Controls.Add(this.btnRanking);
            this.sidePanel.Controls.Add(this.btnEquipes);
            this.sidePanel.Controls.Add(this.btnCategoria);
            this.sidePanel.Controls.Add(this.btnConfrontos);
            this.sidePanel.Controls.Add(this.btnEventos);
            this.sidePanel.Controls.Add(this.btnAtleta);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(156, 711);
            this.sidePanel.TabIndex = 2;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("MingLiU-ExtB", 13F);
            this.btnInicio.Location = new System.Drawing.Point(0, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(156, 43);
            this.btnInicio.TabIndex = 6;
            this.btnInicio.Text = "Administrativo";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.BtnAdm_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.Location = new System.Drawing.Point(0, 49);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(156, 43);
            this.btnRanking.TabIndex = 5;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.BtnRanking_Click);
            // 
            // btnEquipes
            // 
            this.btnEquipes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEquipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipes.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipes.Location = new System.Drawing.Point(0, 92);
            this.btnEquipes.Name = "btnEquipes";
            this.btnEquipes.Size = new System.Drawing.Size(156, 43);
            this.btnEquipes.TabIndex = 4;
            this.btnEquipes.Text = "Equipes";
            this.btnEquipes.UseVisualStyleBackColor = true;
            this.btnEquipes.Click += new System.EventHandler(this.BtnEquipes_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(0, 135);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(156, 43);
            this.btnCategoria.TabIndex = 3;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // btnConfrontos
            // 
            this.btnConfrontos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfrontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfrontos.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfrontos.Location = new System.Drawing.Point(0, 178);
            this.btnConfrontos.Name = "btnConfrontos";
            this.btnConfrontos.Size = new System.Drawing.Size(156, 43);
            this.btnConfrontos.TabIndex = 2;
            this.btnConfrontos.Text = "Confrontos";
            this.btnConfrontos.UseVisualStyleBackColor = true;
            this.btnConfrontos.Click += new System.EventHandler(this.BtnConfrontos_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Location = new System.Drawing.Point(0, 221);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(156, 43);
            this.btnEventos.TabIndex = 1;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.BtnEventos_Click);
            // 
            // btnAtleta
            // 
            this.btnAtleta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtleta.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtleta.Location = new System.Drawing.Point(0, 264);
            this.btnAtleta.Name = "btnAtleta";
            this.btnAtleta.Size = new System.Drawing.Size(156, 43);
            this.btnAtleta.TabIndex = 0;
            this.btnAtleta.Text = "Atleta";
            this.btnAtleta.UseVisualStyleBackColor = true;
            this.btnAtleta.Click += new System.EventHandler(this.BtnAtleta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 49);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(685, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 27);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::Cdp.Properties.Resources.download;
            this.btnclose.Location = new System.Drawing.Point(746, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(31, 27);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 1;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cdp.Properties.Resources.maximize_63_618164;
            this.pictureBox2.Location = new System.Drawing.Point(718, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // mainControl1
            // 
            this.mainControl1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mainControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainControl1.BackgroundImage")));
            this.mainControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainControl1.Location = new System.Drawing.Point(156, 48);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(791, 663);
            this.mainControl1.TabIndex = 6;
            // 
            // frmConfrontoscs1
            // 
            this.frmConfrontoscs1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.frmConfrontoscs1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmConfrontoscs1.BackgroundImage")));
            this.frmConfrontoscs1.Location = new System.Drawing.Point(156, 48);
            this.frmConfrontoscs1.Name = "frmConfrontoscs1";
            this.frmConfrontoscs1.Size = new System.Drawing.Size(791, 660);
            this.frmConfrontoscs1.TabIndex = 5;
            // 
            // frmEvento1
            // 
            this.frmEvento1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.frmEvento1.Location = new System.Drawing.Point(156, 48);
            this.frmEvento1.Name = "frmEvento1";
            this.frmEvento1.Size = new System.Drawing.Size(791, 660);
            this.frmEvento1.TabIndex = 4;
            // 
            // frmAtleta1
            // 
            this.frmAtleta1.BackColor = System.Drawing.Color.RoyalBlue;
            this.frmAtleta1.Location = new System.Drawing.Point(156, 47);
            this.frmAtleta1.Name = "frmAtleta1";
            this.frmAtleta1.Size = new System.Drawing.Size(791, 664);
            this.frmAtleta1.TabIndex = 3;
            // 
            // ranking1
            // 
            this.ranking1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ranking1.Location = new System.Drawing.Point(156, 48);
            this.ranking1.Name = "ranking1";
            this.ranking1.Size = new System.Drawing.Size(791, 660);
            this.ranking1.TabIndex = 7;
            // 
            // frmEquipe1
            // 
            this.frmEquipe1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.frmEquipe1.Location = new System.Drawing.Point(156, 47);
            this.frmEquipe1.Name = "frmEquipe1";
            this.frmEquipe1.Size = new System.Drawing.Size(791, 660);
            this.frmEquipe1.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::Cdp.Properties.Resources.Background_gloves;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 711);
            this.Controls.Add(this.frmEquipe1);
            this.Controls.Add(this.ranking1);
            this.Controls.Add(this.mainControl1);
            this.Controls.Add(this.frmConfrontoscs1);
            this.Controls.Add(this.frmEvento1);
            this.Controls.Add(this.frmAtleta1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove_1);
            this.sidePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnEquipes;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnConfrontos;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnAtleta;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInicio;
        private frmAtleta frmAtleta1;
        private frmEvento frmEvento1;
        private frmConfrontoscs frmConfrontoscs1;
        private MainControl1 mainControl1;
        private Ranking ranking1;
        private frmEquipe frmEquipe1;
    }
}