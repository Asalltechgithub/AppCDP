using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace Cdp
{
    public partial class Ranking : UserControl
    {
        clsDao dao = new clsDao();
        Domain.Domain domain = new Domain.Domain();
        public Ranking()
        {
            InitializeComponent();
            Carregacombos();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            Carregacombos();
            CarregaControles();
        }

        void Carregacombos()
        {
            
            cbCampeao.DataSource = dao.GetAllAtleta(); 
            cbCampeao.ValueMember = "Cod";
            cbCampeao.DisplayMember = "SobreNome";
            cbPrimeiro.DataSource = dao.GetAllAtleta();
            cbPrimeiro.ValueMember = "Cod";
            cbPrimeiro.DisplayMember = "SobreNome";
            cbSegundo.DataSource = dao.GetAllAtleta();
            cbSegundo.ValueMember = "Cod";
            cbSegundo.DisplayMember = "SobreNome";
            cbTerceiro.DataSource = dao.GetAllAtleta();
            cbTerceiro.ValueMember = "Cod";
            cbTerceiro.DisplayMember = "SobreNome";
            cbQuarto.DataSource = dao.GetAllAtleta();
            cbQuarto.ValueMember = "Cod";
            cbQuarto.DisplayMember = "SobreNome";


        }
        void CarregaControles()
        {
            Domain.Domain.Ranking rkg = new Domain.Domain.Ranking();

            rkg = dao.getRanking();
           
            cbCampeao.SelectedValue = rkg.Campeao;
            cbPrimeiro.SelectedValue = rkg.primeiro;
            cbSegundo.SelectedValue = rkg.segundo;
            cbTerceiro.SelectedValue = rkg.terceiro;
            cbQuarto.SelectedValue = rkg.quarto;

        }

        private void CbCampeao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCampeao.ValueMember != "Cod" || cbCampeao.SelectedValue == null)
            {

            }
            else
            {
                Domain.Domain.Atleta a = new Domain.Domain.Atleta();
                int id = (int)cbCampeao.SelectedValue;
                a = dao.GetAtletabyID(id);
                Fotocampeao.Image = style.DecodificarFoto(a.foto);
                lblCampeao.Text = a.Nome + " " + a.SobreNome;
                //lblPrimeiro.Text = a.Nome + " " + a.SobreNome;
                //lblSegundo.Text = a.Nome + " " + a.SobreNome;
                //lblTerceiro.Text = a.Nome + " " + a.SobreNome;
                //lblQuarto.Text = a.Nome + " " + a.SobreNome;
            }
        }

        private void BtnSaveRanking_Click(object sender, EventArgs e)
        {
            Domain.Domain.Ranking rkg = new Domain.Domain.Ranking();
            rkg.Campeao =(int) cbCampeao.SelectedValue;
            rkg.primeiro = (int)cbPrimeiro.SelectedValue;
            rkg.segundo = (int)cbSegundo.SelectedValue;
            rkg.terceiro = (int)cbTerceiro.SelectedValue;
            rkg.quarto = (int)cbQuarto.SelectedValue;
            dao.UpdateRanking(rkg);
            MessageBox.Show("Ranking Atualizado com sucesso !!!");
        }

        private void CbPrimeiro_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbPrimeiro.ValueMember != "Cod" || cbCampeao.SelectedValue == null)
            {

            }
            else
            {
                Domain.Domain.Atleta a = new Domain.Domain.Atleta();
                int id = (int)cbPrimeiro.SelectedValue;
                a = dao.GetAtletabyID(id);
                fotoPrimeiro.Image = style.DecodificarFoto(a.foto);
                
                lblPrimeiro.Text = a.Nome + " " + a.SobreNome;
                
            }
        }

        private void CbSegundo_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbSegundo.ValueMember != "Cod" || cbCampeao.SelectedValue == null)
            {

            }
            else
            {
                Domain.Domain.Atleta a = new Domain.Domain.Atleta();
                int id = (int)cbSegundo.SelectedValue;
                a = dao.GetAtletabyID(id);
                fotoSegundo.Image = style.DecodificarFoto(a.foto);
                
                lblSegundo.Text = a.Nome + " " + a.SobreNome;
                
            }
        }

        private void CbTerceiro_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbTerceiro.ValueMember != "Cod" || cbCampeao.SelectedValue == null)
            {

            }
            else
            {
                Domain.Domain.Atleta a = new Domain.Domain.Atleta();
                int id = (int)cbTerceiro.SelectedValue;
                a = dao.GetAtletabyID(id);
                fotoTerceiro.Image = style.DecodificarFoto(a.foto);
               
                lblTerceiro.Text = a.Nome + " " + a.SobreNome;
                //lblQuarto.Text = a.Nome + " " + a.SobreNome;
            }
        }

        private void CbQuarto_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbQuarto.ValueMember != "Cod" || cbCampeao.SelectedValue == null)
            {

            }
            else
            {
                Domain.Domain.Atleta a = new Domain.Domain.Atleta();
                int id = (int)cbQuarto.SelectedValue;
                a = dao.GetAtletabyID(id);
                fotoQuarto.Image = style.DecodificarFoto(a.foto);
                
                 lblQuarto.Text = a.Nome + " " + a.SobreNome;
            }
        }
    }
}
