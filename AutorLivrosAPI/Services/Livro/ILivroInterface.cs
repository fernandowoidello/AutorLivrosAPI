using AutorLivrosAPI.Dto.Autor;
using AutorLivrosAPI.Dto.Livro;
using AutorLivrosAPI.Models;

namespace AutorLivrosAPI.Services.Livro

{
    public interface ILivroInterface
    {
        Task<ResponseModel<List<LivroDto>>> ListarLivros();
        Task<ResponseModel<LivroDto>> BuscarLivroPorId(int idLivro);
        Task<ResponseModel<List<LivroDto>>> BuscarLivroPorIdAutor(int idAutor);

        Task<ResponseModel<List<LivroModel>>> CriarLivro(LivroCriacaoDto livroCriacaoDto);

        Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDto livroEdicaoDto);
        Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idLivro);
    }
}
