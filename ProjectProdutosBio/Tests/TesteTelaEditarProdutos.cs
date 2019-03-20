using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using ProjectProdutosBio.PageObject.EditarProdutoPO;
using ProjectProdutosBio.PageObject.RealizarLoginPO;
using ProjectProdutosBio.PageObject.ListarProdutoPO;
using System;

namespace ProjectProdutosBio.Tests
{
    [TestClass]
    public class TesteTelaEditarProdutos
    {
        [TestMethod]
        public void TesteEditarCampoNomeProduto()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            EditarProdutoPO editarProduto = new EditarProdutoPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            // gera nome de produto randomico de modo que nao repita e falhe o teste
            Guid nomeProdutoRandomico = Guid.NewGuid();

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .SelecionarNoProdutoDaLista();

            editarProduto
                           .VerificarTituloTelaEditarProduto()
                           .EditarNomeProduto("EditProd" + nomeProdutoRandomico.ToString())
                           .ClicarSalvarAlteracaoProduto()
                           .VerificarMensagemDeProdutoAlteradoComSucesso();

            driver.Quit();
        }


        [TestMethod]
        public void TesteEditarCampoCodigoProduto()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            EditarProdutoPO editarProduto = new EditarProdutoPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            // gera codigo de produto randomico de modo que nao repita e falhe o teste
            Guid nomeCodigoRandomico = Guid.NewGuid();

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .SelecionarNoProdutoDaLista();

            editarProduto
                           .VerificarTituloTelaEditarProduto()
                           .EditarCodigoProduto("EditCod" + nomeCodigoRandomico.ToString())
                           .ClicarSalvarAlteracaoProduto()
                           .VerificarMensagemDeProdutoAlteradoComSucesso();

            driver.Quit();
        }

        [TestMethod]
        public void TesteEditarCampoFabricanteProduto()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            EditarProdutoPO editarProduto = new EditarProdutoPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .SelecionarNoProdutoDaLista();

            editarProduto
                           .VerificarTituloTelaEditarProduto()
                           .EditarFabricanteProduto("Fabricante TESTE")
                           .ClicarSalvarAlteracaoProduto()
                           .VerificarMensagemDeProdutoAlteradoComSucesso();

            driver.Quit();
        }

        [TestMethod]
        public void TesteEditarDetalhesProduto()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            EditarProdutoPO editarProduto = new EditarProdutoPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .SelecionarNoProdutoDaLista();

            editarProduto
                           .VerificarTituloTelaEditarProduto()
                           .EditarDetalhesProduto("Edit Detalhes do produto txt")
                           .ClicarSalvarAlteracaoProduto()
                           .VerificarMensagemDeProdutoAlteradoComSucesso();

            driver.Quit();
        }

        [TestMethod]
        public void TesteEditarPrecoProduto()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            EditarProdutoPO editarProduto = new EditarProdutoPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .SelecionarNoProdutoDaLista();

            editarProduto
                           .VerificarTituloTelaEditarProduto()
                           .EditarPrecoProduto(9999.99)
                           .ClicarSalvarAlteracaoProduto()
                           .VerificarMensagemDeProdutoAlteradoComSucesso();

            driver.Quit();
        }

        [TestMethod]
        public void TesteEditarCampoTipoProduto()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            EditarProdutoPO editarProduto = new EditarProdutoPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .SelecionarNoProdutoDaLista();

            editarProduto
                           .VerificarTituloTelaEditarProduto()
                           .SelecionarTipoMedicamento("Materiais Médicos")
                           .ClicarSalvarAlteracaoProduto()
                           .VerificarMensagemDeProdutoAlteradoComSucesso();

            driver.Quit();
        }

        [TestMethod]
        public void TesteEditarCampoStatusProduto()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            EditarProdutoPO editarProduto = new EditarProdutoPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .SelecionarNoProdutoDaLista();

            editarProduto
                           .VerificarTituloTelaEditarProduto()
                           .SelecionarStatusProduto("Ativo")
                           .ClicarSalvarAlteracaoProduto()
                           .VerificarMensagemDeProdutoAlteradoComSucesso();

            driver.Quit();
        }

        [TestMethod]
        public void TesteEditarTodosOsCamposDeProduto()
        {
            var driver = new ChromeDriver();

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            EditarProdutoPO editarProduto = new EditarProdutoPO(driver);

            ListarProdutoPO listarProduto = new ListarProdutoPO(driver);

            // gera nome e codigo de produto randomico de modo que nao repita e falhe o teste
            Guid nomeProdutoRandomico = Guid.NewGuid();
            Guid nomeCodigoRandomico = Guid.NewGuid();

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            listarProduto.AcessarTelaListarProdutos()
                         .SelecionarNoProdutoDaLista();

            editarProduto
                           .VerificarTituloTelaEditarProduto()
                           .EditarNomeProduto("EditProd" + nomeProdutoRandomico.ToString())
                           .EditarCodigoProduto("EditCod" + nomeCodigoRandomico.ToString())
                           .EditarFabricanteProduto("Fabricante TESTE")
                           .EditarDetalhesProduto("Detalhes do produto txt")
                           .EditarPrecoProduto(1230.00)
                           .SelecionarTipoMedicamento("Materias Médicos")
                           .SelecionarStatusProduto("Inativo")
                           .ClicarSalvarAlteracaoProduto()
                           .VerificarMensagemDeProdutoAlteradoComSucesso();

            driver.Quit();
        }
    }
}
