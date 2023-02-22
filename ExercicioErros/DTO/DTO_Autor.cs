namespace DTO
{
    class DTO_Autor
    {
        private int idAutor, idade;
        private string nome;
    
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
