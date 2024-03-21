namespace SistemaDeProdutos
{
    public class CadastroProduto
    {
        public string Nome {get; set;}
        public DateTime DataValidade {get; set;}
        public string Origem {get; set;}
        public double Preco {get; set;}
        public int Quantidade {get; set;}
        public DateTime DataAquisicao {get; set;}

        public CadastroProduto(string nome, DateTime dataValidade, string origem, double preco, int quantidade, DateTime dataAquisicao)
        {
            Nome = nome;
            DataValidade = dataValidade;
            Origem = origem;
            Preco = preco;
            Quantidade = quantidade;
            DataAquisicao = dataAquisicao;
        }

        public override string ToString()
        {
            return $"{Nome} - Quantidade: {Quantidade}";
        }
    }
}
