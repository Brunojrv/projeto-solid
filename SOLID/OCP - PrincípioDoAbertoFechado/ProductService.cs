using SOLID.OCP___PrincípioDoAbertoFechado.Interfaces;
namespace SOLID.OCP___PrincípioDoAbertoFechado
{
    public class ProductService
    {
      public void ProcessProduct(Product product)
        {
            // regra de processamento especifica para tipo do produto.
            // caso tenha mais um tipo de produto, será necessário mais um else if e uma nova regra para o produto específico.

            if (product.ProductSegment == Enums.EnumProductSegment.Electronic)
            {
               
            }
            else if (product.ProductSegment == Enums.EnumProductSegment.House)
            {

            }
            else if (product.ProductSegment == Enums.EnumProductSegment.Accessory)
            {

            }
        }

        public void ProcessProduct(IProductProcess product)
        {
            //Dessa forma, o método de processar produto não precisa saber o segmento do produto, basta criar uma classe para cada segmento
            //Herda a interface na classe e pronto.
            product.ProcessProduct();
        }
    }
}
