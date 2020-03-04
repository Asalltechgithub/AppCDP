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
using System.IO;
using System.Drawing.Imaging;


namespace Cdp
{
    public partial class frmAtleta : UserControl
    {
        clsDao dao = new clsDao();
        string caminhofoto = string.Empty;
        string Modo = "";
        Byte[] foto;
        Byte[] _Bandeira;

        public frmAtleta()
        {
            InitializeComponent();
        }

        private void FrmAtleta_Load(object sender, EventArgs e)
        {
            carregaCombosAtleta();
            dgvPesquisaAtleta.DataSource = dao.GetAllAtleta();
            MudarCorDaCelula();


        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            grupoAtleta.Enabled = true;
            Modo = "Novo";
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            grupoAtleta.Enabled = true;
            Modo = "Edit";
        }
        private void BtnSaveAtleta_Click(object sender, EventArgs e)
        {
            if (Modo == "Novo")
            {
                insertAtleta();
            }
            if (Modo == "Edit")
            {
                EditAtleta();
            }
            dgvPesquisaAtleta.DataSource = dao.GetAllAtleta();

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Excluir " + txtNome.Text + " " + txtSobreNome.Text + "?", "Excluir Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                delete();

            }

        }
        void delete()
        {
            Atleta a = new Atleta();
            a.Cod = (Int32)dgvPesquisaAtleta.CurrentRow.Cells[0].Value;
            dao.Delete(a.Cod);
            dgvPesquisaAtleta.Refresh();
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisaAtleta.Text != string.Empty && rbCategoria.Checked == true)
            {


            }
            if (txtPesquisaAtleta.Text != string.Empty && rbEquipe.Checked == true)
            {

            }
            if (txtPesquisaAtleta.Text != string.Empty && rbNome.Checked == true)
            {

            }
            if (txtPesquisaAtleta.Text != string.Empty && rbsf.Checked == true)
            {
                dgvPesquisaAtleta.DataSource = dao.GetAllAtleta();
            }
        }
        void insertAtleta()
        {

            if (validaFormAtleta() == true)
            {
                Domain.Domain.Atleta a = new Domain.Domain.Atleta();

                a.Nome = txtNome.Text.ToUpper();
                a.SobreNome = txtSobreNome.Text.ToUpper();
                a.Apelido = txtApelido.Text.ToUpper();
                a.Categoria = (int)cbCategoria.SelectedValue;
                a.Vitoria = int.Parse(txtVitorias.Text);
                a.Derrota = int.Parse(txtDerrotas.Text);
                a.Empate = int.Parse(txtEmpates.Text);
                a.Modalidade = txtModalidade.Text.ToUpper();
                a.Equipe = (int)cbEquipe.SelectedValue;
                a.Sexo = cbSexo.Text;
                a.foto = foto;
                a.Altura = double.Parse(txtAltura.Text);
                a.Idade = int.Parse(TxtIdade.Text);
                a.Peso = double.Parse(txtPeso.Text);
                a.Nacionalidade = CbPais.Text;
                a.CidadeNatal = txtCidade.Text;
                a.BandeiraNacional = _Bandeira;
                dao.InsertAtleta(a);
                MessageBox.Show("Atleta inserido com sucesso !!!");
                LimparCampos();


            }


        }
        void EditAtleta()
        {
            if (validaFormAtleta() == true)
            {
                Domain.Domain.Atleta a = new Domain.Domain.Atleta();
                a.Cod = (Int32)dgvPesquisaAtleta.CurrentRow.Cells[0].Value;
                a.Nome = txtNome.Text.ToUpper();
                a.SobreNome = txtSobreNome.Text.ToUpper();
                a.Apelido = txtApelido.Text.ToUpper();
                a.Categoria = (int)cbCategoria.SelectedValue;
                a.Vitoria = int.Parse(txtVitorias.Text);
                a.Derrota = int.Parse(txtDerrotas.Text);
                a.Empate = int.Parse(txtEmpates.Text);
                a.Modalidade = txtModalidade.Text.ToUpper();
                a.Equipe = (int)cbEquipe.SelectedValue;
                a.Sexo = cbSexo.Text;
                a.foto = foto;
                a.Altura = double.Parse(txtAltura.Text);
                a.Idade = int.Parse(TxtIdade.Text);
                a.Peso = double.Parse(txtPeso.Text);
                a.Nacionalidade = CbPais.Text;
                a.CidadeNatal = txtCidade.Text;
                a.BandeiraNacional = _Bandeira;
                dao.UpdateAtleta(a);
                MessageBox.Show("Atleta Atualizado com sucesso !!!");
                grupoAtleta.Enabled = false;
                LimparCampos();
            }
        }
        void carregaCombosAtleta()
        {
            cbCategoria.DataSource = dao.GetAllCategoria();
            cbCategoria.ValueMember = "Cod";
            cbCategoria.DisplayMember = "Nome";

            cbEquipe.DataSource = dao.GetAllEquipe();
            cbEquipe.ValueMember = "Cod";
            cbEquipe.DisplayMember = "Nome";

        }
        void recAtleta(int id)
        {


            Domain.Domain.Atleta a = new Domain.Domain.Atleta();

            a = dao.GetAtletabyID(id);

            txtNome.Text = a.Nome;
            txtSobreNome.Text = a.SobreNome;
            txtModalidade.Text = a.Modalidade;
            txtApelido.Text = a.Apelido;
            txtVitorias.Text = Convert.ToString(a.Vitoria);
            txtEmpates.Text = Convert.ToString(a.Empate);
            txtDerrotas.Text = Convert.ToString(a.Derrota);
            cbCategoria.SelectedValue = Convert.ToInt32(a.Categoria);
            cbSexo.Text = a.Sexo;
            cbEquipe.SelectedValue = Convert.ToInt32(a.Equipe);
            if (a.foto.Length > 0)
            {
                fotoAtleta.Image = DecodificarFoto(a.foto);
                foto = CodificarFoto(fotoAtleta.Image);
            }
            else
            {
                fotoAtleta.Image = Properties.Resources.user_male_icon;
            }
            if( a.BandeiraNacional!= null)
            {

            
            if (a.BandeiraNacional.Length > 0)
            {
                Bandeira.Image = DecodificarFoto(a.BandeiraNacional);
            }
            else
            {
                Bandeira.Image = Properties.Resources._148_1485366_flag_spot_icon_free_download_png_clipart_stick;
            }
            }
            else
            {
                Bandeira.Image = Properties.Resources._148_1485366_flag_spot_icon_free_download_png_clipart_stick;

            }
            txtAltura.Text = a.Altura.ToString();
            TxtIdade.Text = a.Idade.ToString();
            txtPeso.Text = a.Peso.ToString();
            CbPais.Text = a.Nacionalidade;
            txtCidade.Text = a.CidadeNatal;

            dgvHistoricoAtleta.DataSource = dao.GetConfrontosByAtleta(id);
            dgvHistoricoAtleta.Refresh();
        }


        bool validaFormAtleta()
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Sobrenome dado Obrigatório");
                return false;

            }
            if (txtSobreNome.Text == string.Empty)

            {
                MessageBox.Show("Sobrenome dado Obrigatório");
                return false;
            }
            if (txtModalidade.Text == string.Empty)
            {
                MessageBox.Show("Sobrenome dado Obrigatório");
                return false;
            }
            if (txtAltura.Text == string.Empty)
            {
                MessageBox.Show("Altura dado Obrigatório");
                return false;
            }
            if (txtPeso.Text == string.Empty)
            {
                MessageBox.Show("Peso dado Obrigatório");
                return false;
            }
            if (TxtIdade.Text == string.Empty)
            {
                MessageBox.Show("Idade dado Obrigatório");
                return false;
            }
            if (txtVitorias.Text == string.Empty)
            {
                txtVitorias.Text = 0.ToString();
            }
            if (txtDerrotas.Text == string.Empty)
            {
                txtDerrotas.Text = 0.ToString();
            }
            if (txtEmpates.Text == string.Empty)
            {
                txtEmpates.Text = 0.ToString();
            }
            if (foto == null)
            {

            }

            return true;

        }
        void LimparCampos()
        {
            txtAltura.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSobreNome.Text = string.Empty;
            txtModalidade.Text = string.Empty;
            txtApelido.Text = string.Empty;
            txtVitorias.Text = string.Empty;
            txtEmpates.Text = string.Empty;
            txtDerrotas.Text = string.Empty;
            txtEmpates.Text = string.Empty;
            cbCategoria.Refresh();
            cbEquipe.Refresh();
            cbSexo.Refresh();
            dgvHistoricoAtleta.DataSource = null;
        }

        private void Btncarregafoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "teste";
            openFileDialog1.Title = "Selecione uma Foto";
            openFileDialog1.Filter = "JPEG|*.JPG|PNG|*.png";
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fotoAtleta.Image = Image.FromFile(openFileDialog1.FileName);
            foto = CodificarFoto(fotoAtleta.Image);
        }
        public static Byte[] CodificarFoto(Image fotosave)

        {

            MemoryStream ms = new MemoryStream();

            fotosave.Save(ms, ImageFormat.Png); //Salvando imagem no memoryStream

            Byte[] myData = new Byte[ms.Length];

            myData = ms.ToArray();

            return myData;

        }
        public static Image DecodificarFoto(Byte[] fotosave)
        {
            MemoryStream ms;
            Image img = null;
            if (fotosave == null)
            {

            }
            else
            {
                ms = new MemoryStream(fotosave);

                Image imagem = Image.FromStream(ms);


                img = imagem;
            }


            return img;

        }
        private void MudarCorDaCelula()
        {
            // inicia a cor da celula dgv

            dgvPesquisaAtleta.BackgroundColor = Color.LightGray;
            dgvPesquisaAtleta.BorderStyle = BorderStyle.Fixed3D;

            // define a cor de fundo da dgv.

            dgvPesquisaAtleta.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvPesquisaAtleta.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvPesquisaAtleta.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            dgvPesquisaAtleta.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            dgvPesquisaAtleta.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            dgvPesquisaAtleta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPesquisaAtleta.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

            dgvPesquisaAtleta.RowHeadersDefaultCellStyle.BackColor = Color.Black;
        }

        private void DgvPesquisaAtleta_SelectionChanged(object sender, EventArgs e)
        {
            int ID = 0;
            btnDelete.Enabled = true;
            grupoAtleta.Enabled = false;
            if (dgvPesquisaAtleta.CurrentRow.Cells[0].Value == "{ }")
            {

            }
            else
            {
                ID = (Int32)dgvPesquisaAtleta.CurrentRow.Cells[0].Value;
            }

            recAtleta(ID);
        }

        private void Bandeira_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "teste";
            openFileDialog2.Title = "Selecione uma Foto";
            openFileDialog2.Filter = "JPEG|*.JPG|PNG|*.png";
            openFileDialog2.ShowDialog();
        }

        private void OpenFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            Bandeira.Image = Image.FromFile(openFileDialog2.FileName);
            _Bandeira = CodificarFoto(Bandeira.Image);
        }
    }
}

