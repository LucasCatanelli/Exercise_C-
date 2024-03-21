namespace SistemaDeProdutos
{
    class Program
    {
        static void Main()
        {
            List<string> regioes = new List<string> { "SUL", "SUDESTE", "CENTRO-OESTE", "NORTE", "NORDESTE" };

            do
            {
                Console.Write("Digite o Nome do produto: ");
                string nome = Console.ReadLine();

                DateTime dataValidade;
                while (true)
                {
                    Console.Write("Digite a Data de validade (DD/MM/AAAA): ");
                    string inputData = Console.ReadLine();
                    if (DateTime.TryParseExact(inputData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataValidade))
                        break;
                    Console.WriteLine("Essa Data é inválida. Tente novamente.");
                }

                Console.WriteLine("Escolha a região de origem do produto:");
                foreach (var regiao in regioes)
                {
                    Console.WriteLine($"- {regiao}");
                }
                string origem;
                while (true)
                {
                    Console.Write("Origem do produto: ");
                    origem = Console.ReadLine().ToUpper();
                    if (regioes.Contains(origem))
                        break;
                    Console.WriteLine("Essa Região é inválida. Tente novamente.");
                }

                Console.Write("Digite o Preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("Digite a Quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());

                DateTime dataCompra;
                while (true)
                {
                    Console.Write("Digite o Mês/Ano de compra do produto (MM/AAAA): ");
                    if (DateTime.TryParseExact(Console.ReadLine(), "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataCompra))
                        break;
                    Console.WriteLine("Essa Data é inválida. Tente novamente.");
                }

                CadastroProduto produto = new CadastroProduto(nome, dataValidade, origem, preco, quantidade, dataCompra);
                CalculoDoPreco calculadora = new CalculoDoPreco();
                double precoFinal = calculadora.CalcularPrecoFinal(produto);

                Console.WriteLine($"Nome do Produto: {produto.Nome} - Quantidade: {produto.Quantidade} - Preço Final: R$ {precoFinal:F2}");

                Console.Write("Deseja continuar realizando compras? (S/N): ");
            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}
