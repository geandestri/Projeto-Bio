using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using ProjectProdutosBio.PageObject.CadastrarProdutoPO;
using ProjectProdutosBio.PageObject.RealizarLoginPO;

namespace ProjectProdutosBio.Tests
{

    [TestClass]
    public class TesteTelaDeProdutosExceptions
    {

        [TestMethod]
        public void TesteCadastroDeProdutosCriticaCampoNomeProdutoObrigatorio()
        {
            var driver = new ChromeDriver();

            CadastrarProdutoPO cadastroProduto = new CadastrarProdutoPO(driver);

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            cadastroProduto
                           .AcessarTelaCadastroProdutos()
                           .VerificarTituloTelaCadastroDeProduto()
                           .InformarCodigoProduto("Cod 999")
                           .InformarFabricanteProduto("Fabricante TESTE")
                           .InformarDetalhesProduto("Detalhes do produto txt")
                           .InformarPrecoProduto(1230.00)
                           .SelecionarTipoMedicamento("Medicamento")
                           .SelecionarStatusProduto("Ativo")
                           .ClicarSalvarProduto()
                           .VerificarMensagemDeCampoNomeProdutoObrigatorio();

            driver.Quit();
        }

        [TestMethod]
        public void TesteCadastroDeProdutosVerificarCriticaCampoCodigoProdutoObrigatorio()
        {
            var driver = new ChromeDriver();

            CadastrarProdutoPO cadastroProduto = new CadastrarProdutoPO(driver);

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            cadastroProduto
                           .AcessarTelaCadastroProdutos()
                           .VerificarTituloTelaCadastroDeProduto()
                           .InformarNomeProduto("Nome Produto Teste")
                           .InformarFabricanteProduto("Fabricante TESTE")
                           .InformarDetalhesProduto("Detalhes do produto txt")
                           .InformarPrecoProduto(1230.00)
                           .SelecionarTipoMedicamento("Medicamento")
                           .SelecionarStatusProduto("Ativo")
                           .ClicarSalvarProduto()
                           .VerificarMensagemDeCampoCodigoProdutoObrigatorio();

            driver.Quit();
        }

        [TestMethod]
        public void TesteCadastroDeProdutosVerificarCriticaCampoFabricanteProdutoObrigatorio()
        {
            var driver = new ChromeDriver();

            CadastrarProdutoPO cadastroProduto = new CadastrarProdutoPO(driver);

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            cadastroProduto
                           .AcessarTelaCadastroProdutos()
                           .VerificarTituloTelaCadastroDeProduto()
                           .InformarNomeProduto("Nome Produto Teste")
                           .InformarCodigoProduto("Cod 999")
                           .InformarDetalhesProduto("Detalhes do produto txt")
                           .InformarPrecoProduto(1230.00)
                           .SelecionarTipoMedicamento("Medicamento")
                           .SelecionarStatusProduto("Ativo")
                           .ClicarSalvarProduto()
                           .VerificarMensagemDeCampoFabricanteProdutoObrigatorio();

            driver.Quit();
        }

        [TestMethod]
        public void TesteCadastroDeProdutosVerificarCriticaCampoPrecoProdutoObrigatorio()
        {
            var driver = new ChromeDriver();

            CadastrarProdutoPO cadastroProduto = new CadastrarProdutoPO(driver);

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            cadastroProduto
                           .AcessarTelaCadastroProdutos()
                           .VerificarTituloTelaCadastroDeProduto()
                           .InformarNomeProduto("Nome Produto Teste")
                           .InformarCodigoProduto("Cod 999")
                           .InformarFabricanteProduto("Fabricante TESTE")
                           .InformarDetalhesProduto("Detalhes do produto txt")
                           .SelecionarTipoMedicamento("Medicamento")
                           .SelecionarStatusProduto("Ativo")
                           .ClicarSalvarProduto()
                           .VerificarMensagemDeCampoPrecoProdutoObrigatorio();

            driver.Quit();

        }

        [TestMethod]
        public void TesteCadastroDeProdutosCriticaCampoCodigoJaExistente()
        {
            var driver = new ChromeDriver();

            CadastrarProdutoPO cadastroProduto = new CadastrarProdutoPO(driver);

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            cadastroProduto
                           .AcessarTelaCadastroProdutos()
                           .VerificarTituloTelaCadastroDeProduto()
                           .InformarNomeProduto("Nome Produto Teste")
                           .InformarCodigoProduto("Cod 123")
                           .InformarFabricanteProduto("Fabricante TESTE")
                           .InformarDetalhesProduto("Detalhes do produto txt")
                           .InformarPrecoProduto(1230.00)
                           .SelecionarTipoMedicamento("Medicamento")
                           .SelecionarStatusProduto("Ativo")
                           .ClicarSalvarProduto()
                           .VerificarMensagemDeCampoCodigoJaExistente();

            driver.Quit();
        }
    }
}