using AutoMapper;
using AutorLivrosAPI.Dto.Livro;
using AutorLivrosAPI.Dto.Vinculo;
using AutorLivrosAPI.Models;

namespace AutorLivrosAPI.Mapping
{
    public class LivroProfile : Profile

    {
        
        public LivroProfile() 
        {
            // Mapeamento de Criação
            CreateMap<LivroCriacaoDto, LivroModel>()
                .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.Titulo))
                .ForMember(dest => dest.Resumo, opt => opt.MapFrom(src => src.Resumo))
                .ForMember(dest => dest.Avaliacao, opt => opt.MapFrom(src => src.Avaliacao))
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => src.Autor.Id)); // Vincula pelo ID

            // Mapeamento de Edição
            CreateMap<LivroEdicaoDto, LivroModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.Titulo))
                .ForMember(dest => dest.Resumo, opt => opt.MapFrom(src => src.Resumo))
                .ForMember(dest => dest.Avaliacao, opt => opt.MapFrom(src => src.Avaliacao))
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => src.Autor.Id));

            // Mapeamento de Retorno
            CreateMap<LivroModel, LivroDto>()
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => new AutorVinculoDto
                {
                    Id = src.Autor.Id,
                    Nome = src.Autor.Nome
                }));


        }



    }
}
