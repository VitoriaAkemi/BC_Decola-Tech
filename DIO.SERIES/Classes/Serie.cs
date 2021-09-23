namespace DIO
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set;}

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Ano { get; set; }


        public Serie(int id, Genero genero, string titulo, string descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Enviornment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }



    }


}