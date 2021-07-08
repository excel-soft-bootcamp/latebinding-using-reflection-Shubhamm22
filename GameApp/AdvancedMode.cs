using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class AdvancedMode
    {
        public void Load(string pathname, string classname, string methodname, string playername, int points)
        {
            System.Reflection.Assembly nameLib =
              System.Reflection.Assembly.LoadFile(pathname);
            System.Type nameClass = nameLib.GetType(classname);
            if (nameClass != null)
            {
                if (nameClass.IsClass)
                {
                    Object objRef = System.Activator.CreateInstance(nameClass);
                    System.Reflection.MethodInfo _methodRef = nameClass.GetMethod(methodname);
                    if (!_methodRef.IsStatic)
                    {
                        object advanceResult = _methodRef.Invoke(objRef, new object[] {(playername, points) });
                        Console.WriteLine(advanceResult.ToString());
                    }
                }

            }
        }
    }
}
