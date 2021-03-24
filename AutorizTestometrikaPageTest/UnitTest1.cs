using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _actButton = By.XPath("//a[text()='К тестам!']");
        private readonly By _testButton = By.XPath("//span[text()='Темперамент. Опросник К. Юнга']");
      
        private readonly By _test1Button = By.XPath("//span[text()='Уровень депрессии']");
        private readonly By _startButton = By.XPath("//span[text()='Начать тест']");
        private readonly By _varButton = By.XPath("//span[text()='Совершенно неверно']");
       
        private readonly By _menuButton = By.XPath("//span");
        private readonly By _сhooseButton = By.XPath("//a[text()='Личность и характер']");

        private readonly By _singInButton = By.XPath("//span[text()='Войти']");
        
        private readonly By _singEmailButton = By.XPath("//input[@name='USER_LOGIN']");
        private const string _login = "boichun.studrada@gmail.com";
        private readonly By _singPasswordButton = By.XPath("//input[@name='USER_PASSWORD']");
        private const string _pass = "Grea56tT120";
        private const string _pass1 = "11111";
        private readonly By _submitButton = By.XPath("//button[@type='submit']");


        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"D:\ФІОТ\3ий курс\6ой семестр\КПИ\Лаб3\AutorizTestometrikaPageTest\AutorizTestometrikaPageTest\Drivers\");
            driver.Navigate().GoToUrl("https://testometrika.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var act = driver.FindElement(_actButton);
            act.Click();
            Thread.Sleep(1200);
            var choose = driver.FindElement(_testButton);
            choose.Click();
        }

        [Test]
        public void Test2()
        {
            var act = driver.FindElement(_actButton);
            act.Click();
            Thread.Sleep(1200);
            var choose = driver.FindElement(_test1Button);
            choose.Click();
            Thread.Sleep(1000);
            var start = driver.FindElement(_startButton);
            start.Click();
            Thread.Sleep(1000);
            var v = driver.FindElement(_varButton);
            v.Click();

        }

        [Test]
        public void Test3()
        {
            var menu = driver.FindElement(_menuButton);
            menu.Click();
            Thread.Sleep(2000);;
            var choose = driver.FindElement(_сhooseButton);
            choose.Click();
        }

        [Test]
        public void Test4()
        {
            var sing = driver.FindElement(_singInButton);
            sing.Click();
            Thread.Sleep(2000);
            var singEmail = driver.FindElement(_singEmailButton);
            singEmail.SendKeys(_login);
            Thread.Sleep(2000);
            var singPassword = driver.FindElement(_singPasswordButton);
            singPassword.SendKeys(_pass);
            Thread.Sleep(2000);
            var submit = driver.FindElement(_submitButton);
            submit.Click();
        }

        [Test]
        public void Test5()
        {
            var sing = driver.FindElement(_singInButton);
            sing.Click();
            Thread.Sleep(2000);
            var singEmail = driver.FindElement(_singEmailButton);
            singEmail.SendKeys(_login);
            Thread.Sleep(2000);
            var singPassword = driver.FindElement(_singPasswordButton);
            singPassword.SendKeys(_pass1);
            Thread.Sleep(2000);
            var submit = driver.FindElement(_submitButton);
            submit.Click();
        }




        [TearDown]
        public void TearDown()
        {  
        }
    }
}