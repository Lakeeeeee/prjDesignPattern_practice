using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjConsole
{
    public class Class1
    {

        public string HelloWorld(string name)
        {
            return  $"Hello {name}!";
        }

        public bool FisrtMethod(int inputNumber)
        {
            if(inputNumber < 100)
            {
                return false;
            }
            return true;
        }
    }
}
