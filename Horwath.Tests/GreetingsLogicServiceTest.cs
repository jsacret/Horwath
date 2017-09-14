using Horwath.BLL;
using Horwath.BLL.Contracts;
using Horwath.DAL;
using Horwath.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.Tests
{
    [TestClass]
    public class GreetingsLogicServiceTest
    {
        [TestMethod]
        public void GetGreetingTestForHello()
        {
            Mock<IGreetingsRepository> greetingsRepoisitory = new Mock<IGreetingsRepository>();
            greetingsRepoisitory.Setup<Greeting>(t=> t.GetGreetingByLanguage("English")).Returns(new Greeting() { GreetingText = "Hello", GreetingsId = 1, Language = "English" });
            IGreetingsLogicService _greetingsLogicService = new GreetingsLogicService(greetingsRepoisitory.Object);
            var greeting = _greetingsLogicService.GetGreeting("English");

            Assert.AreEqual("Hello World!", greeting.GreetingText);
        }
    }
}
