using System;
using System.Data;
using DAL;

namespace BLL
{
    class BLL_Editora
    {
        Conexao bd = new Conexao();

        public DataTable ListarEditoras(string query)
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
