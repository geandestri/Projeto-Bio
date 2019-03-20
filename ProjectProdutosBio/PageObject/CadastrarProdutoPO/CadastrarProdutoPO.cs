using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectProdutosBio.PageObject.RealizarLoginPO;


namespace ProjectProdutosBio.PageObject.CadastrarProdutoPO
{
    public class CadastrarProdutoPO
    {
        private IWebDriver driver;

        public CadastrarProdutoPO(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Acesso Tela

        internal CadastrarProdutoPO AcessarTelaCadastroProdutos()
        {
            // driver.Navigate().GoToUrl("http://qainterview.qa.cloud.bionexo.com.br/products/new");

            driver.FindElement(By.XPath("/html/body/nav/div[2]/ul[1]/li[1]/a/span[1]"))
                .Click();
            driver.FindElement(By.XPath("/html/body/nav/div[2]/ul[1]/li[1]/ul/li[2]/a"))
                .Click();

            return this;
        }


        #endregion

        #region Metodos de Preenchimento de Campos
        internal CadastrarProdutoPO InformarNomeProduto(string nome)
        {
            driver.FindElement(By.Id("product_name")).SendKeys(nome);
            return this;
        }

        internal CadastrarProdutoPO InformarCodigoProduto(string codigo)
        {
            driver.FindElement(By.Id("product_code")).SendKeys(codigo);
            return this;
        }

        internal CadastrarProdutoPO InformarFabricanteProduto(string fabricante)
        {
            driver.FindElement(By.Id("product_manufacturer")).SendKeys(fabricante);
            return this;
        }

        internal CadastrarProdutoPO InformarDetalhesProduto(string detalhes)
        {
            driver.FindElement(By.Id("product_description")).SendKeys(detalhes);
            return this;
        }

        internal CadastrarProdutoPO InformarPrecoProduto(double preco)
        {
            driver.FindElement(By.Id("product_price")).SendKeys(preco.ToString());
            return this;
        }

        #endregion

        #region Metodos de Selecao de Combos/Botoes

        internal CadastrarProdutoPO SelecionarTipoMedicamento(string medicamento)
        {
            new SelectElement(driver.FindElement(By.Id("product_kind"))).SelectByText(medicamento);
            return this;
        }

        internal CadastrarProdutoPO SelecionarStatusProduto(string status)
        {
            new SelectElement(driver.FindElement(By.Id("product_status"))).SelectByText(status);
            return this;
        }

        internal CadastrarProdutoPO ClicarSalvarProduto()
        {
            //driver.FindElement(By.ClassName("btn btn-primary")).Click();
            driver.FindElement(By.XPath("//*[@id='new_product']/div[3]/div[4]/div/div/input")).Click();
            
            return this;
        }
        #endregion

        #region Metodo de Verificacao de Mensagens e/ou Lables

        internal CadastrarProdutoPO VerificarTituloTelaCadastroDeProduto()
        {
            var tituloTela = driver.FindElement(By.XPath("/html/body/div/h1")).Text;
            Assert.AreEqual("Cadastrar Produto", tituloTela);

            return this;
        }
        

        internal CadastrarProdutoPO VerificarMensagemDeProdutoCadastradoComSucesso()
        {
            var mensagem = driver.FindElement(By.Id("flash_notice")).Text;
            Assert.AreEqual(Resources.Mensagens.Validacao_VerificarMensagemDeProdutoCadastradoComSucesso, mensagem);

            return this;
        }

        internal CadastrarProdutoPO VerificarMensagemDeCampoNomeProdutoObrigatorio()
        {
            var mensagem = driver.FindElement(By.XPath("//*[@id='new_product']/div[2]/div[1]/div/span")).Text;
            Assert.AreEqual(Resources.Mensagens.Validacao_VerificarMensagemDeCampoNomeProdutoObrigatorio, mensagem);

            return this;
        }

        internal CadastrarProdutoPO VerificarMensagemDeCampoCodigoProdutoObrigatorio()
        {
            var mensagem = driver.FindElement(By.XPath("//*[@id='new_product']/div[2]/div[2]/div/span")).Text;
            Assert.AreEqual(Resources.Mensagens.Validacao_VerificarMensagemDeCampoCodigoProdutoObrigatorio, mensagem);

            return this;
        }

        internal CadastrarProdutoPO VerificarMensagemDeCampoFabricanteProdutoObrigatorio()
        {
            var mensagem = driver.FindElement(By.XPath("//*[@id='new_product']/div[3]/div/div/span")).Text;
            Assert.AreEqual(Resources.Mensagens.Validacao_VerificarMensagemDeCampoFabricanteProdutoObrigatorio, mensagem);

            return this;
        }

        internal CadastrarProdutoPO VerificarMensagemDeCampoDetalhesProdutoObrigatorio()
        {
            // quando dev implementar alterar o XPath que será gerado
            // var mensagem = driver.FindElement(By.XPath("//*[@id='new_product']/div[3]/div/div/span")).Text;
            // Assert.AreEqual(Resources.Mensagens.Validacao_VerificarMensagemDeCampoDetalhesProdutoObrigatorio, mensagem);

            return this;
        }

        internal CadastrarProdutoPO VerificarMensagemDeCampoPrecoProdutoObrigatorio()
        {
            var mensagem = driver.FindElement(By.XPath("//*[@id='new_product']/div[4]/div[2]/div/div/span")).Text;
            Assert.AreEqual(Resources.Mensagens.Validacao_VerificarMensagemDeCampoPrecoProdutoObrigatorio, mensagem);

            return this;
        }

        internal CadastrarProdutoPO VerificarMensagemDeCampoCodigoJaExistente()
        {
            var mensagem = driver.FindElement(By.XPath("//*[@id='new_product']/div[2]/div[2]/div/span")).Text;
            Assert.AreEqual(Resources.Mensagens.Validacao_VerificarMensagemDeCampoCodigoJaExistente, mensagem);

            return this;
        }
        


        #endregion

    }
}
