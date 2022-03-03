using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.Factories
{
    public class GenericFactory<T> where T : class
    {
        public static T CreateObject()
        {
            var type = typeof(T);
            var instance = (T)Activator.CreateInstance(type);
            return instance;
        }
    }
}
