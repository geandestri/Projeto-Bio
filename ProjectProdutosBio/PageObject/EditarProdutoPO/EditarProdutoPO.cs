using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProdutosBio.PageObject.EditarProdutoPO
{
    public class EditarProdutoPO
    {
        private IWebDriver driver;

        public EditarProdutoPO(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Metodo de Verificacao de Mensagens e/ou Lables
        internal EditarProdutoPO VerificarTituloTelaEditarProduto()
        {
            var tituloTela = driver.FindElement(By.XPath("/html/body/div/h1")).Text;
            Assert.AreEqual("Editar Produto", tituloTela);

            return this;
        }

        internal EditarProdutoPO VerificarMensagemDeProdutoAlteradoComSucesso()
        {
            var mensagem = driver.FindElement(By.Id("flash_notice")).Text;
            Assert.AreEqual(Resources.Mensagens.Validacao_VerificarMensagemDeProdutoAlteradoComSucesso, mensagem);

            return this;
        }

        #endregion

        #region Metodos de Preenchimento de Campos
        internal EditarProdutoPO EditarNomeProduto(string nome)
        {
            driver.FindElement(By.Id("product_name")).Clear();
            driver.FindElement(By.Id("product_name")).SendKeys(nome);
            return this;
        }

        internal EditarProdutoPO EditarCodigoProduto(string codigo)
        {
            driver.FindElement(By.Id("product_code")).Clear();
            driver.FindElement(By.Id("product_code")).SendKeys(codigo);
            return this;
        }

        internal EditarProdutoPO EditarFabricanteProduto(string fabricante)
        {
            driver.FindElement(By.Id("product_manufacturer")).Clear();
            driver.FindElement(By.Id("product_manufacturer")).SendKeys(fabricante);
            return this;
        }

        internal EditarProdutoPO EditarDetalhesProduto(string detalhes)
        {
            driver.FindElement(By.Id("product_description")).Clear();
            driver.FindElement(By.Id("product_description")).SendKeys(detalhes);
            return this;
        }

        internal EditarProdutoPO EditarPrecoProduto(double preco)
        {
            driver.FindElement(By.Id("product_price")).Clear();
            driver.FindElement(By.Id("product_price")).SendKeys(preco.ToString());
            return this;
        }

        #endregion

        #region Metodos de Selecao de Combos/Botoes

        internal EditarProdutoPO SelecionarTipoMedicamento(string medicamento)
        {
            new SelectElement(driver.FindElement(By.Id("product_kind"))).SelectByText(medicamento);
            return this;
        }

        internal EditarProdutoPO SelecionarStatusProduto(string status)
        {
            new SelectElement(driver.FindElement(By.Id("product_status"))).SelectByText(status);
            return this;
        }

        internal EditarProdutoPO ClicarSalvarAlteracaoProduto()
        {
            driver.FindElement(By.CssSelector("div:nth-child(6) > div:nth-child(4) > div > div > input")).Click();

            return this;
        }
        #endregion

    }
}
