using AutorLivrosAPI.Dto.Vinculo;
using AutorLivrosAPI.Models;

namespace AutorLivrosAPI.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public string Resumo {  get; set; }
        public double Avaliacao { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
