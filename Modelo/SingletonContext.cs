using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class SingletonContext
    {
        private static Container Container = null;

        public static void CreateInstance()
        {
            Bootstrap();
        }

        private static void Bootstrap()
        {
            if (Container == null)
            {
                Container = new Container();
                Container.Register<DbContext, Context>();
            }
        }

        public static Modelo.Context GetContext()
        {
            var context = Container.GetInstance<Modelo.Context>();
            return context;
        }
    }
}
