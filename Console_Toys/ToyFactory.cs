using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Toys
{
    public class ToyFactory
    {
        public IToy MakeToy(string toyName)
        {
            
            IToy toy = new PS5();
            
            return toy;
        }

    }
}
