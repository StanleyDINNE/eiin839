using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer
{
    internal class Mymethods
    {
        static string MyMethod(string dis, string dat)
        {
            return "<html><body> MyMethod1 called with \"" + dis + "\" and \"" + dat + "\"</body></html>";
        }

        static string MyMethod2(string dis, string dat)
        {
            return "<html><body> MyMethod2 called with \"" + dis + "\" and \"" + dat + "\"</body></html>";
        }

        public static string Invoke(string MethodName, string Parameter1, string Parameter2)
        {
            string[] Params = {Parameter1, Parameter2};
            MethodInfo Method = typeof(Mymethods).GetMethod(MethodName, new Type[] {typeof(string), typeof(string)});
            if (Method == null)
            {
                return $"<html><body>404: Method {MethodName} not found</body></html>";
            }
            return (string) Method.Invoke(new Mymethods(), Params);
        }
    }
}
