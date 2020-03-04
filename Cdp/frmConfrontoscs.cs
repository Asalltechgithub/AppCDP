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
using static Domain.Domain;

namespace Cdp
{
    public partial class frmConfrontoscs : UserControl
    {
        clsDao dao = new clsDao();
        string caminhofoto = string.Empty;
        string Modo = "";
        string subModo = "InserirConfronto";
        public frmConfrontoscs()
        {
            InitializeComponent();
        }

        private void FrmConfrontoscs_Load(object sender, EventArgs e)
        {
            carregaCombos();
            cbEventoCard.DataSource = dao.GetEventos();
            cbEventoCard.ValueMember = "Cod";
            cbEventoCard.DisplayMember = "Nome";
            btnremoverlutaCard.Enabled = false;
        }
        void insertConfronto()
        {
            Domain.Domain.Confronto confronto = new Domain.Domain.Confronto();
            confronto.Categoria = (int)cbCategoriaCard.SelectedValue;
            confronto.CodEvento = (int)cbEventoCard.SelectedValue;
            confronto.cAzul = (int)cbAzul.SelectedValue;
            confronto.cVermelho = (int)cbVermelho.SelectedValue;
            confronto.Status = "Agendado";
            dao.InserirConfronto(confronto);
            dgvCard.Refresh();
            cbVermelho.Refresh();
            cbAzul.Refresh();
            cbCategoriaCard.Refresh();
            MessageBox.Show("Confronto inserido com sucesso");
            int Id = (int)cbEventoCard.SelectedValue;
            dgvCard.DataSource = dao.GetConfrontosByEvento(Id);
            cbVermelho.Enabled = false;
            cbAzul.Enabled = false;
            cbCategoriaCard.Enabled = false;
        }
        void EditarConfronto()
        {
            Domain.Domain.Confronto confronto = new Domain.Domain.Confronto();
            confronto.CodConfronto =(int)dgvCard.CurrentRow.Cells[5].Value;
            confronto.Categoria = (int)cbCategoriaCard.SelectedValue;
            confronto.CodEvento = (int)cbEventoCard.SelectedValue;
            confronto.cAzul = (int)cbAzul.SelectedValue;
            confronto.cVermelho = (int)cbVermelho.SelectedValue;
            dao.UpdateConfronto(confronto);
            carregaGrid();
            carregaCombos();
            cbVermelho.Enabled = true;
            cbAzul.Enabled = true;
            cbCategoriaCard.Enabled = true;
            Modo = "InserirConfronto";
            MessageBox.Show("Confronto Atualiazado com sucesso");
            int Id = (int)cbEventoCard.SelectedValue;
            dgvCard.DataSource = dao.GetConfrontosByEvento(Id);
            cbVermelho.Enabled = false;
            cbAzul.Enabled = false;
            cbCategoriaCard.Enabled = false;
        }
        void DeleteConfronto()
        {
            Domain.Domain.Confronto confronto = new Domain.Domain.Confronto();
            DialogResult confirm = MessageBox.Show("Deseja Excluir esse confronto ?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {

                confronto.CodConfronto = (int)dgvCard.CurrentRow.Cells[5].Value;

                dao.DeleteConfronto(confronto.CodConfronto);
                MessageBox.Show("Dados Deletados Com sucesso !");
                carregaGrid();
            }


        }
        void selectcat()
        {
            cbAzul.Enabled = true;
            cbVermelho.Enabled = true;


            int id = Convert.ToInt32(cbCategoriaCard.SelectedValue);

        }
        void carregaCombos()
        {
            cbCategoriaCard.DataSource = dao.GetAllCategoria();
            cbCategoriaCard.ValueMember = "cod";
            cbCategoriaCard.DisplayMember = "Nome";
            cbAzul.DataSource = dao.GetAllAtleta();
            cbAzul.ValueMember = "Cod";
            cbAzul.DisplayMember = "SobreNome";
            cbVermelho.DataSource = dao.GetAllAtleta();
            cbVermelho.ValueMember = "Cod";
            cbVermelho.DisplayMember = "SobreNome";




        }
        void carregaGrid()
        {
            int Id = (int)cbEventoCard.SelectedValue;
            dgvCard.DataSource = dao.GetConfrontosByEvento(Id);
            

        }

      
        private void CbEventoCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEventoCard.ValueMember == "")
            {

            }
            else
            {
                int Id = (int)cbEventoCard.SelectedValue;
                dgvCard.DataSource = dao.GetConfrontosByEvento(Id);
            }
            
        }

        

       

        void modobtnNovo()
        {
            Modo = "InserirConfronto";
            btnSaveCard.Enabled = true;
            cbVermelho.Enabled = true;
            cbAzul.Enabled = true;
            cbCategoriaCard.Enabled = true;
            btnremoverlutaCard.Enabled = false;
            btnEditarCard.Enabled = false;
            
        }
        void modobtnEditar()
        {

            Modo = "EditarConfronto";
            cbVermelho.Enabled = true;
            cbAzul.Enabled = true;
            cbCategoriaCard.Enabled = true;
            btnSaveCard.Enabled = true;
            btnremoverlutaCard.Enabled = false;
        }
        void modobtnCancelar()
        {
            Modo = "";
            cbVermelho.Enabled = false;
            cbAzul.Enabled = false;
            cbCategoriaCard.Enabled = false;
            btnSaveCard.Enabled = false;
        }
        void modobtnRemover()
        {
            Modo = "";
            cbVermelho.Enabled = false;
            cbAzul.Enabled = false;
            cbCategoriaCard.Enabled = false;
            btnSaveCard.Enabled = false;
            btnremoverlutaCard.Enabled = true;
        }

        private void BtnAbrirTelao_Click(object sender, EventArgs e)
        {
            PlacarFight f = new PlacarFight();
            f.Show();

        }

       private void carregacbVencedor()
        {
            Confronto c = new Confronto();

            List<Atleta> la = new List<Atleta>();

            Atleta a1 = new Atleta();

            a1.Cod = (int)cbVermelho.SelectedValue;
            a1.Nome = cbVermelho.Text;

            la.Add(a1);
            Atleta a2 = new Atleta();

            a2.Cod = (int)cbAzul.SelectedValue;
            a2.Nome = cbAzul.Text;
            la.Add(a2);

            CbVencedor.DataSource = la;
            CbVencedor.ValueMember = "Cod";
            CbVencedor.DisplayMember = "Nome";

        }

        private void DgvCard_SelectionChanged_1(object sender, EventArgs e)
        {
            
            modobtnRemover();
            int Id = (Int32)dgvCard.CurrentRow.Cells[0].Value;
            cbAzul.Text = (string)dgvCard.CurrentRow.Cells[4].Value;
            cbVermelho.Text = (string)dgvCard.CurrentRow.Cells[3].Value;
            cbCategoriaCard.Text = (string)dgvCard.CurrentRow.Cells[2].Value;
            Atleta aazul = new Atleta();
            Atleta aVermelho = new Atleta();
            Confronto c = new Confronto();
            int idA =(int)cbAzul.SelectedValue;
            int idV = (int)cbVermelho.SelectedValue;
            aazul = dao.GetAtletabyID(idA);
            aVermelho = dao.GetAtletabyID(idV);
            if(aazul.foto == null || aVermelho.foto == null)
            {
                FotoVermelho.Image = Properties.Resources.img_pic;
                FotoAzul.Image = Properties.Resources.img_pic;
            }
            else
            {
                FotoVermelho.Image = style.DecodificarFoto(aVermelho.foto);
                FotoAzul.Image = style.DecodificarFoto(aazul.foto);
            }
           
            carregacbVencedor();
            
            dgvCard.Refresh();
        }

        private void BtnNovo_Click_1(object sender, EventArgs e)
        {
            modobtnNovo();
        }

        private void BtnSaveCard_Click_1(object sender, EventArgs e)
        {
            if (Modo == "InserirConfronto")
            {
                if (cbAzul.SelectedValue == cbVermelho.SelectedValue)
                {
                    MessageBox.Show("Um atleta nao pode lutar contra ele mesmo escolha outro Atleta !!!");
                }
                else
                {
                    insertConfronto();
                }

            }
            if (Modo == "EditarConfronto")
            {
                EditarConfronto();
            }
        }

        private void BtnEditarCard_Click_1(object sender, EventArgs e)
        {
            modobtnEditar();
        }

        private void BtnremoverlutaCard_Click_1(object sender, EventArgs e)
        {
            DeleteConfronto();
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            if (ckbEmpate.Checked == true)
            {
                Confronto c = new Confronto();
                Atleta aV = new Atleta();
                Atleta aA = new Atleta();
                int NumE = 0;

                int idV = (int)cbVermelho.SelectedValue;
                aV = dao.GetAtletabyID(idV);
                int idA = (int)cbAzul.SelectedValue;
                aA = dao.GetAtletabyID(idA);

                aV.Empate++;
                aA.Empate++;

                dao.UpdateAtleta(aV);
                dao.UpdateAtleta(aA);
                int confrontoID =(int) dgvCard.CurrentRow.Cells[5].Value;
                c = dao.GetObjConfrontoById(confrontoID);
                c.Vencedor = 0;
                c.DescriResultado = cbDescrição.Text;
                c.Status = "Encerrado";
                dao.UpdateConfronto(c);
                MessageBox.Show(" Resultado envido com sucesso !!!");
            }
            else
            {


          
            if(CbVencedor.Text == cbAzul.Text)
            {
                Confronto c = new Confronto();

                Atleta aV = new Atleta();
                Atleta aA = new Atleta();
                int NumV = 0;
                int NumD = 0;
                
                int idV = (int)cbVermelho.SelectedValue;
                aV = dao.GetAtletabyID(idV);
                int idA = (int)cbAzul.SelectedValue;
                aA = dao.GetAtletabyID(idA);

                 aV.Derrota++ ;
                 aA.Vitoria++ ;
                    
                    dao.UpdateAtleta(aV);
                    dao.UpdateAtleta(aA);
                    int confrontoID = (int)dgvCard.CurrentRow.Cells[5].Value;
                    c = dao.GetObjConfrontoById(confrontoID);
                    c.Vencedor = idA;
                    c.DescriResultado = cbDescrição.Text;
                    dao.UpdateConfronto(c);
                }
            if (CbVencedor.Text == cbVermelho.Text)
            {

                Atleta aV = new Atleta();
                Atleta aA = new Atleta();
                Confronto c = new Confronto();

                int idV = (int)cbVermelho.SelectedValue;
                aV = dao.GetAtletabyID(idV);
                int idA = (int)cbAzul.SelectedValue;
                aA = dao.GetAtletabyID(idA);

                 aV.Vitoria++;
                 aA.Derrota++;
                    dao.UpdateAtleta(aV);
                    dao.UpdateAtleta(aA);
                    int confrontoID = (int)dgvCard.CurrentRow.Cells[5].Value;
                    c = dao.GetObjConfrontoById(confrontoID);
                    c.Vencedor = idV;
                    c.DescriResultado = cbDescrição.Text;
                    dao.UpdateConfronto(c);

                }
            }
        }
    }
}
