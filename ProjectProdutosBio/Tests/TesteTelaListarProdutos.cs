using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using ProjectProdutosBio.PageObject.ListarProdutoPO;
using ProjectProdutosBio.PageObject.RealizarLoginPO;

namespace ProjectProdutosBio.Tests
{
    [TestClass]
    public class TesteTelaListarProdutos
    {
        [TestMethod]
        public void TesteDasColunasdaTelaListarProdutosConformeRequisito() // este teste vai falhar pois esta respeitando o requisito. Como existe um bug na exibição das colunas, não dará ok.
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);
            
            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .VerificarColunasDaTelaListaDeProdutos();
            
            driver.Quit();
        }

        [TestMethod]
        public void TesteDasColunasdaTelaListarProdutosConformeTela() // este teste vai passar pois esta respeitando o que esta presente na tela - com bug. Nao esta conforme requisito.
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .VerificarColunasDaTelaListaDeProdutosParaPassar();

            driver.Quit();
        }


        [TestMethod]
        public void TesteDaQuantidadeDeRegistrosPorPaginaDaTelaListarProdutos()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .VerificarQuantidadeDeRegistrosPorPagina();

            driver.Quit();
        }
    }
}
