using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newmethod.com.Mainclass
{
    class Product :toInherit
    {
        
        new public void inherit()
        {
            Console.WriteLine("Inherit with New Keyword");
            Console.ReadLine();
        }
    }

}
