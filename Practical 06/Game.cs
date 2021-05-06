using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playtictactoe
{
    public class Game
    {
        private readonly IWebDriver _webDriver;

        private By _cellTopLeft = By.CssSelector("div.square:nth-child(1)");
        private By _cellTopRight = By.CssSelector("div.square:nth-child(3)");
        private By _cellTop = By.CssSelector("div.square:nth-child(2)");
        private By _celliTheMiddleOnTheLeft = By.CssSelector("div.square:nth-child(4)");
        private By _cellTheMiddleOnTheRight = By.CssSelector("div.square:nth-child(6)");
        private By _cellTheMiddleOnThe = By.CssSelector("div.square:nth-child(5)");
        private By _cellBottomLeft = By.CssSelector("div.square:nth-child(7)");
        private By _cellBottomRight = By.CssSelector("div.square:nth-child(9)");
        private By _cellBottom = By.CssSelector("div.square:nth-child(8)");
        private By _accountBlockMassage = By.CssSelector("div.FormErrorText__error---nzyq:nth-child(1) > div:nth-child(1)");

        public SignInPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public SignInPage OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://newbookmodels.com/auth/signin");
            return this;
        }

        public SignInPage SetEmail(string email)
        {
            _webDriver.FindElement(_emailField).SendKeys(email);
            return this;
        }

        public SignInPage SetPassword(string password)
        {
            _webDriver.FindElement(_passwordField).SendKeys(password);
            return this;
        }

        public void ClickLoginButton()
        {
            _webDriver.FindElement(_loginButton).Click();
        }

        public string GetUserAccountBlockMessage()
        {
            return _webDriver.FindElement(_accountBlockMassage).Text;
        }
    }
}