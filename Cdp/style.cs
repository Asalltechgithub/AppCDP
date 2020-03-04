using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cdp
{
   public class style
    {

        public void MudarCorDaCelulagrid (DataGridView grid)
        {
            // inicia a cor da celula dgv

            grid.BackgroundColor = Color.LightGray;
            grid.BorderStyle = BorderStyle.Fixed3D;

            // define a cor de fundo da dgv.
            grid.ReadOnly = true;
            grid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            grid.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            grid.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

            grid.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
        }
        public static Image DecodificarFoto(Byte[] fotosave)
        {
            MemoryStream ms;
            Image img = null;
            if (fotosave.Length > 0)
            {


                if (fotosave == null)
                {

                }
                else
                {
                    ms = new MemoryStream(fotosave);

                    Image imagem = Image.FromStream(ms);


                    img = imagem;
                }

            }



            return img;


        }
        
        public static Byte[] CodificarFoto(Image fotosave)

        {

            MemoryStream ms = new MemoryStream();

            fotosave.Save(ms, ImageFormat.Png); //Salvando imagem no memoryStream

            Byte[] myData = new Byte[ms.Length];

            myData = ms.ToArray();

            return myData;

        }
       public void modobtnNovo(Button btnSave, Button btnEditar, Button btnremover)
        {
            btnEditar.Text = "Editar";
            btnSave.Enabled = true;
            btnEditar.Enabled = false;
            btnremover.Enabled = false;

        }
        public void modobtnEditar( Button btnSave, Button btnremover,Button btnEditar, Button btnNovo)
        {

            btnEditar.Enabled = false;
            btnNovo.Enabled = false;
            btnSave.Enabled = true;
            btnremover.Enabled = false;
        }
        public void modobtnCancelar(Button btnNovo, Button btnSave ,Button btnCancelar)
        {
            btnCancelar.Text = "Cancelar";
            btnNovo.Text = "Novo";
            btnNovo.Enabled = true;
            btnSave.Enabled = false;
        }
        public void modobtnRemover(Button btnSave, Button btnremover)
        {

            btnSave.Text = "Salvar";
            btnremover.Text = "Deletar";
            btnSave.Enabled = false;
            btnremover.Enabled = true;
        }

    }
}
