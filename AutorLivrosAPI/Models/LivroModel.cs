namespace AutorLivrosAPI.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        
        public string Resumo { get; set; }

        public double Avaliacao {  get; set; }

        public AutorModel Autor { get; set; } //relacao livro autor
    }
}
