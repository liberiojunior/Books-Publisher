using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    class BLL_Livro
    {
        Conexao bd = new Conexao();

        public void InserirLivro(DTO_Livro livroDTO)
        {
            string inserir = "INSERT INTO tbl_Livro VALUES(NULL, " + livroDTO.IdAutor + ", " + livroDTO.IdEditora + ", '" +  livroDTO.Titulo + "', '" + livroDTO.DataCadastro.ToString("yyyy/MM/dd") + "', " + livroDTO.NumPaginas + ", " + livroDTO.Valor + ");";
            bd.ExecutarComandos(inserir);
        }

        public void AlterarLivro(DTO_Livro livroDTO)
        {
            string alterar = "UPDATE tbl_Livro SET idAutor = '" + livroDTO.IdAutor + "', idEditora = " + livroDTO.IdEditora + ", titulo = '" + livroDTO.Titulo + "',  dataCadastro = '" + livroDTO.DataCadastro.ToString("yyyy/MM/dd") + "', numPaginas = " + livroDTO.NumPaginas + ", valor = " + livroDTO.Valor + " WHERE idLivro = " + livroDTO.IdLivro + ";";
            bd.ExecutarComandos(alterar);
        }

        public void ExcluirLivro(DTO_Livro livroDTO)
        {
            string excluir = "DELETE FROM tbl_Livro WHERE idLivro = " + livroDTO.IdLivro + ";";
            bd.ExecutarComandos(excluir);
        }

        public DataTable ListarLivro(string query)
        {
            try
            {
                return bd.ExecutarConsulta(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
