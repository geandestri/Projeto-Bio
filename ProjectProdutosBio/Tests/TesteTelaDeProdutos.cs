using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using ProjectProdutosBio.PageObject.CadastrarProdutoPO;
using ProjectProdutosBio.PageObject.RealizarLoginPO;

namespace ProjectProdutosBio.Tests
{

    [TestClass]
    public class TesteTelaDeProdutos
    { 

        [TestMethod]
        public void TesteCadastroDeProdutosMedicamentoAtivo()
        {
            var driver = new ChromeDriver();

            CadastrarProdutoPO cadastroProduto = new CadastrarProdutoPO(driver);

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            // gera nome e codigo de produto randomico de modo que nao repita e falhe o teste
            Guid nomeProdutoRandomico = Guid.NewGuid();
            Guid nomeCodigoRandomico = Guid.NewGuid();

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com","Bionexo2019");

            cadastroProduto
                           .AcessarTelaCadastroProdutos()
                           .VerificarTituloTelaCadastroDeProduto()
                           .InformarNomeProduto("Prod" + nomeProdutoRandomico.ToString())
                           .InformarCodigoProduto("Cod" + nomeCodigoRandomico.ToString())
                           .InformarFabricanteProduto("Fabricante TESTE")
                           .InformarDetalhesProduto("Detalhes do produto txt")
                           .InformarPrecoProduto(1230.00)
                           .SelecionarTipoMedicamento("Medicamento")
                           .SelecionarStatusProduto("Ativo")
                           .ClicarSalvarProduto()
                           .VerificarMensagemDeProdutoCadastradoComSucesso();

            driver.Quit();
        }


        [TestMethod]
        public void TesteCadastroDeProdutosMedicamentoInativo()
        {
            var driver = new ChromeDriver();

            CadastrarProdutoPO cadastroProduto = new CadastrarProdutoPO(driver);

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            // gera nome e codigo de produto randomico de modo que nao repita e falhe o teste
            Guid nomeProdutoRandomico = Guid.NewGuid();
            Guid nomeCodigoRandomico = Guid.NewGuid();

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            cadastroProduto
                           .AcessarTelaCadastroProdutos()
                           .VerificarTituloTelaCadastroDeProduto()
                           .InformarNomeProduto("Prod" + nomeProdutoRandomico.ToString())
                           .InformarCodigoProduto("Cod" + nomeCodigoRandomico.ToString())
                           .InformarFabricanteProduto("Fabricante TESTE")
                           .InformarDetalhesProduto("Detalhes do produto txt")
                           .InformarPrecoProduto(1230.00)
                           .SelecionarTipoMedicamento("Medicamento")
                           .SelecionarStatusProduto("Inativo")
                           .ClicarSalvarProduto()
                           .VerificarMensagemDeProdutoCadastradoComSucesso();

            driver.Quit();
        }

        [TestMethod]
        public void TesteCadastroDeProdutosMateriaisMedicosInativo()
        {
            var driver = new ChromeDriver();

            CadastrarProdutoPO cadastroProduto = new CadastrarProdutoPO(driver);

            RealizarLoginPO realizarLogin = new RealizarLoginPO(driver);

            // gera nome e codigo de produto randomico de modo que nao repita e falhe o teste
            Guid nomeProdutoRandomico = Guid.NewGuid();
            Guid nomeCodigoRandomico = Guid.NewGuid();

            realizarLogin.AcessarPaginaDeLogin()
                         .RealizarLogin("gean.destri@gmail.com", "Bionexo2019");

            cadastroProduto
                           .AcessarTelaCadastroProdutos()
                           .VerificarTituloTelaCadastroDeProduto()
                           .InformarNomeProduto("Prod" + nomeProdutoRandomico.ToString())
                           .InformarCodigoProduto("Cod" + nomeCodigoRandomico.ToString())
                           .InformarFabricanteProduto("Fabricante TESTE")
                           .InformarDetalhesProduto("Detalhes do produto txt")
                           .InformarPrecoProduto(1230.00)
                           .SelecionarTipoMedicamento("Materiais Médicos")
                           .SelecionarStatusProduto("Inativo")
                           .ClicarSalvarProduto()
                           .VerificarMensagemDeProdutoCadastradoComSucesso();

            driver.Quit();
        }
    }
}
