using AutorLivrosAPI.Dto.Vinculo;

namespace AutorLivrosAPI.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public double Avaliacao { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
