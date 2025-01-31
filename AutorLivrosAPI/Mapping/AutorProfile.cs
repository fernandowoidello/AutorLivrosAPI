using AutoMapper;
using AutorLivrosAPI.Dto.Autor;
using AutorLivrosAPI.Models;

namespace AutorLivrosAPI.Mapping
{
    public class AutorProfile : Profile
    {
        public AutorProfile()
        {
            CreateMap<AutorCriacaoDto, AutorModel>();
            CreateMap<AutorEdicaoDto, AutorModel>();
            CreateMap<AutorModel, AutorDto>();
        }
    }
}
