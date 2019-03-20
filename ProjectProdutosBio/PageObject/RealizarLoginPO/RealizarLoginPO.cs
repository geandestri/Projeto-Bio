using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProdutosBio.PageObject.RealizarLoginPO
{
    public class RealizarLoginPO
    {
        public RealizarLoginPO(IWebDriver driver)
        {
            this.driver = driver;
        }

        public RealizarLoginPO()
        {
            RealizarLogin("gean.destri@gmail.com", "Bionexo2019");
        }

        protected IWebDriver driver;


        public RealizarLoginPO AcessarPaginaDeLogin()
        {
            driver.Navigate().GoToUrl("http://qainterview.qa.cloud.bionexo.com.br/");
            driver.Manage().Window.Maximize();

            return this;
        }

        public RealizarLoginPO RealizarLogin(string usuario, string senha)
        {
            driver.FindElement(By.Id("user_email")).SendKeys(usuario);
            driver.FindElement(By.Id("user_password")).SendKeys(senha);
            driver.FindElement(By.Id("sign_in")).Click();

            return this;
        }

        //public void FecharBrowser()
        //{
        //    driver.Quit();
        //}

    }

}

