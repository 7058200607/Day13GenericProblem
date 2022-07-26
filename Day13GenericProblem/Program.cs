using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace  Day13GenericProblem
{
    public class program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine(" Find The Maximum Number!");
            int output = MaximumNumber.AMaximumNumber(11, 22, 33);
            Console.WriteLine(output);
            float output1 = MaximumNumber.MaximumFloatValue(5.4f, 52.4f, 11.5f);
            Console.WriteLine(output1);

        }


    }
}
