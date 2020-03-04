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

namespace Cdp
{
    public partial class frmEquipe : UserControl
    {
        clsDao dao = new clsDao();
        style Style = new style();
        Byte[] foto = null;
        string Modo = "";
        public frmEquipe()
        {
            InitializeComponent();
        }

        private void FrmEquipe_Load(object sender, EventArgs e)
        {
            label1.Text = "Nome Equipe";
            Style.modobtnNovo(button2, button3, button4);
            Style.modobtnEditar(button2, button4, button3, button1);
            Style.modobtnRemover(button2, button4);
            Style.modobtnCancelar(button1, button2, button5);
            Style.MudarCorDaCelulagrid(dgvEquipe);
            CarregaGrid();
        }
        void CarregaGrid()
        {
            dgvEquipe.DataSource = dao.GetAllEquipe();

        }
       
        void InserirEquipe()
        {
            Domain.Domain.Equipe e = new Domain.Domain.Equipe();
            e.Nome = textBox1.Text;
            e.Logo = foto;
            dao.InsertEquipe(e);
            MessageBox.Show("Equipe inserida com sucesso !!!");
            CarregaGrid();
            LimpaCampos();
            textBox1.Enabled = false;
        }
        void EditarEquipe()
        {
            Domain.Domain.Equipe e = new Domain.Domain.Equipe();
            e.Cod = (int)dgvEquipe.CurrentRow.Cells[0].Value;
            e.Nome = textBox1.Text;
            e.Logo = foto;
            dao.UpdateEquipe(e);
            MessageBox.Show("Equipe Atualizada com sucesso !!!");
            CarregaGrid();
            LimpaCampos();
            textBox1.Enabled = false;
        }
        void LimpaCampos()
        {
            textBox1.Text = string.Empty;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Modo = "Inserir";
            textBox1.Enabled = true;
            Style.modobtnNovo(button2, button3, button4);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Style.modobtnCancelar(button1, button2, button5);
            if (Modo == "Inserir")
            {
                InserirEquipe();
            }
            if (Modo=="Editar")
             {
                EditarEquipe();
             }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Modo = "Editar";
            textBox1.Enabled = true;
            Style.modobtnEditar(button2, button4,button3,button1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Style.modobtnRemover(button2, button4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Style.modobtnCancelar(button1, button2, button5);
        }

        private void LogoEquipe_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "teste";
            openFileDialog1.Title = "Selecione uma Foto";
            openFileDialog1.Filter = "JPEG|*.JPG|PNG|*.png";
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            LogoEquipe.Image = Image.FromFile(openFileDialog1.FileName);
            foto = style.CodificarFoto(LogoEquipe.Image);
        }

        private void DgvEquipe_SelectionChanged(object sender, EventArgs e)
        {
            
            button3.Enabled = true;
            int Id =(int)dgvEquipe.CurrentRow.Cells[0].Value;
            Domain.Domain.Equipe equipe = new Domain.Domain.Equipe();
            equipe = dao.GetEquipeById(Id);
            textBox1.Text = equipe.Nome;
            if(equipe.Logo != null)
            {
                LogoEquipe.Image = style.DecodificarFoto(equipe.Logo);
            }
            else
            {
                LogoEquipe.Image = Properties.Resources.user_male_icon;
            }
            
        }
    }
}

