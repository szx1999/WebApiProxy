using System;
using System.Collections.Generic;
using System.Text;

namespace Jawasoft.ServiceProxy.Test
{
    public class TestService:ITestService
    {
        public string Hi(string name)
        {
            return "Hi " + name;
        }
    }
}
