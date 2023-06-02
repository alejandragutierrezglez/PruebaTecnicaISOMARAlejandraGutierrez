using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium.DevTools.V111.DOM;
using ML;
using System.Drawing.Drawing2D;

namespace WebScraping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.mercadolibre.com.mx/");
            var txtMercadoLibre = driver.FindElement(By.ClassName("nav-search-input"));
            txtMercadoLibre.SendKeys("maletas jony");
            txtMercadoLibre.Submit();

            //var searchCard = (driver.FindElements(By.XPath("//*[@id=\"root-app\"]/div/div[2]/section/ol[1]/li[2]/div/div/div[1]/a")));

            var searchCard = driver.FindElements(By.ClassName("ui-search-layout__item"));
           
            //txtMercadoLibre = (IWebElement)driver.FindElements(By.ClassName("ui-search-layout__item"));

            foreach (var card in searchCard)
            {
                //ui - search - result__image shops__picturesStyles
                var viewCardDetailsSelectt = driver.FindElements(By.CssSelector("ui-search-result__content"));
         
                var viewCardDetailsSelect = driver.FindElement(By.ClassName("ui-search-link"));
              
                var innerHtml = viewCardDetailsSelect.GetAttribute("href");
                //Console.WriteLine("Links: " + innerHtml);
                //var direccionarDetalles = driver.FindElements(By.LinkText(innerHtml));
                Console.WriteLine("------------------------------");
                Console.WriteLine(card.Text);
            }
            ML.Maleta maleta = new ML.Maleta();
            if (maleta.Marca == "JONY")
            {
                ML.Result result = BL.Maleta.Add(maleta);            
            }
            //var viewCardDetails = driver.FindElement(By.ClassName("ui-search-item__group ui-search-item__group--price shops__items-group"));
            //viewCardDetails.Submit();

            //foreach (var search in searchCard)
            //{
            //    var viewCardDetails = driver.FindElement(By.ClassName("ui-search-item__group__element shops__items-group-details ui-search-link"));
            //}

            Console.ReadKey();
        }

    }
}

