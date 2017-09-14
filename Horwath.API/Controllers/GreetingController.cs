using Horwath.BLL;
using Horwath.BLL.Contracts;
using Horwath.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Horwath.API.Controllers
{
    public class GreetingController : ApiController
    {
        private IGreetingsLogicService _greetingsLogicService;
        public GreetingController(IGreetingsLogicService greetingLogicService)
        {
            _greetingsLogicService = greetingLogicService;
        }
        public Greeting Get(string language)
        {
            return _greetingsLogicService.GetGreeting(language);
        }

        public IEnumerable<Greeting> Get()
        {
            return _greetingsLogicService.GetGreetingsJSONExample();
        }
    }
}
