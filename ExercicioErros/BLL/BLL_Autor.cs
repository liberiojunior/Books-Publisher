using System.Data;
using DAL;
using DTO;

namespace BLL
{
    class BLL_Autor
    {
        Conexao bd = new Conexao();

        public void InserirAutor(DTO_Autor autorDTO)
        {
            string inserir = "INSERT INTO tbl_Autor VALUES(NULL, '" + autorDTO.Nome + "', " + autorDTO.Idade + ");";
            bd.ExecutarComandos(inserir);
        }

        public void AlterarAutor(DTO_Autor autorDTO)
        {
            string alterar = "UPDATE tbl_Autor SET nome = '" + autorDTO.Nome + "', idade = " + autorDTO.Idade + " WHERE idAutor = " + autorDTO.IdAutor + ";";
            bd.ExecutarComandos(alterar);
        }

        public void ExcluirAutor(DTO_Autor autorDTO)
        {
            string excluir = "DELETE FROM tbl_Autor WHERE idAutor = " + autorDTO.IdAutor + ";";
            bd.ExecutarComandos(excluir);
        }

        public DataTable ListarAutor(string query)
        {
            try
            {
                return bd.ExecutarConsulta(query);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
