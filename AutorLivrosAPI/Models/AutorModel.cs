using System.Text.Json.Serialization;

namespace AutorLivrosAPI.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string sobrenome { get; set; }

        [JsonIgnore]
        public  ICollection<LivroModel> Livros { get; set; } //relacao autor livro
    }
}
