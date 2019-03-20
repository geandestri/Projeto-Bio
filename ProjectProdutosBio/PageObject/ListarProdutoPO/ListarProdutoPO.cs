using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProdutosBio.PageObject.ListarProdutoPO
{
    class ListarProdutoPO
    {

        private IWebDriver driver;

        public ListarProdutoPO(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Acesso Tela

        internal ListarProdutoPO AcessarTelaListarProdutos()
        {
            driver.FindElement(By.XPath("/html/body/nav/div[2]/ul[1]/li[1]/a/span[1]")).Click();
            driver.FindElement(By.XPath("/html/body/nav/div[2]/ul[1]/li[1]/ul/li[1]/a")).Click();

            return this;
        }


        #endregion

        internal ListarProdutoPO SelecionarNoProdutoDaLista()
        {
            driver.FindElement(By.CssSelector(".hover-cursor > td")).Click();

            return this;
        }

        internal ListarProdutoPO VerificarColunasDaTelaListaDeProdutos()
        {
            IList<IWebElement> list = driver.FindElements(By.TagName("tr"));

            if (list.Count != 0)
            {
                foreach (IWebElement e in list)
                {
                    List<IWebElement> List2 = e.FindElements(By.TagName("th")).ToList();

                    foreach (IWebElement e2 in List2)
                    {
                        if (List2.Count == 4)
                        {
                            string nome = List2[0].Text;
                            string tipo = List2[1].Text;
                            string fabricante = List2[2].Text;
                            string status = List2[3].Text;

                            Assert.AreEqual("Nome", nome);
                            Assert.AreEqual("Tipo", tipo);
                            Assert.AreEqual("Fabricante", nome);
                            Assert.AreEqual("Status", nome);
                        }
                        else
                        {
                            Assert.Fail("Lista de Produtos apresentada não está correta!");
                            break;
                        }

                        break;
                    }

                }
            }
            else
            {
                Assert.Fail("Lista de Produtos não foi apresentada!");
            }

            return this;
        }

        internal ListarProdutoPO VerificarColunasDaTelaListaDeProdutosParaPassar()
        {
            IList<IWebElement> list = driver.FindElements(By.TagName("tr"));

            if (list.Count != 0)
            {
                foreach (IWebElement e in list)
                {
                    List<IWebElement> List2 = e.FindElements(By.TagName("th")).ToList();

                    foreach (IWebElement e2 in List2)
                    {
                        if (List2.Count == 5)
                        {
                            string nome = List2[0].Text;
                            string codigo = List2[1].Text;
                            string fabricante = List2[2].Text;
                            string tipo = List2[3].Text;
                            string status = List2[4].Text;

                            Assert.AreEqual("Nome", nome);
                            Assert.AreEqual("Codigo", codigo);
                            Assert.AreEqual("Fabricante", fabricante);
                            Assert.AreEqual("Tipo", tipo);
                            Assert.AreEqual("Status", status);
                        }
                        else
                        {
                            Assert.Fail("Lista de Produtos apresentada não está correta!");
                            break;
                        }

                        break;
                    }

                }
            }
            else
            {
                Assert.Fail("Lista de Produtos não foi apresentada!");
            }

            return this;
        }
    

        internal ListarProdutoPO VerificarQuantidadeDeRegistrosPorPagina()
        {
            bool contagemRegistros = false; 
            IList<IWebElement> list = driver.FindElements(By.TagName("tr"));

            if (list.Count == 11) // se contar 11 significa que são 10 registros por pagina + 1 das colunas que contem os titulos.
            {
                contagemRegistros = true;
                Assert.IsTrue(contagemRegistros);
            }
            else
            {
                Assert.Fail("Registros alterado");
            }

            return this;
        }
    }
}
