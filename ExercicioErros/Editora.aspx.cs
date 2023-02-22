using System;
using BLL;

namespace ExercicioErros
{
    public partial class Editora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridEditoras();
        }

        BLL_Editora objetoEditora = new BLL_Editora();

        private void CarregarGridEditoras()
        {
            gridEditora.DataSource = objetoEditora.ListarEditoras("SELECT * FROM tbl_editora ORDER BY nome ASC;");
            gridEditora.DataBind();
        }
    }
}