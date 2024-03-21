namespace SistemaDeProdutos
{
    public class CalculoDoPreco
    {
        public double CalcularPrecoFinal(CadastroProduto produto) 
        {
            double precoFinal = produto.Preco * produto.Quantidade, resultadoFinal = 0, valorAcrescimoFrete = 0;

            if (produto.DataAquisicao.Month >= 1 && produto.DataAquisicao.Month <= 7)
            {
                resultadoFinal = precoFinal - (precoFinal * 0.3);
            }
            else
            {
                resultadoFinal = precoFinal - (precoFinal * 0.5);
            }

            switch (produto.Origem.ToUpper())
            {
                case "SUL":
                    valorAcrescimoFrete = resultadoFinal + (resultadoFinal * 0.4);
                    break;
                case "SUDESTE":
                    valorAcrescimoFrete = resultadoFinal + (resultadoFinal * 0.1);
                    break;
                case "CENTRO-OESTE":
                    valorAcrescimoFrete = resultadoFinal + (resultadoFinal * 0.2);
                    break;
                case "NORTE":
                    valorAcrescimoFrete = resultadoFinal + (resultadoFinal * 0.3);
                    break;
                case "NORDESTE":
                    valorAcrescimoFrete = resultadoFinal + (resultadoFinal * 0.5);
                    break;
            }

            return valorAcrescimoFrete;
        }
    }
}
