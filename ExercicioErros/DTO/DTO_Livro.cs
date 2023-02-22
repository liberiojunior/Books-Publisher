using System;

namespace DTO
{
    class DTO_Livro
    {
        private int idLivro, idAutor, idEditora, numPaginas;
        private string titulo;
        private DateTime dataCadastro;
        private double valor;

        public int IdLivro
        {
            get { return idLivro; }
            set { idLivro = value; }
        }

        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        public int IdEditora
        {
            get { return idEditora; }
            set { idEditora = value; }
        }

        public int NumPaginas
        {
            get { return numPaginas; }
            set { numPaginas = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
