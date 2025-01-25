using AutorLivrosAPI.Dto.Autor;
using AutorLivrosAPI.Dto.Livro;
using AutorLivrosAPI.Models;
using AutorLivrosAPI.Services.Autor;
using AutorLivrosAPI.Services.Livro;
using Microsoft.AspNetCore.Mvc;


namespace AutorLivrosAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroInterface _livroInterface;

        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }

        [HttpPost("CriarLivro")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> CriarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livros = await _livroInterface.CriarLivro(livroCriacaoDto);
            return Ok(livros);
        }
    }
    
       
    

}
