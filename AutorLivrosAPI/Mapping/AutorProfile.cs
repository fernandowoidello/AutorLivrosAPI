using AutoMapper;
using AutorLivrosAPI.Dto.Autor;
using AutorLivrosAPI.Models;

namespace AutorLivrosAPI.Mapping
{
    public class AutorProfile : Profile
    {
        public AutorProfile()
        {
            // Mapeamento para criação e edição do autor
            CreateMap<AutorCriacaoDto, AutorModel>();
            CreateMap<AutorEdicaoDto, AutorModel>();
        }
    }
}