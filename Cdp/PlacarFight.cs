using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cdp
{
    public partial class PlacarFight : Form
    {
        DAL.clsDao dao = new DAL.clsDao();
        public PlacarFight()
        {
            InitializeComponent();
        }

        private void PlacarFight_Load(object sender, EventArgs e)
        {
            
            cbEventoPlacar.DataSource = dao.GetEventos();
            cbEventoPlacar.DisplayMember = "Nome";
            cbEventoPlacar.ValueMember = "Cod";

            CbConfrontosPlacar.DataSource = dao.GetConfrontosByEvento(Convert.ToInt32(cbEventoPlacar.SelectedValue));
            CbConfrontosPlacar.DisplayMember = "Cod Confronto";
            CbConfrontosPlacar.ValueMember = "Cod Confronto";
        }

       

        private void CbEventoPlacar_SelectedValueChanged(object sender, EventArgs e)
        {
            
           if (cbEventoPlacar.ValueMember == "")
            {

            }
           else
            {
                int ID = Convert.ToInt32(cbEventoPlacar.SelectedValue);
                CbConfrontosPlacar.DataSource = dao.GetConfrontosByEvento(ID);
                CbConfrontosPlacar.DisplayMember = "Cod Confronto";
                CbConfrontosPlacar.ValueMember = "Cod Confronto";
            }

           
        }

        void recPic()
        {

            if (CbConfrontosPlacar.ValueMember == "")
            {

            }
            else
            {
                Domain.Domain.Confronto c = new Domain.Domain.Confronto();
                int ID = Convert.ToInt32(CbConfrontosPlacar.SelectedValue);
                c = dao.GetConfrontoPicAtleta(ID);
                lblCornerVermelho.Text = c.NomeVermelho;
                cornerAzul.Text = c.NomeAzul;
                fotovermelho.Image = DecodificarFoto(c.FotoVermelho);
                fotoAzul.Image = DecodificarFoto(c.FotoAzul);
                LogoEA.Image = DecodificarFoto(c.LogoEquipeA);
                LogoEV.Image = DecodificarFoto(c.LogoEquipeV);
                lblVitoria1.Text = c.VitoriaA.ToString();
                lblDerrota1.Text = c.DerrotaA.ToString();
                lblEmpate1.Text = c.EmpateA.ToString();
                lblVitoria2.Text = c.VitoriaV.ToString();
                lblDerrota2.Text = c.DerrotaV.ToString();
                lblEmpate2.Text = c.EmpateV.ToString();
                lblIdadeA.Text = c.IdadeA.ToString();
                lblAlturaA.Text = c.AlturaA.ToString();
                lblPesoA.Text = c.PesoA.ToString();
                lblIdadeV.Text = c.IdadeV.ToString();
                lblAlturaV.Text = c.AlturaV.ToString();
                lblPesoV.Text = c.PesoV.ToString();
                lblCategoria.Text = c.NomeCategoriadepeso;
                if (c.EquipeV== null)
                {
                    lblEquipeV.Text =string.Empty;
                    
                }
                else
                {
                    lblEquipeV.Text = c.EquipeV;
                   
                }
                if(c.EquipeA == null)
                {
                    lblEquipeA.Text = string.Empty;
                }
                else
                {
                    lblEquipeA.Text = c.EquipeA;
                }
                BandeiraA.Image = DecodificarFoto(c.BandeiraAzul);
                BandeiraV.Image = DecodificarFoto(c.BandeiraVermelho);
                
             
                

            }



        }

        private void CbConfrontosPlacar_SelectedIndexChanged(object sender, EventArgs e)
        {
            recPic();
        }
        public static Image DecodificarFoto(Byte[] fotosave)
        {
            MemoryStream ms;
            Image img = null;
            Image imagem = null;
            if (fotosave != null)
            {

              
                if (fotosave.Length > 0)
                {
                    ms = new MemoryStream(fotosave);

                    imagem = Image.FromStream(ms);


                    img = imagem;
                }
                

            }
            else
            {
                imagem = Properties.Resources.user_male_icon;
                img = imagem;
            }
            


            return img;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
