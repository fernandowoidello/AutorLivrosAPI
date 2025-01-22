using AutorLivrosAPI.Dto.Autor;
using AutorLivrosAPI.Models;

namespace AutorLivrosAPI.Services.Autor
{
    public interface IAutorInterface //primeiro os metodos na interface
    {
        Task<ResponseModel<List<AutorModel>>>ListarAutores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);
        Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto);

        Task<ResponseModel<List<AutorModel>>> EditarAutor(AutorEdicaoDto autorEdicaoDto);
        Task<ResponseModel<List<AutorModel>>> ExcluirAutor(int autorModel);

    }
}
