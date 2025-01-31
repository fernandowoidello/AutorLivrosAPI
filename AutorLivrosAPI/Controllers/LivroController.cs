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

        [HttpGet("ListarLivros")]

        public async Task<ActionResult<ResponseModel<LivroDto>>> ListarLivros()

        {

            var livros = await _livroInterface.ListarLivros();
            return Ok (livros);
                
        }

        [HttpGet("BuscarLivroPorId/{idLivro}")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> BuscarLivroPorId(int idLivro)
        {
            var autor = await _livroInterface.BuscarLivroPorId(idLivro);
            return Ok(autor);
        }

        [HttpGet("BuscarLivroPorIdAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> BuscarLivroPorIdAutor(int idAutor)
        {
            var livro = await _livroInterface.BuscarLivroPorIdAutor(idAutor);
            return Ok(livro);
        }

     
        [HttpPost("CriarLivro")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> CriarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livros = await _livroInterface.CriarLivro(livroCriacaoDto);
            return Ok(livros);
        }

        [HttpPut("EditarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(LivroEdicaoDto livroEdicaoDto)
        {
            var livros = await _livroInterface.EditarLivro(livroEdicaoDto);
            return Ok(livros);
        }


        [HttpDelete("ExcluirLivro")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> ExcluirLivro(int idLivro)
        {
            var livros = await _livroInterface.ExcluirLivro(idLivro);
            return Ok(livros);
        }
    }
    

}
