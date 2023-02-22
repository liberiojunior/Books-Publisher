using System;
using BLL;
using DTO;

namespace ExercicioErros
{
    public partial class frmAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridAutor();
        }

        DTO_Autor objAutorDTO = new DTO_Autor();
        BLL_Autor objAutorBLL = new BLL_Autor();

        private void CarregarGridAutor()
        {
            gridAutor.DataSource = objAutorBLL.ListarAutor("SELECT idAutor as ID, nome as 'Nome Autor', idade as Idade FROM tbl_autor ORDER BY nome ASC;");
            gridAutor.DataBind();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtIdAutor.Text = "";
            txtNome.Text = "";
            txtIdade.Text = "0";
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            objAutorDTO.Nome = txtNome.Text;
            objAutorDTO.Idade = int.Parse(txtIdade.Text);

            if (txtIdAutor.Text == "")
            {
                objAutorBLL.InserirAutor(objAutorDTO);
            }
            else
            {
                objAutorDTO.IdAutor = int.Parse(txtIdAutor.Text);
                objAutorBLL.AlterarAutor(objAutorDTO);
            }

            CarregarGridAutor();
            Limpar();
        }

        protected void gridAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdAutor.Text = gridAutor.SelectedRow.Cells[1].Text;
            txtNome.Text = gridAutor.SelectedRow.Cells[2].Text;
            txtIdade.Text = gridAutor.SelectedRow.Cells[3].Text;
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            objAutorDTO.IdAutor = int.Parse(txtIdAutor.Text);
            objAutorBLL.ExcluirAutor(objAutorDTO);
            CarregarGridAutor();
            Limpar();

        }
    }
}