using AutorLivrosAPI.Dto.Autor;
using AutorLivrosAPI.Dto.Livro;
using AutorLivrosAPI.Models;

namespace AutorLivrosAPI.Services.Livro

{
    public interface ILivroInterface
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro);
        Task<ResponseModel<LivroModel>> BuscarLivroPorIdAutor(int idAutor);
        Task<ResponseModel<List<AutorModel>>> CriarLivro(LivroCriacaoDto livroCriacaoDto);

        Task<ResponseModel<List<AutorModel>>> EditarLivro(LivroCriacaoDto livroEdicaoDto);
        Task<ResponseModel<List<AutorModel>>> ExcluirLivro(int idLivro);
    }
}
