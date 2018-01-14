using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleInjectorWebAPIDemo
{
    public class HelloWorldService : IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello world";
        }
    }
}
