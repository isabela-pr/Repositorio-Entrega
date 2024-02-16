using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class DescricaoProduto
    {
        public Guid DescricaoProdutoId { get; set; }

        [Display(Name = "Nome do Produto")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }


    }
}
