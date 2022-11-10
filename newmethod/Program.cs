using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newmethod.com.Mainclass;

namespace newmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Keyword Used To Inherit the same Name Function in the Main Class");
            
            Console.ReadLine();
            
            Product mainclass = new Product();
            mainclass.inherit();

            Console.ReadLine() ;
            
        
        
        }
    }
}
