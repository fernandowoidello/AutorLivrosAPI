namespace AutorLivrosAPI.Models
{
    public class ResponseModel<T> //generico, dados tipo autor e livro
    {

        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;

        public bool Status { get; set; } = true;

        
    }
}
