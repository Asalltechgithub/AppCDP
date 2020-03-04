
using Cdp.forms.Cruds;

using System;

using System.Windows.Forms;

namespace Cdp
{
    public partial class Main : Form
    {
        int X = 0;
        int Y = 0;

        public Main()
        {
            InitializeComponent();
            sidePanel.Height = btnInicio.Top;
            sidePanel.Top = btnInicio.Top;
            mainControl1.BringToFront();
            this.MouseDown += new MouseEventHandler(Main_MouseDown_1);
            this.MouseMove += new MouseEventHandler(Main_MouseMove_1);
        }
       
        private void Main_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Main_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void BtnAtleta_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnAtleta.Height;
            sidePanel.Top = btnAtleta.Top;
            frmAtleta1.BringToFront();


        }
       
       
        private void BtnEventos_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnEventos.Height;
            sidePanel.Top = btnEventos.Top;
            frmEvento1.BringToFront();
        }

        private void BtnConfrontos_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnConfrontos.Height;
            sidePanel.Top = btnConfrontos.Top;
            ;
            frmConfrontoscs1.BringToFront();

        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEquipes_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnEquipes.Height;
            sidePanel.Top = btnEquipes.Top;
            frmEquipe1.BringToFront();
        }

        private void BtnRanking_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRanking.Height;
            sidePanel.Top = btnRanking.Top;
            ranking1.BringToFront();
        }

        private void BtnAdm_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnInicio.Height;
            sidePanel.Top = btnInicio.Top;
            mainControl1.BringToFront();
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
                Application.Exit();
        }

       
    }
}
