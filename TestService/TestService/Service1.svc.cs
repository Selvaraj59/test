using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestService
{
    public class Service1 : IService1
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
