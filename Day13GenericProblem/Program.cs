﻿using System;
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
            string output2 = MaximumNumber.MaximumStringValue("vrushali", "Mrunal", "Mayuri");
            Console.WriteLine(output2);

            int[] intArray = { 112, 123, 154, 146 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            GenericRefactor2<int> generic2 = new GenericRefactor2<int>(123, 146, 146);
            generic2.MaxMethod();




        }


    }
}
