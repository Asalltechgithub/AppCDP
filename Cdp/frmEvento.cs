using System;

using System.Windows.Forms;
using DAL;

namespace Cdp
{

    public partial class frmEvento : UserControl
    {
        clsDao dao = new clsDao();
        string caminhofoto = string.Empty;
        string Modo = "";
        string subModo = "InserirConfronto";
        public frmEvento()
        {
            InitializeComponent();
        }

        private void FrmEvento_Load(object sender, EventArgs e)
        {
            carregagrids();
            style stl = new style();

          stl.MudarCorDaCelulagrid(dgvEventos);
        }
        private void BtnNovoEvento_Click(object sender, EventArgs e)
        {
            Modo = "InserirEvento";
            txtNomeEvento.Enabled = true;
            txtData.Enabled = true;
            txtLocalEvento.Enabled = true;
            LimpaformEventos();
        }

        private void BtnSaveEvento_Click(object sender, EventArgs e)
        {
            if (Modo == "InserirEvento")
            {
                InserirEvento();
            }
            if (Modo == "EditarEvento")
            {
                EditarEvento();
            }


            LimparFormEvento();
        }

        private void BtnEditarEvento_Click(object sender, EventArgs e)
        {
            Modo = "EditarEvento";
            txtNomeEvento.Enabled = true;
            txtData.Enabled = true;
            txtLocalEvento.Enabled = true;
        }

        private void BtnDeleteEvento_Click(object sender, EventArgs e)
        { 
            DialogResult confirm = MessageBox.Show("Deseja Excluir  " + txtNomeEvento.Text  + " ?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                int Id = (int)dgvEventos.CurrentRow.Cells[0].Value;
                dao.DeleteEvento(Id);
                carregagrids();
            }
           
        }

      

        private void BtnEditarCard_Click(object sender, EventArgs e)
        {
            Modo = "EditarConfronto";
        }

      

        private void DgvEventos_SelectionChanged(object sender, EventArgs e)
        {
            int Id = (int)dgvEventos.CurrentRow.Cells[0].Value;
            Domain.Domain.Evento ev = new Domain.Domain.Evento();
            ev = dao.GetEventoById(Id);
            txtNomeEvento.Text = ev.Nome;
            txtData.Text = ev.DtEvento.ToString("dd/MM/yyyy");
            txtLocalEvento.Text = ev.Local_Evento;

        }


        void LimpaformEventos()
        {
            txtNomeEvento.Text = string.Empty;
            txtData.Text = string.Empty;
            txtLocalEvento.Text = string.Empty;
        }




       

        void LimparFormEvento()
        {
            txtNomeEvento.Text = string.Empty;
            txtData.Text = string.Empty;
            txtLocalEvento.Text = string.Empty;
        }
       
        void InserirEvento()
        {
            Domain.Domain.Evento e = new Domain.Domain.Evento();
            e.Nome = txtNomeEvento.Text;
            e.DtEvento = DateTime.Parse(txtData.Text);
            e.Local_Evento = txtLocalEvento.Text;
            dao.InsertEvento(e);
            LimpaformEventos();
            MessageBox.Show("Evento Criado !!! Insira os Confrontos desse Evento !!! ");
            
            carregagrids();
        }
        void EditarEvento()
        {
            Domain.Domain.Evento e = new Domain.Domain.Evento();
            e.Cod = (int)dgvEventos.CurrentRow.Cells[0].Value;
            e.Nome = txtNomeEvento.Text;
            e.DtEvento = DateTime.Parse(txtData.Text);
            e.Local_Evento = txtLocalEvento.Text;
            dao.UpdateEvento(e);
            LimpaformEventos();
            MessageBox.Show("Evento Atualizado !!! Edite os Confrontos desse Evento !!! ");
            carregagrids();
        }
        void carregagrids()
        {

            dgvEventos.DataSource = dao.GetEventos();


        }
        

    }
}
