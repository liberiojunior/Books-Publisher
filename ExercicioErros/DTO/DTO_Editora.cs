namespace DTO
{
    class DTO_Editora
    {
        private int idEditora;
        private string nome, endereco, uf;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public int IdEditora
        {
            get { return idEditora; }
            set { idEditora = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
    }
}
