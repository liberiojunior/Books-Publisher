using System;
using System.Web;
using BLL;
using DTO;

namespace ExercicioErros
{
    public partial class Livro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarAutores();
            CarregarLivros();
            CarregarEditoras();
        }

        DTO_Autor objAutorDTO = new DTO_Autor();
        DTO_Editora objEditoraDTO = new DTO_Editora();
        DTO_Livro objLivroDTO = new DTO_Livro();
        BLL_Autor objAutorBLL = new BLL_Autor();
        BLL_Editora objEditoraBLL = new BLL_Editora();
        BLL_Livro objLivroBLL = new BLL_Livro();

        private void CarregarEditoras()
        {
            drpEditora.DataSource = objEditoraBLL.ListarEditoras("SELECT * FROM tbl_editora ORDER BY nome");
            drpEditora.DataValueField = "idEditora";
            drpEditora.DataTextField = "nome";
            drpEditora.DataBind();
        }

        private void CarregarAutores()
        {
            drpAutor.DataSource = objEditoraBLL.ListarEditoras("SELECT * FROM tbl_autor ORDER BY nome");
            drpAutor.DataValueField = "idAutor";
            drpAutor.DataTextField = "nome";
            drpAutor.DataBind();
        }


        private void CarregarLivros()
        {
            gridLivro.DataSource = objLivroBLL.ListarLivro("SELECT * FROM tbl_livro ORDER BY titulo");
            gridLivro.DataBind();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtIdLivro.Text = "";
            drpAutor.SelectedIndex = 0;
            drpEditora.SelectedIndex = 0;
            txtTitulo.Text = "";
            txtDtCadastro.Text = "";
            txtNumPaginas.Text = "0";
            txtValor.Text = "0";
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            objLivroDTO.IdAutor = int.Parse(drpAutor.SelectedValue);
            objLivroDTO.IdEditora = int.Parse(drpEditora.SelectedValue);
            objLivroDTO.Titulo = txtTitulo.Text;
            objLivroDTO.DataCadastro = DateTime.Parse(txtDtCadastro.Text);
            objLivroDTO.NumPaginas = int.Parse(txtNumPaginas.Text);
            objLivroDTO.Valor = double.Parse(txtValor.Text);


            if (txtIdLivro.Text == "")
            {
                objLivroBLL.InserirLivro(objLivroDTO);
            }
            else
            {
                objLivroDTO.IdLivro = int.Parse(txtIdLivro.Text);
                objLivroBLL.AlterarLivro(objLivroDTO);
            }

            CarregarLivros();
            Limpar();
        }

        protected void gridLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdLivro.Text = gridLivro.SelectedRow.Cells[1].Text;
            drpAutor.SelectedValue = gridLivro.SelectedRow.Cells[2].Text;
            drpEditora.SelectedValue = gridLivro.SelectedRow.Cells[3].Text;
            txtTitulo.Text = HttpUtility.HtmlDecode(gridLivro.SelectedRow.Cells[4].Text);
            txtDtCadastro.Text = gridLivro.SelectedRow.Cells[5].Text;
            txtNumPaginas.Text = gridLivro.SelectedRow.Cells[6].Text;
            txtValor.Text = gridLivro.SelectedRow.Cells[7].Text;
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            objLivroDTO.IdLivro = int.Parse(txtIdLivro.Text);
            objLivroBLL.ExcluirLivro(objLivroDTO);
            CarregarLivros();
            Limpar();
        }
    }
}