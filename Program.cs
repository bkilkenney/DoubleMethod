using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a method named "Double" to calculate and return an integer number doubled. 
            for example. Double(7) should return 14 */

            
            Console.WriteLine("Select a number");
            
           
        }
        static int Double(int number)
            //Method double is asking for an INT NUMBER.  NUMBER is a temporary variable

        {
            int answer = number * 2;
            Console.WriteLine(answer);
                
            return answer;
        }
    }
}
